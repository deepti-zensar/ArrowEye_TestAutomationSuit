using ArrowEye_Automation_Framework.Common;
using ArrowEye_Automation_Framework;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using OpenQA.Selenium.BiDi.Modules.Script;
using System.Web.UI.WebControls;
using RandomString4Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using OpenQA.Selenium.DevTools;
using System.Windows.Forms;

namespace ArrowEye_Automation_Portal.PageRepository
{
    public class CP_PackageComponents_Inserts : TestBase
    {


        [FindsBy(How = How.XPath, Using = "//p[@class='MuiTypography-root MuiTypography-body1 jss52 css-1rtfhzq' and contains(text(),'Inserts')]")]
        public IWebElement InsertsPageTitle;

        [FindsBy(How = How.XPath, Using = "//input[@type='search' and @placeholder='Search…']")]
        private IWebElement Inserts_AutoSearch_Textbox;

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-cell MuiDataGrid-cell--textLeft' and @data-field='name'])[1]")]
        private IWebElement Created_ActivationLables_Name;

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-cell MuiDataGrid-cell--textLeft' and @data-field='description'])[1]")]
        private IWebElement Created_ActivationLables_description;

        [FindsBy(How = How.XPath, Using = "(//div[@data-field='sharedBy'])[4]")]
        private IWebElement SharedBy_Inserts_Program;

        

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='openModal']")]
        private IWebElement Inserts_AddNew_button;

