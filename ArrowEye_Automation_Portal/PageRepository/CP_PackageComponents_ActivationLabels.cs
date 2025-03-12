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

namespace ArrowEye_Automation_Portal.PageRepository
{
    public class CP_PackageComponents_ActivationLabels : TestBase
    {


        [FindsBy(How = How.XPath, Using = "//p[@class='MuiTypography-root MuiTypography-body1 jss14 css-1rtfhzq' and contains(text(),'Activation Labels')]")]
        public IWebElement ActivationLablesPageTitle;

        [FindsBy(How = How.XPath, Using = "//input[@type='search' and @placeholder='Search…']")]
        private IWebElement ActivationLables_AutoSearch_Textbox;

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-cell MuiDataGrid-cell--textLeft' and @data-field='name'])[1]")]
        private IWebElement Created_ActivationLables_Name;

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-cell MuiDataGrid-cell--textLeft' and @data-field='description'])[1]")]
        private IWebElement Created_ActivationLables_description;

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-cell MuiDataGrid-cell--textLeft' and @data-field='name'])[1]")]
        private IWebElement SharedBy_ActivationLables_Program;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='openModal']")]
        private IWebElement ActivationLable_AddNew_button;

        [FindsBy(How = How.XPath, Using = "(//div[@data-testid='historyGrid'])[1]")]
        private IWebElement StandardCarrier_ViewHistory_button;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='closeHistory']")]
        private IWebElement ViewHistory_closebtn;

        [FindsBy(How = How.XPath, Using = "(//div[@data-testid='letCarPrograms'])[1]")]
        private IWebElement SharedByPrograms;

        [FindsBy(How = How.XPath, Using = "//*[name()='svg' and @data-testid='closeButtonIcon']")]
        private IWebElement SharedByPrograms_closebtn;

        [FindsBy(How = How.XPath, Using = "(//*[name()='svg' and @data-testid='DownloadIcon'])[1]")]
        private IWebElement Download_ActivationLabel;

        [FindsBy(How = How.XPath, Using = "(//*[name()='svg' and @data-testid='HistoryIcon'])[1]")]
        private IWebElement History_ActivationLabel;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='cancelButton']")]
        private IWebElement ActivationLable_Cancel_button;


        [FindsBy(How = How.XPath, Using = "//p[text()='New Activation Label']")]
        private IWebElement NewActivationLable_headertext;

        [FindsBy(How = How.XPath, Using = "//*[name()='svg' and @data-testid='CloseIcon' and @class='MuiSvgIcon-root MuiSvgIcon-fontSizeMedium css-vubbuv']")]
        private IWebElement ActivationLable_AddNew_closebtn;

        [FindsBy(How = How.XPath, Using = "(//*[name()='svg' and @data-testid='EditIcon'])[1]")]
        private IWebElement Edit_ActivationLabels;

        [FindsBy(How = How.XPath, Using = "//p[@id='history-modal-title']")]
        private IWebElement ViewHistory;

        [FindsBy(How = How.XPath, Using = "(//p[@class='MuiTypography-root MuiTypography-body2 jss1429 css-68o8xu'])[1]")]
        private IWebElement ID;

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-columnHeaderTitle css-mh3zap'])[8]")]
        private IWebElement ViewHistory_ID;

        [FindsBy(How = How.XPath, Using = "(//p[@class='MuiTypography-root MuiTypography-body2 jss1429 css-68o8xu'])[2]")]
        private IWebElement Version;

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-columnHeaderTitle css-mh3zap'])[9]")]
        private IWebElement Viewhistory_Version;

        [FindsBy(How = How.XPath, Using = "(//p[@class='MuiTypography-root MuiTypography-body2 jss1429 css-68o8xu'])[3]")]
        private IWebElement Name;

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

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-columnHeaderTitle css-mh3zap'])[11]")]
        private IWebElement Text;

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-columnHeaderTitle css-mh3zap'])[12]")]
        private IWebElement User;

        [FindsBy(How = How.XPath, Using = "(//p[@class='MuiTypography-root MuiTypography-body2 jss1429 css-68o8xu'])[6]")]
        private IWebElement SaharedBy;

        [FindsBy(How = How.XPath, Using = "//h6[@id='modal-modal-title']")]
        private IWebElement SaharedProgramsText;

        [FindsBy(How = How.XPath, Using = "//p[@class='MuiTypography-root MuiTypography-body1 jss1051 css-9l3uo3']")]
        private IWebElement SaharedProgramsMessage;

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-columnHeaderTitle css-mh3zap'])[10]")]
        private IWebElement Date;

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-columnHeaderTitle css-mh3zap'])[8]")]
        private IWebElement SharedProgramPopup_Id;

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-columnHeaderTitle css-mh3zap'])[9]")]
        private IWebElement SharedProgramPopup_Version;

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-columnHeaderTitle css-mh3zap'])[10]")]
        private IWebElement SharedProgramPopup_Programname;

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-columnHeaderTitle css-mh3zap'])[11]")]
        private IWebElement SharedProgramPopup_Status;

        [FindsBy(How = How.XPath, Using = "(//div[@class='jss42 MuiBox-root css-0' and @data-testid='cellOne'])[1]")]
        private IWebElement ViewHistory_VersionId;

        [FindsBy(How = How.XPath, Using = "(//div[@class='jss42 MuiBox-root css-0' and @data-testid='cellOne'])[2]")]
        private IWebElement Update_ViewHistory_VersionId;

        [FindsBy(How = How.XPath, Using = "(//input[@data-testid='input-element'])[7]")]
        private IWebElement ViewHistory_Id_searchTextbox;

        [FindsBy(How = How.XPath, Using = "(//div[@class='jss426 MuiBox-root css-0'])[2]")]
        private IWebElement ViewHistory_Date;

        [FindsBy(How = How.XPath, Using = "//div[@class='MuiBox-root css-107mr15']")]
        private IWebElement ViewHistory_Textdescription;

        [FindsBy(How = How.XPath, Using = "//div[@class='jss428 MuiBox-root css-0' and  @data-testid='cellTwo']")]
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
        private IWebElement ActivationLable_Cancelbutton;

        [FindsBy(How = How.XPath, Using = "//input[@data-testid='nameInputField']")]
        private IWebElement ActivationLable_NameTextbox;

        [FindsBy(How = How.XPath, Using = "//p[@class='MuiTypography-root MuiTypography-body1 jss338 css-9l3uo3']")]
        private IWebElement Edit_ActivationLable_headertext;

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-cell MuiDataGrid-cell--textLeft'])[2]")]
        private IWebElement Addedrecord_Nameoutput;

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-cell MuiDataGrid-cell--textLeft'])[3]")]
        private IWebElement Addedrecord_Descoutput;

        [FindsBy(How = How.XPath, Using = "//label[@id='color-option-label']")]
        private IWebElement Color_options;

        [FindsBy(How = How.XPath, Using = "//label[@data-testid='blackInput']")]
        private IWebElement Balckcolor_option;

        [FindsBy(How = How.XPath, Using = "//label[@data-testid='colorInput']")]
        private IWebElement colorRadiooption;

        [FindsBy(How = How.XPath, Using = "//p[@class='MuiTypography-root MuiTypography-body1 jss105 css-9l3uo3']")]
        private IWebElement UploadFile;

        [FindsBy(How = How.XPath, Using = "//input[@data-testid='uploadFile']")]
        private IWebElement UploadFile_Textbox;

        [FindsBy(How = How.XPath, Using = "//p[@class='MuiTypography-root MuiTypography-body1 jss91 css-9l3uo3']")]
        private IWebElement UploadFile_Type;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='saveButton']")]
        private IWebElement AddNewActivationlable_savebutton;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='saveButton']")]
        private IWebElement AddNewActivationlable_Editbutton;

        [FindsBy(How = How.XPath, Using = "//div[@class='go1888806478 notistack-MuiContent notistack-MuiContent-success go167266335 go1725278324 go3162094071']//div[@id='notistack-snackbar']")]
        private IWebElement ActivationLabel_Add_Successmessage;

        [FindsBy(How = How.XPath, Using = "//div[@class='go1888806478 notistack-MuiContent notistack-MuiContent-success go167266335 go1725278324 go3162094071']//div[@id='notistack-snackbar']")]
        private IWebElement ActivationLabel_Edit_Successmessage;

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-cell MuiDataGrid-cell--textRight' and @data-field='id'])[1]")]
        private IWebElement NewActivationLabel_ID;


        [FindsBy(How = How.XPath, Using = "//*[name()='svg' and @data-testid='CloudUploadOutlinedIcon']")]
        public IWebElement FileUploadbtn;







        public void Verify_ActivationLable_AddPopup_elements(bool fields)
        {
            if (fields != false)
            {
                Thread.Sleep(7000);
                if (NewActivationLable_headertext.Displayed && ActivationLable_AddNew_closebtn.Displayed

                    && Description_Textbox.Displayed && ActivationLable_Cancelbutton.Displayed
                    && ActivationLable_NameTextbox.Displayed && Color_options.Displayed &&
                    Balckcolor_option.Displayed && colorRadiooption.Displayed
                    && UploadFile.Displayed && UploadFile_Textbox.Displayed &&
                    UploadFile_Type.Displayed && AddNewActivationlable_savebutton.Displayed)


                {

                }
            }
            else
            {
                Browser.Close();
            }
        }




        public void Verify_Editable_ActivationLabel_Parameters(bool fields)
        {
            if (fields != false)
            {
                Thread.Sleep(7000);
                if (ActivationLable_NameTextbox.Displayed
                    && Description_Textbox.Displayed && Color_options.Displayed
                    && Balckcolor_option.Displayed && colorRadiooption.Displayed
                    && ActivationLable_Cancelbutton.Displayed && AddNewActivationlable_Editbutton.Displayed)

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

        public void CreateActivationLabels(string ActivationLablesCreates)
        {
            //create new Activation Lables  record and verify the add new activation lable elements details
            var homepage = ActivationLablesPageTitle.Displayed;
            Browser.Click(ActivationLable_AddNew_button);
            Browser.Click(ActivationLable_Cancel_button);
            Thread.Sleep(2000);
            Browser.Click(ActivationLable_AddNew_button);
            Verify_ActivationLable_AddPopup_elements(true);
            var NewActivationLabelTitle = NewActivationLable_headertext.Text;
            ActivationLable_NameTextbox.SendKeys(ActivationLablesCreates);
            var inputname = ActivationLable_NameTextbox.GetDomAttribute("value");
            Description_Textbox.SendKeys(ActivationLablesCreates);
            var Inputdescription = Description_Textbox.GetDomAttribute("value");
            var Inputcoloroption = Balckcolor_option.GetDomAttribute("value");
            Browser.Click(Balckcolor_option);
            Extensions.File_uploads(UploadFile_Textbox, "ActivationLable");
            Browser.Click(AddNewActivationlable_savebutton);
            Thread.Sleep(4000);
            var Add_ActivationLabel_SuccessMessage = ActivationLabel_Add_Successmessage.Text;
            var ActivationLabel_Id = NewActivationLabel_ID.Text;
            var Outputname = Addedrecord_Nameoutput.GetDomAttribute("value");
            var Outputdesc = Addedrecord_Descoutput.GetDomAttribute("value");
            //Search with newly created record
            ActivationLables_AutoSearch_Textbox.Clear();
            ActivationLables_AutoSearch_Textbox.SendKeys(ActivationLabel_Id.ToString());
            var Output_Name = Created_ActivationLables_Name.Text;
            Browser.Click(SharedBy_ActivationLables_Program);
            Verify_SharedByPrograms_popup_Details(true);
            SharedByProgram_ExportFile("data.csv");
            Browser.Click(SharedByPrograms_closebtn);
            Browser.Click(Download_ActivationLabel);
            Browser.Click(History_ActivationLabel);
            Verify_ViewHistoryPopup_Parameters(true);
            var versionId = ViewHistory_VersionId.GetDomAttribute("value");
            ViewHistory_Id_searchTextbox.SendKeys(versionId);
            var Datetext = ViewHistory_Date.Text;
            var Datevalue = ViewHistory_Date.GetDomAttribute("value");
            var TextDescription = ViewHistory_Textdescription.Text;
            var Textvalue = ViewHistory_Textdescription.GetDomAttribute("value");
            var UserText = ViewHistory_UserName.Text;
            var UserNameValue = ViewHistory_UserName.GetDomAttribute("value");
            Browser.Click(ViewHistory_closebtn);


            //Validations
            Assert.That(homepage, Is.EqualTo("Activation Labels"));
            Assert.That(NewActivationLabelTitle, Is.EqualTo("New Activation Label"));
            Assert.That(inputname, Is.EqualTo(Outputname));
            Assert.That(Inputdescription, Is.EqualTo(Outputdesc));
            Assert.That(Inputcoloroption, Is.EqualTo("Black"));
            Assert.That(Add_ActivationLabel_SuccessMessage, Does.Contain("New Activation label " + ActivationLabel_Id + " created Successfully."));

        }

        public void EditActivationLabels(string Updateactivationlabels)
        {
            Browser.Click(ActivationLable_AddNew_button);
            ActivationLable_NameTextbox.SendKeys(Updateactivationlabels);
            var inputname = ActivationLable_NameTextbox.GetDomAttribute("value");
            Description_Textbox.SendKeys(Updateactivationlabels);
            var Inputdescription = Description_Textbox.GetDomAttribute("value");
            var Inputcoloroption = Balckcolor_option.GetDomAttribute("value");
            Browser.Click(Balckcolor_option);
            Extensions.File_uploads(UploadFile_Textbox, "ActivationLable");
            Browser.Click(AddNewActivationlable_savebutton);
            Thread.Sleep(4000);
            var Add_ActivationLabel_SuccessMessage = ActivationLabel_Add_Successmessage.Text;
            var ActivationLabel_Id = NewActivationLabel_ID.Text;
            var Outputname = Addedrecord_Nameoutput.GetDomAttribute("value");
            var Outputdesc = Addedrecord_Descoutput.GetDomAttribute("value");

            //Search with newly created record
            ActivationLables_AutoSearch_Textbox.Clear();
            ActivationLables_AutoSearch_Textbox.SendKeys(ActivationLabel_Id.ToString());
            var Output_CreatedName = Created_ActivationLables_Name.Text;

            //Edit button click
            Browser.Click(Edit_ActivationLabels);
            //Editable Parameter
            Verify_Editable_ActivationLabel_Parameters(true);
            ActivationLable_NameTextbox.SendKeys(Updateactivationlabels + "Updates_Name");
            var input_UpdateName = ActivationLable_NameTextbox.GetDomAttribute("value");
            Description_Textbox.SendKeys(Updateactivationlabels + "Updates_Description");
            var input_Updatedescription = Description_Textbox.GetDomAttribute("value");
            Browser.Click(colorRadiooption);
            Browser.Click(AddNewActivationlable_Editbutton);
            Thread.Sleep(4000);
            var Update_ActivationLabel_SuccessMessage = ActivationLabel_Edit_Successmessage.Text;
            var UpdatedActivationLabel_Id = NewActivationLabel_ID.Text;

            //Search with newly Updated record
            ActivationLables_AutoSearch_Textbox.Clear();
            ActivationLables_AutoSearch_Textbox.SendKeys(ActivationLabel_Id.ToString());
            var Output_UpdatedName = Created_ActivationLables_Name.Text;
            var Output_Updateddescrip = Created_ActivationLables_description.Text;

            Browser.Click(History_ActivationLabel);
            Verify_ViewHistoryPopup_Parameters(true);
            var versionId = Update_ViewHistory_VersionId.GetDomAttribute("value");
            ViewHistory_Id_searchTextbox.SendKeys(versionId);
            bool Datetext = ViewHistory_Date.Displayed;
            bool TextDescription = ViewHistory_Textdescription.Displayed;
            bool UserText = ViewHistory_UserName.Displayed;
            Browser.Click(ViewHistory_closebtn);


            //Validations
            Assert.That(Add_ActivationLabel_SuccessMessage, Does.Contain("New Activation label " + ActivationLabel_Id + " created Successfully."));
            Assert.That(Update_ActivationLabel_SuccessMessage, Does.Contain("Activation label " + UpdatedActivationLabel_Id + " updated Successfully."));
            Assert.That(input_UpdateName, Is.EqualTo(Output_UpdatedName));
            Assert.That(input_Updatedescription, Is.EqualTo(Output_Updateddescrip));
            
        }

        public void Validations_ActivationLabels(string NegativeScenariosText)
        {
            ////All Validations errors
            //Browser.Click(StandardCarrier_AddNew_button);
            //Browser.Click(Submit_StandardCarrier);
            //var fileuploaderror = Uploadfileerror.Text;
            //var TitleError = CarrierTitleerror.Text;
            //var partoferror = Partoferror.Text;
            //var carrierstatuserror = CarrierStatuserror.Text;
            //var colormodeerror = Colormodeerror.Text;
            //var setaffixlocationerror = Setaffixerror.Text;
            //var Assignedcategerror = Assignedcategorieserror.Text;
            //var dublicateproductmapid = 123;
            //ClientProductMapIDTextbox.SendKeys(dublicateproductmapid.ToString());
            //Browser.Click(ClientProductMapIDAddbutton);
            //var ProductIddublicateerror = dublicateproductIderror.Text;
            //var exceedlimit = 12345645656565765456 + dublicateproductmapid.ToString();
            //var ExeedlimitsofproductId = ProductmapidlimitsExceedserror.Text;
            //bool submitbuttonelabled = Submit_StandardCarrier.Enabled;
            //Browser.Click(StandardCarrier_Cancel_button);

            //Browser.Click(StandardCarrier_AddNew_button);
            //Extensions.FileUpload(FileUploadbtn, "StandardCarrierDemofile", FileProgressbar, CancelUploading, SuccessFile, RemovePDFbutton);
            //CarrierTitle_Textbox.SendKeys(NegativeScenariosText.ToString());
            //var input_carrierTitle = CarrierTitle_Textbox.GetDomAttribute("value");
            //CarrierDescription_Textbox.SendKeys(NegativeScenariosText + "1234");
            //Browser.Click(partof_consumersite);
            //Browser.Click(Carrierstatus_turnedoff);
            //Browser.Click(Colormode_Grayscale);
            //Browser.Click(Setaffixlocation_Leftmiddle);
            //Browser.Click(select_check_Categories);
            //Browser.Click(select_check_Categories_child);
            ////remove subchildassigned categories
            //Browser.Click(select_check_Categories_child);
            //string randomnumber = RandomString.GetString(Types.NUMBERS, 5);
            //ClientProductMapIDTextbox.SendKeys(randomnumber);
            //Browser.Click(ClientProductMapIDAddbutton);
            //bool addedproductIds = Addproductmapids.Displayed;
            ////adding multiple productId
            //ClientProductMapIDTextbox.SendKeys(randomnumber);
            //Browser.Click(ClientProductMapIDAddbutton);
            ////remove clientproductmapId
            //Browser.Click(RemoveProductId);
            //Browser.Click(Submit_StandardCarrier);
            //Thread.Sleep(4000);
            //var Add_StandardCarrier_SuccessMessage = StandardCarrier_recordAdd_sucessmessage.Text;
            //var NewlyaddedStandardCarrier_Id = AddedNewStandardCarrier_ID.Text;

            ////Search with newly Updated record
            //NewID_StandardCarrier_AutoSearch_textbox.Clear();
            //NewID_StandardCarrier_AutoSearch_textbox.SendKeys(NewlyaddedStandardCarrier_Id.ToString());

            ////Edit button click
            //Browser.Click(Edit_StandardCarrierdetails);
            ////turn on status
            //Browser.Click(Carrierstatus_turnedon);
            //Browser.Click(Submit_StandardCarrier);
            //Thread.Sleep(6000);

            ////Search with newly Updated record
            //NewID_StandardCarrier_AutoSearch_textbox.Clear();
            //NewID_StandardCarrier_AutoSearch_textbox.SendKeys(NewlyaddedStandardCarrier_Id.ToString());

            ////Scenario1: Viewing the Standard carrier Previews & Carrier details
            //Verify_Carrier_Preview_Carrier_Details(true);
            ////Scenario 2: Viewing the History of Standard carriers
            //Browser.Click(StandardCarrier_ViewHistory_button);
            //Verify_ViewHistoryPopup_Parameters(true);
            //Browser.Click(ViewHistory_closebtn);

            ////Scenario 3: Downloading the Standard Carrier
            //Browser.Click(StandardCarrier_Download_button);
            ////Note: download not works in app
            //DownloadFile("StandardCarrierDemofile");

            ////Scenario 4: Viewing and Exporting Shared By: Programs
            //Browser.Click(Edit_ActivationLabels);
            ////carrier status turned on
            //Browser.Click(Carrierstatus_turnedon);
            //Browser.Click(Update_standardCarreir_Sbmitbtn);
            //Thread.Sleep(6000);
            //Browser.Click(SharedByPrograms);
            //Verify_SharedByPrograms_popup_Details(true);
            //SharedByProgram_ExportFile("data.csv");
            //Browser.Click(SharedByPrograms_closebtn);
            ////Scenario 5: Viewing Client Product Map
            //Browser.Click(Productsbtn);
            //Verify_ProductMap_popup_Details(true);
            //var mapid = clinetproductId.GetDomAttribute("value");
            //clinetproductmapidtextbox.Clear();
            //clinetproductmapidtextbox.SendKeys(mapid);
            //Productspopup_closebtn.Click();


        }

    }
}

