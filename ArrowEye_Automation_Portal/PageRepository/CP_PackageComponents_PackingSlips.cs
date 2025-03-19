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
using ArrowEye_Automation_Portal.Tests.Feature.CSP_Settings;

namespace ArrowEye_Automation_Portal.PageRepository
{
    public class CP_PackageComponents_PackingSlips : TestBase
    {


        [FindsBy(How = How.XPath, Using = "//p[@class='MuiTypography-root MuiTypography-body1 jss52 css-1rtfhzq' and contains(text(),'Packing Slip')]")]
        public IWebElement PackingSlipsPageTitle;

        [FindsBy(How = How.XPath, Using = "//input[@type='search' and @placeholder='Search…']")]
        private IWebElement PackingSlips_AutoSearch_Textbox;

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-cell MuiDataGrid-cell--textLeft' and @data-field='name'])[1]")]
        private IWebElement Updated_PS_Name;

        [FindsBy(How = How.XPath, Using = "//div[text()='No results found.']")]
        private IWebElement No_Recordfound;

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-cell MuiDataGrid-cell--textLeft' and @data-field='description'])[1]")]
        private IWebElement Updated_PS_description;

        [FindsBy(How = How.XPath, Using = "(//div[@data-field='sharedBy'])[4]")]
        private IWebElement SharedBy_Packingslips_Program;

        

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='openModal']")]
        private IWebElement Packingslips_AddNew_button;

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
        private IWebElement Download_PackingSlips;

