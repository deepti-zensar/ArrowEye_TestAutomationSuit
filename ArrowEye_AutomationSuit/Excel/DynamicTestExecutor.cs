using ArrowEye_Automation_Framework.Common;
using NPOI.SS.Formula.Functions;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NUnit.Framework;
using OpenQA.Selenium.BiDi.Modules.Script;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ArrowEye_Automation_Framework.Excel
{

    [TestFixture]
    public class DynamicTestExecutor
    {
        [OneTimeSetUp]
        [Test]// This runs first before any tests in this fixture or other fixtures
        public void SetupTestExecution()
        {
            string filePath = "C:\\Users\\PJain\\Source\\Repos\\ArrowEye_TestAutomationSuit\\ArrowEye_Automation_Portal\\Config\\ExecutionRunner.xlsx";
            // Read the Excel file and filter tests
            var testMethods = ExcelTestMethodSource.GetTestMethods(filePath);

            var testTasks = new List<Task>();

            // Dynamically execute the selected tests
            foreach ((string className, string methodName) in testMethods)
            {
                testTasks.Add(Task.Run(() =>
                {
                    Type testClass = Assembly.GetExecutingAssembly().GetTypes()
                                             .FirstOrDefault(t => t.Name == className);
                    if (testClass == null)
                    {
                        Console.WriteLine($"Class '{className}' not found.");
                        return;
                    }

                    object instance = Activator.CreateInstance(testClass);
                    MethodInfo method = testClass.GetMethod(methodName, BindingFlags.Public | BindingFlags.Instance);

                    if (method != null && method.GetCustomAttribute<TestAttribute>() != null)
                    {
                        Console.WriteLine($"Executing {className}.{methodName}");
                        method.Invoke(instance, null);  // Run the test dynamically
                    }
                }));
            }

            // Wait for all tasks to finish executing
            Task.WaitAll(testTasks.ToArray());
        }
    }
}
