using System;
using System.Collections.Generic;
using System.IO;
using NPOI.XSSF.UserModel;
using System.Linq;
using System.Reflection;

namespace ArrowEye_Automation_Framework.Excel
{
    public class ExcelTestMethodSource
    {
        public static IEnumerable<(string className, string methodName)> GetTestMethods(string filePath)
        {
            var testMethods = new List<(string, string)>();

            using (FileStream file = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                XSSFWorkbook workbook = new XSSFWorkbook(file);

                var classesSheet = workbook.GetSheet("Runners"); // The first sheet contains class names

                if (classesSheet != null)
                {
                    // Iterate over each class listed in the 'Classes' sheet
                    for (int rowIndex = 1; rowIndex <= classesSheet.LastRowNum; rowIndex++) // Skipping header row
                    {
                        var row = classesSheet.GetRow(rowIndex);
                        string className = row.GetCell(0)?.ToString();
                        string classRunFlag = row.GetCell(1)?.ToString().Trim();

                        // Check if the class should be executed
                        if (classRunFlag == "Yes" && !string.IsNullOrEmpty(className))
                        {
                            // Now, read the sheet corresponding to the class name
                            var classSheet = workbook.GetSheet(className);
                            if (classSheet != null)
                            {
                                // Iterate over the rows in the sheet for this class and add the methods to the list
                                for (int methodRowIndex = 1; methodRowIndex <= classSheet.LastRowNum; methodRowIndex++)
                                {
                                    var methodRow = classSheet.GetRow(methodRowIndex);
                                    string methodName = methodRow.GetCell(0)?.ToString();
                                    string methodRunFlag = methodRow.GetCell(1)?.ToString().Trim();

                                    // Only add methods with the "Yes" run flag
                                    if (methodRunFlag == "Yes" && !string.IsNullOrEmpty(methodName))
                                    {
                                        testMethods.Add((className, methodName));
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return testMethods;
        }
    }
}