        [FindsBy(How = How.XPath, Using = "(//*[name()='svg' and @data-testid='HistoryIcon'])[1]")]
        private IWebElement History_Packingslips;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='cancelButton']")]
        private IWebElement Packingslips_Cancel_button;


        [FindsBy(How = How.XPath, Using = "//p[text()='New Packing Slip']")]
        private IWebElement NewPackingSlips_headertext;

        [FindsBy(How = How.XPath, Using = "//*[name()='svg' and @data-testid='CloseIcon' and @class='MuiSvgIcon-root MuiSvgIcon-fontSizeMedium css-vubbuv']")]
        private IWebElement Packingslips_AddNew_closebtn;

        [FindsBy(How = How.XPath, Using = "(//*[name()='svg' and @data-testid='editButton'])[1]")]
        private IWebElement Edit_PackingSlips;

        [FindsBy(How = How.XPath, Using = "//*[name()='svg' and @data-testid='delete']")]
        private IWebElement Delete_PackingSlipss;

        [FindsBy(How = How.XPath, Using = "//p[@id='history-modal-title']")]
        private IWebElement ViewHistory;

        [FindsBy(How = How.XPath, Using = "//div[text()='ID']")]
        private IWebElement DashboardID;

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

        [FindsBy(How = How.XPath, Using = "//p[@class='MuiTypography-root MuiTypography-body1 jss41 css-9l3uo3']")]
        private IWebElement SaharedProgramsMessage;

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-columnHeaderTitle css-mh3zap'])[12]")]
        private IWebElement Date;

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-columnHeaderTitle css-mh3zap'])[7]")]
        private IWebElement SharedProgramPopup_Id;

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-columnHeaderTitle css-mh3zap'])[8]")]
        private IWebElement SharedProgramPopup_Version;

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-columnHeaderTitle css-mh3zap'])[9]")]
        private IWebElement SharedProgramPopup_Programname;

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-columnHeaderTitle css-mh3zap'])[10]")]
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

        [FindsBy(How = How.XPath, Using = "//p[text()='This action will permanently delete the Packing Slip, are you sure?']")]
        private IWebElement Delete_message;

        [FindsBy(How = How.XPath, Using = "//*[name()='svg' and @data-testid='closeButtonIcon']")]
        private IWebElement Sharedbyprogramspopup_closebtn;


        [FindsBy(How = How.XPath, Using = "(//p[@class='MuiFormHelperText-root jss183 css-j7o63n'])[2]")]
        private IWebElement Colormodeerror;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='cancelButton']")]
        private IWebElement Packingslips_Cancelbutton;

        [FindsBy(How = How.XPath, Using = "//input[@data-testid='nameInputField']")]
        private IWebElement PackingSlips_NameTextbox;

        [FindsBy(How = How.XPath, Using = "(//*[name()='svg' and @data-testid='CloseIcon'])[2]")]
        private IWebElement PackingSlips_closebtn;

        [FindsBy(How = How.XPath, Using = "//p[text()='Edit Packing Slip']")]
        private IWebElement Edit_Packingslips_headertext;

        [FindsBy(How = How.XPath, Using = "//h2[text()='Delete']")]
        private IWebElement Delete_Packingslips_headertext;

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

        [FindsBy(How = How.XPath, Using = "//span[text()='Set as Client Default']")]
        private IWebElement SetAsDefault;

        [FindsBy(How = How.XPath, Using = "//input[@id='combo-box-demo' and @value='Tri-Fold']")]
        private IWebElement FoldingDD_TriFold_Itemselect;

        [FindsBy(How = How.XPath, Using = "//input[@id='combo-box-demo' and @value='C-Fold']")]
        private IWebElement FoldingDD_CFold_Itemselect;

        [FindsBy(How = How.XPath, Using = "//input[@id='combo-box-demo' and @value='Quad-Fold']")]
        private IWebElement FoldingDD_QuadFold_Itemselect;

        [FindsBy(How = How.XPath, Using = "//input[@id='combo-box-demo' and @value='None']")]
        private IWebElement FoldingDD_None_Itemselect;

        [FindsBy(How = How.XPath, Using = "//*[name()='svg' and @data-testid='CheckBoxOutlineBlankIcon']")]
        private IWebElement DefaultCheckbox;

        [FindsBy(How = How.XPath, Using = "//p[@class='MuiTypography-root MuiTypography-body1 css-1yckaax']")]
        private IWebElement DefaultTitle;

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

        [FindsBy(How = How.XPath, Using = "//p[text()='Upload File']")]
        private IWebElement UploadFile;

        [FindsBy(How = How.XPath, Using = "//input[@data-testid='uploadFile']")]
        private IWebElement UploadFile_Textbox;

        [FindsBy(How = How.XPath, Using = "//p[@class='MuiTypography-root MuiTypography-body1 css-1vgc5eu']")]
        private IWebElement Uploadedfilename;

        [FindsBy(How = How.XPath, Using = "//p[text()='File Name']")]
        private IWebElement filename;

        [FindsBy(How = How.XPath, Using = "//p[text()='Cancel']")]
        private IWebElement Delete_popup_cancelbtn;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='okButton']")]
        private IWebElement Delete_popup_Deletelbtn;

        [FindsBy(How = How.XPath, Using = "//p[text()='PDF Only']")]
        private IWebElement UploadFile_Type;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='saveButton']")]
        private IWebElement PackingSlips_savebutton;

        [FindsBy(How = How.XPath, Using = "//input[@data-testid='papertypeInput' and @value='20#']")]
        private IWebElement PaperTypeDefaultvalue;

        [FindsBy(How = How.XPath, Using = "//div[@id='notistack-snackbar']")]
        private IWebElement MinValueGreater_error;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='saveButton']")]
        private IWebElement Inserts_Editbutton;

        [FindsBy(How = How.XPath, Using = "//div[@class='go1888806478 notistack-MuiContent notistack-MuiContent-success go167266335 go1725278324 go3162094071']//div[@id='notistack-snackbar']")]
        private IWebElement Add_PackingSlips_Successmessage;

        [FindsBy(How = How.XPath, Using = "//p[text()='Packing Slip name is required!']")]
        private IWebElement EmptyName_Packingslips_errorMessage;

        [FindsBy(How = How.XPath, Using = "//p[text()='Packing Slip description is required!']")]
        private IWebElement EmptyDesc_Packingslips_errorMessage;

        [FindsBy(How = How.XPath, Using = "//p[@data-testid='fileErrorPdf' and text()='Packing Slip PDF is required!']")]
        private IWebElement EmptyFileupload_packingslips_errorMessage;

        [FindsBy(How = How.XPath, Using = "//p[text()='Please select traveler pre-printed cell color']")]
        private IWebElement Traveller_preprintedcellcolor_error;

        [FindsBy(How = How.XPath, Using = "//p[@id='combo-box-demo-helper-text' and text()='Please select Fold Method']")]
        private IWebElement folding_error;


        [FindsBy(How = How.XPath, Using = "//div[@class='go1888806478 notistack-MuiContent notistack-MuiContent-success go167266335 go1725278324 go3162094071']//div[@id='notistack-snackbar']")]
        private IWebElement PackingSlips_Edit_Successmessage;

        [FindsBy(How = How.XPath, Using = "//div[@class='go1888806478 notistack-MuiContent notistack-MuiContent-success go167266335 go1725278324 go3162094071']//div[@id='notistack-snackbar']")]
        private IWebElement PackingSlips_Delete_Successmessage;

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-cell MuiDataGrid-cell--textRight' and @data-field='id'])[1]")]
        private IWebElement NewPackingSlips_ID;

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







        public void Verify_PackingSlips_AddPopup_elements(bool fields)
        {
            if (fields != false)
            {
                Thread.Sleep(7000);
                if (NewPackingSlips_headertext.Displayed && Packingslips_AddNew_closebtn.Displayed
                    && Description_Textbox.Displayed && Packingslips_Cancelbutton.Displayed
                    && PackingSlips_NameTextbox.Displayed
                    && UploadFile.Displayed && UploadFile_Textbox.Displayed
                    &&UploadFile_Type.Displayed && PackingSlips_savebutton.Displayed
                    && SetAsDefault.Displayed && DefaultCheckbox.Displayed && DefaultTitle.Displayed)
                {

                }
            }
            else
            {
                Browser.Close();
            }
        }




        public void Verify_Editable_PackingSlips_Parameters(bool fields)
        {
            if (fields != false)
            {
                Thread.Sleep(7000);
                if (Edit_Packingslips_headertext.Displayed&& PackingSlips_NameTextbox.Displayed
                    && Description_Textbox.Displayed && filename.Displayed && Uploadedfilename.Displayed
                    && UploadFile.Displayed && UploadFile_Textbox.Displayed && SetAsDefault.Displayed
                    && DefaultCheckbox.Displayed && PackingSlips_savebutton.Displayed
                    && Packingslips_Cancelbutton.Displayed && Packingslips_AddNew_closebtn.Displayed)

                {

                }
            }
            else
            {
                Browser.Close();
            }
        }

        public void Verify_Delete_PackingSlips_Parameters(bool fields)
        {
            if (fields != false)
            {
                Thread.Sleep(7000);
                if (Delete_Packingslips_headertext.Displayed && PackingSlips_closebtn.Displayed
                    && Delete_message.Displayed && Delete_popup_cancelbtn.Displayed 
                    && Delete_popup_Deletelbtn.Displayed)

                {

                }
            }
            else
            {
                Browser.Close();
            }
        }





        public void Verify_PackingSlips_DashBoard_Parameters(bool fields)
        {
            if (fields != false)
            {
                Thread.Sleep(7000);
                if (DashboardID.Displayed && DashboardVersion.Displayed && DashboardName.Displayed &&
                    DashboardDescription.Displayed 
                     && DashboardSharedBy.Displayed && DashboardAction.Displayed)

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

        public void Create_PackingSlips(string CreatesPackingSlips)
        {
            //create new Packing slips record and verify the add new packing slips elements details
            var homepage = PackingSlipsPageTitle.Displayed;
            Browser.Click(Packingslips_AddNew_button);
            Browser.Click(Packingslips_Cancel_button);
            Thread.Sleep(2000);
            Browser.Click(Packingslips_AddNew_button);
            Verify_PackingSlips_AddPopup_elements(true);
            var NewPackingslipsTitle = NewPackingSlips_headertext.Text;
            PackingSlips_NameTextbox.Clear();
            PackingSlips_NameTextbox.SendKeys(CreatesPackingSlips);
            var inputname = PackingSlips_NameTextbox.GetDomAttribute("value");
            Description_Textbox.Clear();
            Description_Textbox.SendKeys(CreatesPackingSlips);
            var Inputdescription = Description_Textbox.GetDomAttribute("value");
            Extensions.File_uploads(UploadFile_Textbox, "PackingSlips.pdf");
            //Browser.Click(DefaultCheckbox);
            Browser.Click(PackingSlips_savebutton);
            Thread.Sleep(4000);
            var Add_PackingSlips_SuccessMessage = Add_PackingSlips_Successmessage.Text;
            var Packingslips_Id = NewPackingSlips_ID.Text;
            var Outputname = Addedrecord_Nameoutput.GetDomAttribute("value");
            var Outputdesc = Addedrecord_Descoutput.GetDomAttribute("value");

            //Search with newly created record
            PackingSlips_AutoSearch_Textbox.Clear();
            PackingSlips_AutoSearch_Textbox.SendKeys(Packingslips_Id.ToString());
           
            //sharedbyprograms click
            Browser.Click(SharedBy_Packingslips_Program);
            Verify_SharedByPrograms_popup_Details(true);
            SharedByProgram_ExportFile("data.csv");
            Browser.Click(SharedByPrograms_closebtn);

            //Note: Download Packingslips not works in app.
            //Browser.Click(Download_PackingSlips);

            //Validations
            Assert.That(homepage, Is.EqualTo("Packing Slip"));
            Assert.That(NewPackingslipsTitle, Is.EqualTo("New Packing Slip"));
            Assert.That(inputname, Is.EqualTo(Outputname));
            Assert.That(Inputdescription, Is.EqualTo(Outputdesc));
            Assert.That(Add_PackingSlips_SuccessMessage, Does.Contain("New Packing Slip" + Packingslips_Id + " created Successfully."));
            
        }

        public void Updates_PackingSlips(string UpdatePackingSlips)
        {
            Browser.Click(Packingslips_AddNew_button);
            var NewPackingslipsTitle = NewPackingSlips_headertext.Text;
            PackingSlips_NameTextbox.Clear();
            PackingSlips_NameTextbox.SendKeys(UpdatePackingSlips);
            var inputname = PackingSlips_NameTextbox.GetDomAttribute("value");
            Description_Textbox.Clear();
            Description_Textbox.SendKeys(UpdatePackingSlips);
            var Inputdescription = Description_Textbox.GetDomAttribute("value");
            Extensions.File_uploads(UploadFile_Textbox, "PackingSlips.pdf");
            Browser.Click(PackingSlips_savebutton);
            Thread.Sleep(4000);
            var Add_PackingSlips_SuccessMessage = Add_PackingSlips_Successmessage.Text;
            var Packingslips_Id = NewPackingSlips_ID.Text;

            //Search with newly created record
            PackingSlips_AutoSearch_Textbox.Clear();
            PackingSlips_AutoSearch_Textbox.SendKeys(Packingslips_Id.ToString());


            //Edit button click
            Browser.Click(Edit_PackingSlips);
            //Editable Parameter
            Verify_Editable_PackingSlips_Parameters(true);
            PackingSlips_NameTextbox.SendKeys(UpdatePackingSlips + "Updates_Name");
            var input_UpdateName = PackingSlips_NameTextbox.GetDomAttribute("value");
            Description_Textbox.SendKeys(UpdatePackingSlips + "Updates_Description");
            var input_Updatedescription = Description_Textbox.GetDomAttribute("value");
            Browser.Click(Grayscaleprinting);
            Browser.Click(Inserts_Editbutton);
            Thread.Sleep(4000);
            var Update_PS_SuccessMessage = PackingSlips_Edit_Successmessage.Text;
            var UpdatedSlip_Id = NewPackingSlips_ID.Text;

            //Search with newly Updated record
            PackingSlips_AutoSearch_Textbox.Clear();
            PackingSlips_AutoSearch_Textbox.SendKeys(UpdatedSlip_Id.ToString());
            var Output_UpdatedName = Updated_PS_Name.Text;
            var Output_Updateddescrip = Updated_PS_description.Text;

            //Validations
            Assert.That(Add_PackingSlips_SuccessMessage, Does.Contain("New Packing Slip" + Packingslips_Id + " created Successfully."));
            Assert.That(Update_PS_SuccessMessage, Does.Contain("Packing Slip" + UpdatedSlip_Id + " updated Successfully."));
            Assert.That(input_UpdateName, Is.EqualTo(Output_UpdatedName));
            Assert.That(input_Updatedescription, Is.EqualTo(Output_Updateddescrip));
            
        }

        public void Delete_PackingSlips(string DeletePackingSlips)
        {
            Browser.Click(Packingslips_AddNew_button);
            var NewPackingslipsTitle = NewPackingSlips_headertext.Text;
            PackingSlips_NameTextbox.Clear();
            PackingSlips_NameTextbox.SendKeys(DeletePackingSlips);
            var inputname = PackingSlips_NameTextbox.GetDomAttribute("value");
            Description_Textbox.Clear();
            Description_Textbox.SendKeys(DeletePackingSlips);
            var Inputdescription = Description_Textbox.GetDomAttribute("value");
            Extensions.File_uploads(UploadFile_Textbox, "PackingSlips.pdf");
            Browser.Click(PackingSlips_savebutton);
            Thread.Sleep(4000);
            var Add_PackingSlips_SuccessMessage = Add_PackingSlips_Successmessage.Text;
            var Packingslips_Id = NewPackingSlips_ID.Text;

            //Search with newly created record
            PackingSlips_AutoSearch_Textbox.Clear();
            PackingSlips_AutoSearch_Textbox.SendKeys(Packingslips_Id.ToString());


            //Delete button click
            Browser.Click(Delete_PackingSlipss);
            //Delete Parameter
            Verify_Delete_PackingSlips_Parameters(true);
            Browser.Click(Delete_popup_Deletelbtn);
            Thread.Sleep(4000);
            var Delete_PS_SuccessMessage = PackingSlips_Delete_Successmessage.Text;

            //Search with deleted record
            PackingSlips_AutoSearch_Textbox.Clear();
            PackingSlips_AutoSearch_Textbox.SendKeys(Packingslips_Id.ToString());
            var Norecordfound = No_Recordfound.Text;
            var Output_Updateddescrip = Updated_PS_description.Text;

            //Validations
            Assert.That(Add_PackingSlips_SuccessMessage, Does.Contain("New Packing Slip" + Packingslips_Id + " created Successfully."));
            Assert.That(Delete_PS_SuccessMessage, Does.Contain("Packing Slip" + Packingslips_Id + " deleted Successfully."));
            Assert.That(Norecordfound, Is.EqualTo("No results found."));
        }

        public void Validations_PackingSlips(string NegativeScenariosText)
        {
            //Scenario 1,3: Adding an Inserts with File Upload
            Browser.Click(Packingslips_AddNew_button);
            var NewPackingslipsTitle = NewPackingSlips_headertext.Text;
            PackingSlips_NameTextbox.Clear();
            PackingSlips_NameTextbox.SendKeys(NegativeScenariosText);
            var inputname = PackingSlips_NameTextbox.GetDomAttribute("value");
            Description_Textbox.Clear();
            Description_Textbox.SendKeys(NegativeScenariosText);
            var Inputdescription = Description_Textbox.GetDomAttribute("value");
            Extensions.File_uploads(UploadFile_Textbox, "PackingSlips.pdf");
            Browser.Click(PackingSlips_savebutton);
            Thread.Sleep(4000);
            var Add_PackingSlips_SuccessMessage = Add_PackingSlips_Successmessage.Text;
            var Packingslips_Id = NewPackingSlips_ID.Text;

            //Search with newly created record
            PackingSlips_AutoSearch_Textbox.Clear();
            PackingSlips_AutoSearch_Textbox.SendKeys(Packingslips_Id.ToString());

            //Scenario 2,4,5: Updating an Inserts and Re upload diffrent file
            //Note: There is no Insert data linked with multiple programs for any PCLID in app.
            Browser.Click(Edit_PackingSlips);
            //Editable Parameter
            Verify_Editable_PackingSlips_Parameters(true);
            PackingSlips_NameTextbox.SendKeys(NegativeScenariosText + "Updates_Name");
            var input_UpdateName = PackingSlips_NameTextbox.GetDomAttribute("value");
            Description_Textbox.SendKeys(NegativeScenariosText + "Updates_Description");
            var input_Updatedescription = Description_Textbox.GetDomAttribute("value");
            Extensions.File_uploads(UploadFile_Textbox, "PackingSlips.pdf");
            Browser.Click(PackingSlips_savebutton);
            var Update_PS_SuccessMessage = PackingSlips_Edit_Successmessage.Text;
            var UpdatedSlip_Id = NewPackingSlips_ID.Text;

            //Default packing slips create/edit not works in app.

            //scenario :11 Validation Criteria for Add/Edit Packing Slip
            Browser.Click(Packingslips_AddNew_button);
            Browser.Click(PackingSlips_savebutton);
            var EmptyName = EmptyName_Packingslips_errorMessage.Text;
            var EmptyDesc = EmptyDesc_Packingslips_errorMessage.Text;
            var Emptyfileupload = EmptyFileupload_packingslips_errorMessage.Text;
            Browser.Click(Packingslips_Cancelbutton);

            Assert.That(EmptyName, Is.EqualTo("Packing Slip name is required!"));
            Assert.That(EmptyDesc, Is.EqualTo("Packing Slip description is required!"));
            Assert.That(Emptyfileupload, Is.EqualTo("Packing Slip PDF is required!"));
            
        }

        public void DashBoard_PackingSlips(string PackingSlipsDashbaord)
        {
            var homepage = PackingSlipsPageTitle.Displayed;
            Verify_PackingSlips_DashBoard_Parameters(true);

            //Search with name record
            var searchname = Addedrecord_Nameoutput.GetDomAttribute("value");
            PackingSlips_AutoSearch_Textbox.Clear();
            PackingSlips_AutoSearch_Textbox.SendKeys(searchname.ToString());

            //Search with NewPackingSlips_ID record
            var searchInsertId = NewPackingSlips_ID.GetDomAttribute("value");
            PackingSlips_AutoSearch_Textbox.Clear();
            PackingSlips_AutoSearch_Textbox.SendKeys(searchInsertId.ToString());

            //Search with description record
            var SearchDescription = Addedrecord_Descoutput.GetDomAttribute("value");
            PackingSlips_AutoSearch_Textbox.Clear();
            PackingSlips_AutoSearch_Textbox.SendKeys(SearchDescription.ToString());

            //sharedby program click
            Browser.Click(SharedBy_Packingslips_Program);
            Verify_SharedByPrograms_popup_Details(true);
            SharedByProgram_ExportFile("data.csv");
            Browser.Click(SharedByPrograms_closebtn);
            //Delete button click
            Browser.Click(Delete_PackingSlipss);
            //Delete Parameter
            Verify_Delete_PackingSlips_Parameters(true);
            Browser.Click(Delete_popup_Deletelbtn);
            Thread.Sleep(4000);
            var Delete_PS_SuccessMessage = PackingSlips_Delete_Successmessage.Text;

            //Note: 6 scenarios Download, error messages of activation label not works in app.
            //Browser.Click(Download_PackingSlips);
        }

    }
}