        [FindsBy(How = How.XPath, Using = "(//div[@data-testid='historyGrid'])[1]")]
        private IWebElement StandardCarrier_ViewHistory_button;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='closeHistory']")]
        private IWebElement ViewHistory_closebtn;

        [FindsBy(How = How.XPath, Using = "(//div[@data-testid='letCarPrograms'])[1]")]
        private IWebElement SharedByPrograms;

        [FindsBy(How = How.XPath, Using = "//*[name()='svg' and @data-testid='closeButtonIcon']")]
        private IWebElement SharedByPrograms_closebtn;

        [FindsBy(How = How.XPath, Using = "(//*[name()='svg' and @data-testid='ArrowDropDownIcon'])[5]")]
        private IWebElement SharedByPrograms_statusDD_btn;

        [FindsBy(How = How.XPath, Using = "(//*[name()='svg' and @data-testid='DownloadIcon'])[1]")]
        private IWebElement Download_Inserts;

        [FindsBy(How = How.XPath, Using = "(//*[name()='svg' and @data-testid='HistoryIcon'])[1]")]
        private IWebElement History_Inserts;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='cancelButton']")]
        private IWebElement Inserts_Cancel_button;


        [FindsBy(How = How.XPath, Using = "//p[text()='Add Insert']")]
        private IWebElement NewInserts_headertext;

        [FindsBy(How = How.XPath, Using = "//*[name()='svg' and @data-testid='CloseIcon' and @class='MuiSvgIcon-root MuiSvgIcon-fontSizeMedium css-vubbuv']")]
        private IWebElement Inserts_AddNew_closebtn;

        [FindsBy(How = How.XPath, Using = "(//*[name()='svg' and @data-testid='EditIcon'])[1]")]
        private IWebElement Edit_Inserts;

        [FindsBy(How = How.XPath, Using = "//p[@id='history-modal-title']")]
        private IWebElement ViewHistory;

        [FindsBy(How = How.XPath, Using = "//div[text()='Insert ID']")]
        private IWebElement DashboardInsertId;

        [FindsBy(How = How.XPath, Using = "(//p[@class='MuiTypography-root MuiTypography-body2 jss1429 css-68o8xu'])[1]")]
        private IWebElement ID;

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-columnHeaderTitle css-mh3zap'])[10]")]
        private IWebElement ViewHistory_ID;

        [FindsBy(How = How.XPath, Using = "//div[text()='Version']")]
        private IWebElement DashboardVersion;

        [FindsBy(How = How.XPath, Using = "//div[text()='Name']")]
        private IWebElement DashboardName;

        [FindsBy(How = How.XPath, Using = "//div[text()='Description']")]
        private IWebElement DashboardDescription;

        [FindsBy(How = How.XPath, Using = "//div[text()='Part No.']")]
        private IWebElement DashboardPartNo;

        [FindsBy(How = How.XPath, Using = "//div[text()='Min Copy(s)']")]
        private IWebElement DashboardMincopy;

        [FindsBy(How = How.XPath, Using = "//div[text()='Max Copy(s)']")]
        private IWebElement DashboardMaxcopy;



        [FindsBy(How = How.XPath, Using = "//div[text()='Shared By']")]
        private IWebElement DashboardSharedBy;

        [FindsBy(How = How.XPath, Using = "//div[text()='Actions']")]
        private IWebElement DashboardAction;

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-columnHeaderTitle css-mh3zap'])[11]")]
        private IWebElement Viewhistory_Version;


        [FindsBy(How = How.XPath, Using = "//button[@data-testid='printButton']")]
        private IWebElement Printbtn;

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-columnHeaderTitle css-mh3zap'])[1]")]
        private IWebElement SahredByPopup_Id;

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-columnHeaderTitle css-mh3zap'])[2]")]
        private IWebElement SahredByPopup_Version;

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-columnHeaderTitle css-mh3zap'])[3]")]
        private IWebElement ProgramName;

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-columnHeaderTitle css-mh3zap'])[4]")]
        private IWebElement Sharedby_Status;

        [FindsBy(How = How.XPath, Using = "(//p[@class='MuiTypography-root MuiTypography-body2 jss1429 css-68o8xu'])[4]")]
        private IWebElement LOC;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='exportButton']")]
        private IWebElement ExportBtn;

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-columnHeaderTitle css-mh3zap'])[13]")]
        private IWebElement Text;

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-columnHeaderTitle css-mh3zap'])[14]")]
        private IWebElement User;

        [FindsBy(How = How.XPath, Using = "(//p[@class='MuiTypography-root MuiTypography-body2 jss1429 css-68o8xu'])[6]")]
        private IWebElement SaharedBy;

        [FindsBy(How = How.XPath, Using = "//h6[@id='modal-modal-title']")]
        private IWebElement SaharedProgramsText;

        [FindsBy(How = How.XPath, Using = "//p[@class='MuiTypography-root MuiTypography-body1 jss81 css-9l3uo3']")]
        private IWebElement SaharedProgramsMessage;

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-columnHeaderTitle css-mh3zap'])[12]")]
        private IWebElement Date;

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-columnHeaderTitle css-mh3zap'])[10]")]
        private IWebElement SharedProgramPopup_Id;

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-columnHeaderTitle css-mh3zap'])[11]")]
        private IWebElement SharedProgramPopup_Version;

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-columnHeaderTitle css-mh3zap'])[12]")]
        private IWebElement SharedProgramPopup_Programname;

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-columnHeaderTitle css-mh3zap'])[13]")]
        private IWebElement SharedProgramPopup_Status;

        [FindsBy(How = How.XPath, Using = "//div[@class='jss70 MuiBox-root css-0' and @data-testid='cellOne']")]
        private IWebElement ViewHistory_Id;

        [FindsBy(How = How.XPath, Using = "//div[@class='jss70 MuiBox-root css-0' and @data-testid='cellOne']")]
        private IWebElement Update_ViewHistory_VersionId;

        [FindsBy(How = How.XPath, Using = "(//input[@data-testid='input-element'])[9]")]
        private IWebElement ViewHistory_sharedbyprogram_Id_searchTextbox;

        [FindsBy(How = How.XPath, Using = "(//div[@class='jss69 MuiBox-root css-0' and @data-testid='cellTwo'])[2]")]
        private IWebElement ViewHistory_Date;

        [FindsBy(How = How.XPath, Using = "//div[@class='MuiBox-root css-107mr15']")]
        private IWebElement ViewHistory_Textdescription;

        [FindsBy(How = How.XPath, Using = "//div[@class='jss71 MuiBox-root css-0' and  @data-testid='cellTwo']")]
        private IWebElement ViewHistory_UserName;

        [FindsBy(How = How.XPath, Using = "(//*[name()='svg' and @data-testid='RadioButtonUncheckedIcon'])[4]")]
        private IWebElement Colormode_color;


        [FindsBy(How = How.XPath, Using = "//input[@data-testid='descriptionInput']")]
        private IWebElement Description_Textbox;

        [FindsBy(How = How.XPath, Using = "//*[name()='svg' and @data-testid='closeButtonIcon']")]
        private IWebElement Sharedbyprogramspopup_closebtn;


        [FindsBy(How = How.XPath, Using = "(//p[@class='MuiFormHelperText-root jss183 css-j7o63n'])[2]")]
        private IWebElement Colormodeerror;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='cancelButton']")]
        private IWebElement Inserts_Cancelbutton;

        [FindsBy(How = How.XPath, Using = "//input[@data-testid='nameInputField']")]
        private IWebElement Inserts_NameTextbox;

        [FindsBy(How = How.XPath, Using = "//p[text()='Edit Inserts']")]
        private IWebElement Edit_Inserts_headertext;

        [FindsBy(How = How.XPath, Using = "//p[text()='Invalid name. Please enter the name using allowed characters (@_:)']")]
        private IWebElement Error_InvalidNamewithAlphanumeric;

        [FindsBy(How = How.XPath, Using = "//p[@class='MuiTypography-root MuiTypography-body1 jss338 css-9l3uo3']")]
        private IWebElement Edit_ActivationLable_headertext;

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-cell MuiDataGrid-cell--textLeft'])[2]")]
        private IWebElement Addedrecord_Nameoutput;

       

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-cell MuiDataGrid-cell--textLeft'])[3]")]
        private IWebElement Addedrecord_Descoutput;

        [FindsBy(How = How.XPath, Using = "(//label[@id='color-option-label'])[1]")]
        private IWebElement Color_mode;

        [FindsBy(How = How.XPath, Using = "(//label[@id='color-option-label'])[2]")]
        private IWebElement TravellerPreprintedcellcolor;

        [FindsBy(How = How.XPath, Using = "//span[text()='No color']")]
        private IWebElement Nocolor;

        [FindsBy(How = How.XPath, Using = "(//label[@data-testid='colorInput'])[2]")]
        private IWebElement printedcoloroption;

        [FindsBy(How = How.XPath, Using = "//p[text()='Insert Details']")]
        private IWebElement InsertDetailsLable;

        [FindsBy(How = How.XPath, Using = "//span[text()='Grayscale printing']")]
        private IWebElement Grayscaleprinting;

        [FindsBy(How = How.XPath, Using = "//span[text()='#ffffff']")]
        private IWebElement defaultpreprintedcolor;

        [FindsBy(How = How.XPath, Using = "//p[text()='Settings']")]
        private IWebElement Settings;

        [FindsBy(How = How.XPath, Using = "//span[text()='Full color printing']")]
        private IWebElement Fullcolorprinting;

        [FindsBy(How = How.XPath, Using = "(//input[@id='combo-box-demo'])[1]")]
        private IWebElement Foldingtextbox;

        [FindsBy(How = How.XPath, Using = "(//*[name()='svg' and @data-testid='ArrowDropDownIcon'])[5]")]
        private IWebElement FoldingDDbtn;

        [FindsBy(How = How.XPath, Using = "//input[@id='combo-box-demo' and @value='Tri-Fold']")]
        private IWebElement FoldingDD_TriFold_Itemselect;

        [FindsBy(How = How.XPath, Using = "//input[@id='combo-box-demo' and @value='C-Fold']")]
        private IWebElement FoldingDD_CFold_Itemselect;

        [FindsBy(How = How.XPath, Using = "//input[@id='combo-box-demo' and @value='Quad-Fold']")]
        private IWebElement FoldingDD_QuadFold_Itemselect;

        [FindsBy(How = How.XPath, Using = "//input[@id='combo-box-demo' and @value='None']")]
        private IWebElement FoldingDD_None_Itemselect;

        [FindsBy(How = How.XPath, Using = "(//*[name()='svg' and @data-testid='ArrowDropDownIcon'])[6]")]
        private IWebElement MinCopysDDbtn;

        [FindsBy(How = How.XPath, Using = "(//*[name()='svg' and @data-testid='ArrowDropDownIcon'])[7]")]
        private IWebElement MaxCopysDDbtn;

        [FindsBy(How = How.XPath, Using = "(//input[@id='combo-box-demo'])[2]")]
        private IWebElement MinCopysTextbox;

        [FindsBy(How = How.XPath, Using = "(//input[@id='combo-box-demo' and @value='1'])[1]")]
        private IWebElement MinCopysdefaultvalue;

        [FindsBy(How = How.XPath, Using = "(//input[@id='combo-box-demo' and @value='1'])[2]")]
        private IWebElement MaxCopysdefaultvalue;

        [FindsBy(How = How.XPath, Using = "//input[@id='combo-box-demo' and @value='2']")]
        private IWebElement MinCopysDD_Itemselect;

        [FindsBy(How = How.XPath, Using = "//input[@id='combo-box-demo' and @value='6']")]
        private IWebElement MinCopysDD_greaterItemselect;

        [FindsBy(How = How.XPath, Using = "(//input[@id='combo-box-demo'])[3]")]
        private IWebElement MaxCopysTextbox;

        [FindsBy(How = How.XPath, Using = "//input[@id='combo-box-demo' and @value='4']")]
        private IWebElement MaxCopysDD_Itemselect;

        [FindsBy(How = How.XPath, Using = "//input[@data-testid='papertypeInput']")]
        private IWebElement PaperTypeTextbox;

        [FindsBy(How = How.XPath, Using = "//p[@class='MuiTypography-root MuiTypography-body1 jss797 css-9l3uo3']")]
        private IWebElement UploadFile;

        [FindsBy(How = How.XPath, Using = "//input[@data-testid='uploadFile']")]
        private IWebElement UploadFile_Textbox;

        [FindsBy(How = How.XPath, Using = "//p[@class='MuiTypography-root MuiTypography-body1 jss818 css-9l3uo3']")]
        private IWebElement UploadFile_Notes;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='saveButton']")]
        private IWebElement Inserts_savebutton;

        [FindsBy(How = How.XPath, Using = "//input[@data-testid='papertypeInput' and @value='20#']")]
        private IWebElement PaperTypeDefaultvalue;

        [FindsBy(How = How.XPath, Using = "//div[@id='notistack-snackbar']")]
        private IWebElement MinValueGreater_error;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='saveButton']")]
        private IWebElement Inserts_Editbutton;

        [FindsBy(How = How.XPath, Using = "//div[@class='go1888806478 notistack-MuiContent notistack-MuiContent-success go167266335 go1725278324 go3162094071']//div[@id='notistack-snackbar']")]
        private IWebElement Add_Inserts_Successmessage;

        [FindsBy(How = How.XPath, Using = "//p[text()='//p[text()='Name is required']']")]
        private IWebElement EmptyName_Inserts_errorMessage;

        [FindsBy(How = How.XPath, Using = "//p[text()='Description is required']")]
        private IWebElement EmptyDesc_Inserts_errorMessage;

        [FindsBy(How = How.XPath, Using = "//p[@data-testid='fileErrorPdf' and text()='PDF file is required']")]
        private IWebElement EmptyFileupload_Inserts_errorMessage;

        [FindsBy(How = How.XPath, Using = "//p[text()='Please select traveler pre-printed cell color']")]
        private IWebElement Traveller_preprintedcellcolor_error;

        [FindsBy(How = How.XPath, Using = "//p[@id='combo-box-demo-helper-text' and text()='Please select Fold Method']")]
        private IWebElement folding_error;


        [FindsBy(How = How.XPath, Using = "//div[@class='go1888806478 notistack-MuiContent notistack-MuiContent-success go167266335 go1725278324 go3162094071']//div[@id='notistack-snackbar']")]
        private IWebElement Inserts_Edit_Successmessage;

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-cell MuiDataGrid-cell--textRight' and @data-field='id'])[1]")]
        private IWebElement NewInserts_ID;

        [FindsBy(How = How.XPath, Using = "//div[@class='MuiDataGrid-cell MuiDataGrid-cell--textLeft' and @data-field='partNumber']")]
        private IWebElement PartNo_ID;

        [FindsBy(How = How.XPath, Using = "//div[@class='MuiInputBase-root MuiInputBase-colorPrimary MuiTablePagination-input css-rmmij8']")]
        private IWebElement Pagenationbtn;

        [FindsBy(How = How.XPath, Using = "//option[@class='MuiTablePagination-menuItem jss627' and @value='10']")]
        private IWebElement TenRowsperPage;

        [FindsBy(How = How.XPath, Using = "//option[@class='MuiTablePagination-menuItem jss627' and @value='25']")]
        private IWebElement TwentyFiveRowsperpage;

        [FindsBy(How = How.XPath, Using = "//option[@class='MuiTablePagination-menuItem jss627' and @value='55']")]
        private IWebElement FiftyRowsperpage;

        [FindsBy(How = How.XPath, Using = "//p[@class='MuiTablePagination-selectLabel css-1chpzqh']")]
        private IWebElement RowsPerPageLabel;

        [FindsBy(How = How.XPath, Using = "//*[name()='svg' and @data-testid='FirstPageIcon']")]
        private IWebElement FisrPageIcon;

        [FindsBy(How = How.XPath, Using = "//*[name()='svg' and @data-testid='ChevronLeftIcon']")]
        private IWebElement PreviousPageIcon;

        [FindsBy(How = How.XPath, Using = "//*[name()='svg' and @data-testid='ChevronRightIcon']")]
        private IWebElement NextPageIcon;

        [FindsBy(How = How.XPath, Using = "//*[name()='svg' and @data-testid='LastPageIcon']")]
        private IWebElement LastPageIcon;

        [FindsBy(How = How.XPath, Using = "//p[@class='MuiTablePagination-displayedRows css-1chpzqh']")]
        private IWebElement RecordsCount;

        [FindsBy(How = How.XPath, Using = "(//p[@class='MuiTypography-root MuiTypography-body2 jss629 css-68o8xu'])[1]")]
        private IWebElement PageLabel;

        [FindsBy(How = How.XPath, Using = "//input[@class='MuiInputBase-input MuiOutlinedInput-input jss632 css-1x5jdmq' and @id='ID']")]
        private IWebElement PageNumberTextbox;

        [FindsBy(How = How.XPath, Using = "(//p[@class='MuiTypography-root MuiTypography-body2 jss629 css-68o8xu'])[2]")]
        private IWebElement Pageoutof;







        [FindsBy(How = How.XPath, Using = "//*[name()='svg' and @data-testid='CloudUploadOutlinedIcon']")]
        public IWebElement FileUploadbtn;







        public void Verify_Inserts_AddPopup_elements(bool fields)
        {
            if (fields != false)
            {
                Thread.Sleep(7000);
                if (NewInserts_headertext.Displayed && Inserts_AddNew_closebtn.Displayed
                    && Description_Textbox.Displayed && Inserts_Cancelbutton.Displayed
                    && Inserts_NameTextbox.Displayed && Color_mode.Displayed 
                    && InsertDetailsLable.Displayed && TravellerPreprintedcellcolor.Displayed
                    && Nocolor.Displayed&& printedcoloroption.Displayed 
                    && Grayscaleprinting.Displayed && Fullcolorprinting.Displayed
                    && Settings.Displayed && Foldingtextbox.Displayed
                    && MaxCopysTextbox.Displayed && MinCopysTextbox.Displayed
                    && PaperTypeTextbox.Displayed && MinCopysTextbox.Displayed
                    && UploadFile.Displayed && UploadFile_Textbox.Displayed
                    &&UploadFile_Notes.Displayed && Inserts_savebutton.Displayed
                    &&FoldingDDbtn.Displayed && MinCopysDDbtn.Displayed &&MaxCopysDDbtn.Displayed)
                {

                }
            }
            else
            {
                Browser.Close();
            }
        }




        public void Verify_Editable_Inserts_Parameters(bool fields)
        {
            if (fields != false)
            {
                Thread.Sleep(7000);
                if (Edit_Inserts_headertext.Displayed&&Inserts_NameTextbox.Displayed
                    && Description_Textbox.Displayed && Grayscaleprinting.Displayed 
                    && Fullcolorprinting.Displayed
                    && TravellerPreprintedcellcolor.Displayed
                    && Nocolor.Displayed && printedcoloroption.Displayed
                    && Foldingtextbox.Displayed
                    && MaxCopysTextbox.Displayed && MinCopysTextbox.Displayed
                    && PaperTypeTextbox.Displayed && MinCopysTextbox.Displayed
                    && UploadFile.Displayed && UploadFile_Textbox.Displayed
                    && FoldingDDbtn.Displayed && MinCopysDDbtn.Displayed 
                    && MaxCopysDDbtn.Displayed && Inserts_savebutton.Displayed
                    && Inserts_Cancelbutton.Displayed && Inserts_AddNew_closebtn.Displayed)

                {

                }
            }
            else
            {
                Browser.Close();
            }
        }




        public void Verify_ViewHistoryPopup_Parameters(bool fields)
        {
            if (fields != false)
            {
                Thread.Sleep(7000);
                if (ViewHistory.Displayed && ViewHistory_ID.Displayed && Viewhistory_Version.Displayed &&
                    Date.Displayed && Text.Displayed && User.Displayed && ViewHistory_closebtn.Displayed)

                {

                }
            }
            else
            {
                Browser.Close();
            }
        }

        public void Verify_Inserts_DashBoard_Parameters(bool fields)
        {
            if (fields != false)
            {
                Thread.Sleep(7000);
                if (DashboardInsertId.Displayed && DashboardVersion.Displayed && DashboardName.Displayed &&
                    DashboardDescription.Displayed && DashboardPartNo.Displayed && DashboardMincopy .Displayed 
                    && DashboardMaxcopy.Displayed && DashboardSharedBy.Displayed && DashboardAction.Displayed)

                {

                }
            }
            else
            {
                Browser.Close();
            }
        }

        public void Verify_SharedByPrograms_popup_Details(bool fields)
        {
            if (fields != false)
            {
                Thread.Sleep(7000);
                if (SaharedProgramsText.Displayed && SaharedProgramsMessage.Displayed
                    && ExportBtn.Displayed && Printbtn.Displayed
                    && SharedProgramPopup_Version.Displayed &&
                    SharedProgramPopup_Id.Displayed
                    && SharedProgramPopup_Programname.Displayed
                    && SharedProgramPopup_Status.Displayed)

                {

                }
            }
            else
            {
                Browser.Close();
            }
        }





        //download sharedbyprogram popup file
        public void SharedByProgram_ExportFile(string fileName)
        {
            Browser.Click(ExportBtn);
            Thread.Sleep(4000);
            bool fileStatus = Extensions.Verify_Downloaded_CSV_PDF_files_Clear(fileName);
            Assert.That(fileStatus, Is.True);
        }

        public void Create_Inserts(string InsertsCreates)
        {
            //create new Inserts  record and verify the add new Inserts lable elements details
            var homepage = InsertsPageTitle.Displayed;
            Browser.Click(Inserts_AddNew_button);
            Browser.Click(Inserts_Cancel_button);
            Thread.Sleep(2000);
            Browser.Click(Inserts_AddNew_button);
            Verify_Inserts_AddPopup_elements(true);
            var NewInsertTitle = NewInserts_headertext.Text;
            Inserts_NameTextbox.Clear();
            Inserts_NameTextbox.SendKeys(InsertsCreates);
            var inputname = Inserts_NameTextbox.GetDomAttribute("value");
            Description_Textbox.Clear();
            Description_Textbox.SendKeys(InsertsCreates);
            var Inputdescription = Description_Textbox.GetDomAttribute("value");
            Extensions.File_uploads(UploadFile_Textbox, "Inserts.pdf");
            Browser.Click(Fullcolorprinting);
            Browser.Click(Nocolor);
            Browser.Click(FoldingDDbtn);
            Browser.Click(FoldingDD_CFold_Itemselect);

            //var Input_CFold_option = FoldingDD_CFold_Itemselect.GetDomAttribute("value");
            //Foldingtextbox.SendKeys(Input_CFold_option);
            string randomstr = RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 2);
            //string randomint = RandomString.GetString(Types.NUMBERS, 2);
            PaperTypeTextbox.SendKeys(randomstr +"#");
            Browser.Click(MinCopysDDbtn);
            Browser.Click(MinCopysDD_Itemselect);
            Browser.Click(MaxCopysDDbtn);
            Browser.Click(MaxCopysDD_Itemselect);
            //MinCopysTextbox.SendKeys(randomint);
            //MaxCopysTextbox.SendKeys(randomint);
            Browser.Click(Inserts_savebutton);
            Thread.Sleep(4000);
            var Add_Inserts_SuccessMessage = Add_Inserts_Successmessage.Text;
            var Inserts_Id = NewInserts_ID.Text;
            var Outputname = Addedrecord_Nameoutput.GetDomAttribute("value");
            var Outputdesc = Addedrecord_Descoutput.GetDomAttribute("value");

            //Search with newly created record
            Inserts_AutoSearch_Textbox.Clear();
            Inserts_AutoSearch_Textbox.SendKeys(Inserts_Id.ToString());
           
            //sharedbyprograms click
            Browser.Click(SharedBy_Inserts_Program);
            Verify_SharedByPrograms_popup_Details(true);
            SharedByProgram_ExportFile("data.csv");
            Browser.Click(SharedByPrograms_closebtn);

            //Note: Download Inserts not works in app.
            //Browser.Click(Download_Inserts);

            //view history click
            Browser.Click(History_Inserts);
            Verify_ViewHistoryPopup_Parameters(true);
            var versionId = ViewHistory_Id.GetDomAttribute("value");
            ViewHistory_sharedbyprogram_Id_searchTextbox.SendKeys(versionId);
            var Datetext = ViewHistory_Date.Text;
            var Datevalue = ViewHistory_Date.GetDomAttribute("value");
            var TextDescription = ViewHistory_Textdescription.Text;
            var Textvalue = ViewHistory_Textdescription.GetDomAttribute("value");
            var UserText = ViewHistory_UserName.Text;
            var UserNameValue = ViewHistory_UserName.GetDomAttribute("value");
            Browser.Click(ViewHistory_closebtn);


            //Validations
            Assert.That(homepage, Is.EqualTo("Inserts"));
            Assert.That(NewInsertTitle, Is.EqualTo("Add Insert"));
            Assert.That(inputname, Is.EqualTo(Outputname));
            Assert.That(Inputdescription, Is.EqualTo(Outputdesc));
            Assert.That(Add_Inserts_SuccessMessage, Does.Contain("New Insert" + Inserts_Id + " created Successfully."));
            
        }

        public void Updates_Inserts(string UpdateInserts)
        {
             Browser.Click(Inserts_AddNew_button);
            Inserts_NameTextbox.Clear();
            Inserts_NameTextbox.SendKeys(UpdateInserts);
            Description_Textbox.Clear();
            Description_Textbox.SendKeys(UpdateInserts);
            Extensions.File_uploads(UploadFile_Textbox, "Inserts.pdf");
            Browser.Click(Fullcolorprinting);
            Browser.Click(Nocolor);
            Browser.Click(FoldingDDbtn);
            Browser.Click(FoldingDD_CFold_Itemselect);
            string randomstr = RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 2);
            PaperTypeTextbox.SendKeys(randomstr +"#");
            Browser.Click(MinCopysDDbtn);
            Browser.Click(MinCopysDD_Itemselect);
            Browser.Click(MaxCopysDDbtn);
            Browser.Click(MaxCopysDD_Itemselect);
            Browser.Click(Inserts_savebutton);
            Thread.Sleep(4000);
            var Add_Inserts_SuccessMessage = Add_Inserts_Successmessage.Text;
            var Inserts_Id = NewInserts_ID.Text;
           
            //Search with newly created record
            Inserts_AutoSearch_Textbox.Clear();
            Inserts_AutoSearch_Textbox.SendKeys(Inserts_Id.ToString());

            //Edit button click
            Browser.Click(Edit_Inserts);
            //Editable Parameter
            Verify_Editable_Inserts_Parameters(true);
            Inserts_NameTextbox.SendKeys(UpdateInserts + "Updates_Name");
            var input_UpdateName = Inserts_NameTextbox.GetDomAttribute("value");
            Description_Textbox.SendKeys(UpdateInserts + "Updates_Description");
            var input_Updatedescription = Description_Textbox.GetDomAttribute("value");
            Browser.Click(Grayscaleprinting);
            Browser.Click(Inserts_Editbutton);
            Thread.Sleep(4000);
            var Update_Inserts_SuccessMessage = Inserts_Edit_Successmessage.Text;
            var UpdatedInserts_Id = NewInserts_ID.Text;

            //Search with newly Updated record
            Inserts_AutoSearch_Textbox.Clear();
            Inserts_AutoSearch_Textbox.SendKeys(Inserts_Id.ToString());
            var Output_UpdatedName = Created_ActivationLables_Name.Text;
            var Output_Updateddescrip = Created_ActivationLables_description.Text;

            //history
            Browser.Click(History_Inserts);
            Verify_ViewHistoryPopup_Parameters(true);
            var versionId = Update_ViewHistory_VersionId.GetDomAttribute("value");
            ViewHistory_sharedbyprogram_Id_searchTextbox.SendKeys(versionId);
            bool Datetext = ViewHistory_Date.Displayed;
            bool TextDescription = ViewHistory_Textdescription.Displayed;
            bool UserText = ViewHistory_UserName.Displayed;
            Browser.Click(ViewHistory_closebtn);


            //Validations
            Assert.That(Add_Inserts_SuccessMessage, Does.Contain("New Insert" + Inserts_Id + " created Successfully."));
            Assert.That(Update_Inserts_SuccessMessage, Does.Contain("Insert" + UpdatedInserts_Id + " updated Successfully."));
            Assert.That(input_UpdateName, Is.EqualTo(Output_UpdatedName));
            Assert.That(input_Updatedescription, Is.EqualTo(Output_Updateddescrip));
            
        }

        public void Validations_Inserts(string NegativeScenariosText)
        {
            //Scenario 1,3: Adding an Inserts with File Upload
            var homepage = InsertsPageTitle.Displayed;
            Browser.Click(Inserts_AddNew_button);
            Inserts_NameTextbox.Clear();
            Inserts_NameTextbox.SendKeys(NegativeScenariosText);
            Description_Textbox.Clear();
            Description_Textbox.SendKeys(NegativeScenariosText);
            Extensions.File_uploads(UploadFile_Textbox, "Inserts.pdf");
            Browser.Click(Fullcolorprinting);
            Browser.Click(Nocolor);
            Browser.Click(FoldingDDbtn);
            Browser.Click(FoldingDD_CFold_Itemselect);
            string randomstr = RandomString.GetString(Types.ALPHANUMERIC_LOWERCASE, 2);
            PaperTypeTextbox.SendKeys(randomstr + "#");
            Browser.Click(MinCopysDDbtn);
            Browser.Click(MinCopysDD_Itemselect);
            Browser.Click(MaxCopysDDbtn);
            Browser.Click(MaxCopysDD_Itemselect);
            Browser.Click(Inserts_savebutton);
            Thread.Sleep(4000);
            var Add_Inserts_SuccessMessage = Add_Inserts_Successmessage.Text;
            var Inserts_Id = NewInserts_ID.Text;
            var Add_partno = PartNo_ID.Text;

            //Scenario 2,4,5: Updating an Inserts and Re upload diffrent file
            Browser.Click(Edit_Inserts);
            //Note: There is no Insert data linked with multiple programs for any PCLID in app.
            Inserts_NameTextbox.SendKeys(NegativeScenariosText + "NegativescenariosUpdates");
            var input_UpdateName = Inserts_NameTextbox.GetDomAttribute("value");
            Description_Textbox.SendKeys(NegativeScenariosText + "NegativescenariosDescription");
            var input_Updatedescription = Description_Textbox.GetDomAttribute("value");
            Extensions.File_uploads(UploadFile_Textbox, "InsertsUpdate.pdf");
            Browser.Click(Grayscaleprinting);
            Browser.Click(Inserts_Editbutton);
            Thread.Sleep(4000);
            var Update_Inserts_SuccessMessage = Inserts_Edit_Successmessage.Text;
            var UpdatedInserts_Id = NewInserts_ID.Text;
            var Edit_partno = PartNo_ID.Text;


            //scenario :11 Validation Criteria for Add Insert
            Browser.Click(Inserts_AddNew_button);
            Inserts_NameTextbox.Clear();
            Description_Textbox.Clear();
            Foldingtextbox.Clear();
            Browser.Click(Inserts_savebutton);
            var EmptyName = EmptyName_Inserts_errorMessage.Text;
            var EmptyDesc = EmptyDesc_Inserts_errorMessage.Text;
            var Emptyfileupload = EmptyFileupload_Inserts_errorMessage.Text;
            var Emptycellcolor = Traveller_preprintedcellcolor_error.Text;
            var emptyfolding = folding_error.Text;
            Browser.Click(MinCopysDDbtn);
            Browser.Click(MinCopysDDbtn);
            Browser.Click(MinCopysDD_greaterItemselect);
            Browser.Click(MaxCopysDDbtn);
            Browser.Click(MaxCopysDD_Itemselect);
            Browser.Click(Inserts_savebutton);
            var minvalueerror = MinValueGreater_error.Text;
            Browser.Click(Inserts_Cancelbutton);

            //Scenario 6,7,8,9: Default value for Paper type,Min Copy(s) and Max Copy(s),colormode,raveler Pre-Printed Cell Color
            Browser.Click(Inserts_AddNew_button);
            var papertyep_defaultvalue = PaperTypeDefaultvalue.GetDomAttribute("value");
            var mincopy_defaultvalue = MinCopysdefaultvalue.GetDomAttribute("value");
            var maxcopy_defaultvalue = MaxCopysdefaultvalue.GetDomAttribute("value");
            var colormode_defaultvalue = Grayscaleprinting.GetDomAttribute("value");
            var preprintedcolor_defaultvalue = defaultpreprintedcolor.GetDomAttribute("value");
            //Note : No name and description limit validations and accepts inputs types in app.

            Assert.That(EmptyName, Is.EqualTo("Name is required"));
            Assert.That(EmptyDesc, Is.EqualTo("Description is required"));
            Assert.That(Emptyfileupload, Is.EqualTo("PDF file is required"));
            Assert.That(Emptycellcolor, Is.EqualTo("Please select traveler pre-printed cell color"));
            Assert.That(emptyfolding, Is.EqualTo("Please select Fold Method"));
            Assert.That(papertyep_defaultvalue, Is.EqualTo("20#"));
            Assert.That(mincopy_defaultvalue, Is.EqualTo("1"));
            Assert.That(maxcopy_defaultvalue, Is.EqualTo("1"));
            Assert.That(colormode_defaultvalue, Is.EqualTo("Grayscale printing"));
            if(Add_partno!= Edit_partno)
            {
                Assert.Pass("Reupload diffrent file successfully generated new PartNo");
            }
        }

        public void DashBoard_Inserts(string InsertsDashbaord)
        {
            var homepage = InsertsPageTitle.Displayed;
            Verify_Inserts_DashBoard_Parameters(true);

            //Search with name record
            var searchname = Addedrecord_Nameoutput.GetDomAttribute("value");
            Inserts_AutoSearch_Textbox.Clear();
            Inserts_AutoSearch_Textbox.SendKeys(searchname.ToString());

            //Search with Insertid record
            var searchInsertId = NewInserts_ID.GetDomAttribute("value");
            Inserts_AutoSearch_Textbox.Clear();
            Inserts_AutoSearch_Textbox.SendKeys(searchInsertId.ToString());

            //Search with description record
            var SearchDescription = Addedrecord_Descoutput.GetDomAttribute("value");
            Inserts_AutoSearch_Textbox.Clear();
            Inserts_AutoSearch_Textbox.SendKeys(SearchDescription.ToString());

            //sharedby program click
            Browser.Click(SharedBy_Inserts_Program);
            Verify_SharedByPrograms_popup_Details(true);
            SharedByProgram_ExportFile("data.csv");
            Browser.Click(SharedByPrograms_closebtn);
           

            //view history
            Browser.Click(History_Inserts);
            Verify_ViewHistoryPopup_Parameters(true);
            var versionId = Update_ViewHistory_VersionId.GetDomAttribute("value");
            ViewHistory_sharedbyprogram_Id_searchTextbox.SendKeys(versionId);
            bool Datetext = ViewHistory_Date.Displayed;
            bool TextDescription = ViewHistory_Textdescription.Displayed;
            bool UserText = ViewHistory_UserName.Displayed;
            Browser.Click(ViewHistory_closebtn);
            //Note: No export and print button avilable on history popup in application.

            //Note: 6 scenarios Download, error messages of activation label not works in app.
            //Browser.Click(Download_Inserts);

           
            
            
        }

    }
}

