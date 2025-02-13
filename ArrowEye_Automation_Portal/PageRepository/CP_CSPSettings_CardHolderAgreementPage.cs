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
using System.Net.NetworkInformation;
using ArrowEye_Automation_Portal.Tests.Feature.CSP_Settings;
using System.IO;

namespace ArrowEye_Automation_Portal.PageRepository
{
    public class CP_CSPSettings_CardHolderAgreementPage : TestBase
    {
        IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='nestedMenuItem']//p[contains(text(),'CSP Settings')]")]
        public IWebElement CSVSettings_menu;

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='subMenuItems']//p[contains(text(),'BOC Dynamic Info')]")]
        public IWebElement BOC_Dynamic_Info_submenu;

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='subMenuItems']//p[contains(text(),'Card Holder Agreement')]")]
        public IWebElement Card_Holder_Agreement_submenu;

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='subMenuItems']//p[contains(text(),'Carrier Dynamic Info')]")]
        public IWebElement Carrier_Dynamic_Info_submenu;

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='subMenuItems']//p[contains(text(),'EMV Profile')]")]
        public IWebElement EMV_Profile_submenu;

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='subMenuItems']//p[contains(text(),'FOC Dynamic Info')]")]
        public IWebElement FOC_Dynamic_Info_submenu;

        [FindsBy(How = How.XPath, Using = "//p[@data-testid='secondNested' and contains(text(),'BOC Dynamic Info')]")]
        private IWebElement BOCDynamicInfo_menudropdowntext;

        [FindsBy(How = How.XPath, Using = "//div[@class='jss13 MuiBox-root css-0']//p[contains(text(),'Carrier Dynamic Info')]")]
        private IWebElement CarrierDynamicInfoPage_HeaderText;

        [FindsBy(How = How.XPath, Using = "//div[@class='MuiDataGrid-columnHeaderTitleContainerContent']//div[contains(text(),'BOC Info ID')]")]
        private IWebElement BOCInfoID_GridColoumn;

        [FindsBy(How = How.XPath, Using = "//div[@class='MuiDataGrid-columnHeaderTitleContainerContent']//div[contains(text(),'BOC Dynamic Text')]")]
        private IWebElement BOCDynamicText_GridColoumn;

        [FindsBy(How = How.XPath, Using = "//div[@class='MuiDataGrid-columnHeaderTitleContainerContent']//div[contains(text(),'Last Updated')]")]
        private IWebElement LastUpdated_GridColoumn;

        [FindsBy(How = How.XPath, Using = "//div[@class='MuiDataGrid-columnHeaderTitleContainerContent']//div[contains(text(),'Actions')]")]
        private IWebElement Actions_GridColoumn;

        [FindsBy(How = How.XPath, Using = "//button[@aria-haspopup='menu' and contains(text(),'Columns')]")]
        private IWebElement BOCDynamicInfo_Columns_button;

        [FindsBy(How = How.XPath, Using = "//div[@class='MuiDataGrid-columnsManagementHeader css-1c0mwkm']//input[@type='text']")]
        private IWebElement BOCDynamicInfo_Columnspopup_Searchtextbox;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Row reordering')]")]
        private IWebElement BOCDynamicInfo_Columnspopup_Rowreordering_btn;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'BOC Info ID')]")]
        private IWebElement BOCDynamicInfo_Columnspopup_BOCInfoID_btn;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'BOC Dynamic Text')]")]
        private IWebElement BOCDynamicInfo_Columnspopup_BOCDynamicText_btn;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Last Updated')]")]
        private IWebElement BOCDynamicInfo_Columnspopup_LastUpdated_btn;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Actions')]")]
        private IWebElement BOCDynamicInfo_Columnspopup_Actions_btn;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Show/Hide All')]")]
        private IWebElement BOCDynamicInfo_Columnspopup_Show_HideAll_btn;

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Reset')]")]
        private IWebElement BOCDynamicInfo_Columnspopup_Resetbtn;

        [FindsBy(How = How.XPath, Using = "//button[@id=':rge:']")]
        private IWebElement BOCDynamicInfo_Filters_button;

        [FindsBy(How = How.XPath, Using = "//button[@id=':rgh:']")]
        private IWebElement BOCDynamicInfo_Export_button;

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Print')]")]
        private IWebElement BOCDynamicInfo_Print_button;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Search…']")]
        private IWebElement CarrierDynamicInfo_AutoSearch_textbox;

        [FindsBy(How = How.XPath, Using = "//button[@class='MuiButtonBase-root MuiIconButton-root MuiIconButton-sizeSmall css-irzi55']")]
        private IWebElement BOCDynamicInfo_AutoSearch_textboxclear;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='openModal']//p[contains(text(),'Add New')]")]
        private IWebElement CarrierDynamicInfo_AddNew_button;

        [FindsBy(How = How.XPath, Using = "//div[@class='MuiDataGrid-columnHeaderTitle css-mh3zap' and contains(text(),'Carrier Info ID')]")]
        private IWebElement Carrier_homepage_IDGridcol;

        [FindsBy(How = How.XPath, Using = "//div[@class='MuiDataGrid-columnHeaderTitle css-mh3zap' and contains(text(),'Carrier Dynamic Text')]")]
        private IWebElement Carrier_homepage_DynamicTextcol;

        [FindsBy(How = How.XPath, Using = "//div[@class='MuiDataGrid-columnHeaderTitle css-mh3zap' and contains(text(),'Last Updated')]")]
        private IWebElement FOC_homepage_LastUpdatedcol;

        [FindsBy(How = How.XPath, Using = "//div[@class='MuiDataGrid-columnHeaderTitle css-mh3zap' and contains(text(),'Actions')]")]
        private IWebElement CarrierDynamic_homepage_Actioncol;

        [FindsBy(How = How.XPath, Using = "(//button[@data-testid='deleteCell'])[position()=1]")]

        private IWebElement CarrierDynamicInfo_Detete_Icon_button;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='cancelButton']")]

        private IWebElement CarrierDynamicInfo_Detete_popup_Cancelbutton;

        [FindsBy(How = How.XPath, Using = "//h2[contains(text(),'Delete')]")]
        private IWebElement CarrierDynamicInfo_Detete_popup_HeaderText;

        [FindsBy(How = How.XPath, Using = "//div[@class='MuiStack-root css-j7qwjs']")]
        private IWebElement CarrierDynamicInfo_Detete_popup_warningmessage;

        [FindsBy(How = How.XPath, Using = "(//button[@class='MuiButtonBase-root MuiIconButton-root MuiIconButton-sizeSmall textPrimary css-1pydezi'])[2]")]
        private IWebElement CarrierDynamicInfo_Edit_Icon_button;

        

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='closeButton']")]
        private IWebElement NewCarrierDynamicInfoPopup_Closebtn;

        [FindsBy(How = How.XPath, Using = "//input[@data-testid='nameInputField']")]
        private IWebElement NewCarrierDynamicInfoPopup_Textbox;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='cancelCSP']")]
        private IWebElement NewCarrierDynamicInfoPopup_Cancelbtn;

        [FindsBy(How = How.XPath, Using = "//p[@class='MuiTypography-root MuiTypography-body1 css-qr1enj']")]
        private IWebElement UpdateCarrierDynamicInfoPopup_IDField;

        [FindsBy(How = How.XPath, Using = "//label[text()='Carrier Dynamic Text ']")]
        private IWebElement UpdateCarrierDynamicInfoPopup_TextField;

        [FindsBy(How = How.XPath, Using = "//p[@class='MuiTypography-root MuiTypography-body1 jss129 css-9l3uo3' and contains(text(),'Update FOC Dynamic Info')]")]
        private IWebElement UpdateFocDynamicInfoPopup_HeaderText;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='cancelButton']")]
        private IWebElement DeleteCarrierDynamicInfoPopup_Cancelbtn;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='okButton']//p[contains(text(),'Delete')]")]
        private IWebElement DeleteCarrierDynamicInfoPopup_Deletebtn;

        [FindsBy(How = How.XPath, Using = "//div[@class='MuiDataGrid-overlay css-14349d1' and contains(text(),'No results found.')]")]
        private IWebElement DeletedcarrierDynamicInfoPopup_deletedrecorddetails;

        [FindsBy(How = How.XPath, Using = "//div[@class='MuiDataGrid-overlayWrapperInner css-0']//div[ contains(text(),'No results found.')]")]
        private IWebElement Search_View_InvalidRecordDetails;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='saveCSP']")]
        private IWebElement NewCarrierDynamicInfoPopup_Savebtn;

        [FindsBy(How = How.XPath, Using = "//p[@id=':rkm:-helper-text' and contains(text(),'BOC Dynamic Text is required.')]")]
        private IWebElement NewBocDynamicInfoPopup_validationmessage;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='2'])[position()=1]")]
        private IWebElement CarrierDynamicInfo_created;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='1'])[position()=1]")]
        private IWebElement CarrierDynamicInfo_created_ID;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='2'])[position()=1]")]
        private IWebElement CarrierDynamicInfo_Updated;

        [FindsBy(How = How.XPath, Using = "//div[@class='go1888806478 notistack-MuiContent notistack-MuiContent-success go167266335 go1725278324 go3162094071']//div[@id='notistack-snackbar']")]
        private IWebElement CarrierDynamicInfo_recordAdd_sucessmessage;

        [FindsBy(How = How.XPath, Using = "//p[@class='MuiFormHelperText-root Mui-error MuiFormHelperText-sizeMedium MuiFormHelperText-contained css-v7esy']")]
        private IWebElement CarrierDynamicInfo_Addwithouttext_Error;

        [FindsBy(How = How.XPath, Using = "//p[@class='MuiFormHelperText-root Mui-error MuiFormHelperText-sizeMedium MuiFormHelperText-contained css-v7esy']")]
        private IWebElement CarrierDynamicInfo_Textinput_exceedcharlimit_error;

        [FindsBy(How = How.XPath, Using = "//div[@class='go1888806478 notistack-MuiContent notistack-MuiContent-error go167266335 go3651055292 go3162094071']//div[@id='notistack-snackbar']")]
        private IWebElement CarrierDynamicInfo_Textinput_dublicaterecord_Error;

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-cell MuiDataGrid-cell--textRight'])[position()=1]")]
        private IWebElement CarrierDynamicInfo_ID;

        [FindsBy(How = How.XPath, Using = "//div[@class='go1888806478 notistack-MuiContent notistack-MuiContent-success go167266335 go1725278324 go3162094071']//div[@id='notistack-snackbar']")]
        private IWebElement Toster_sucessmessage;

        [FindsBy(How = How.XPath, Using = "//div[@class='go1888806478 notistack-MuiContent notistack-MuiContent-success go167266335 go1725278324 go3162094071']//div[@id='notistack-snackbar']")]
        private IWebElement CarrierDynamicInfo_recordUpdate_sucessmessage;

        [FindsBy(How = How.XPath, Using = "//div[@class='go1888806478 notistack-MuiContent notistack-MuiContent-success go167266335 go1725278324 go3162094071']//div[@id='notistack-snackbar']")]
        private IWebElement CarrierDynamicInfo_recordDelete_sucessmessage;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='closeDelete']")]
        private IWebElement CarrierDynamicInfo_Delete_popup_closebutton;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='closeDelete']")]
        private IWebElement BocDynamicInfo_Delete_popup_Deletebutton;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Update Carrier Dynamic Info')]")]
        private IWebElement Update_CarrierInfo_popup_HeaderText;

        public void ValidatePageTitle()
        {
            DriverUtil.IsElementPresent(CarrierDynamicInfoPage_HeaderText);
        }

        public void ValidateNewCarrierDynamicInfoDialogBox()
        {
            DriverUtil.IsElementPresent(CarrierDynamicInfoPage_HeaderText);
        }

        public void CarrierDynamicInfo_HomePage_GridcolParameters(Boolean CarrierInfo_homepage_gridcolmns)
        {
           
            if (Carrier_homepage_IDGridcol.Displayed && Carrier_homepage_DynamicTextcol.Displayed && CarrierDynamic_homepage_Actioncol.Displayed)
            {
                CarrierInfo_homepage_gridcolmns = true;
            }
            else
            {
                Browser.Close();
            }
        }


       


        public void AddNewCarrierDynamicInfo(string CarrierDynamicText)
        {
            //create new Carrier dynamic info record verify the add new popup details
            Browser.Click(CarrierDynamicInfo_AddNew_button);
            var PopupHeaderText = CarrierDynamicInfoPage_HeaderText.Text;
            var PopupCancelbuttonText = NewCarrierDynamicInfoPopup_Cancelbtn.Text;
            var PopupsavebuttonText = NewCarrierDynamicInfoPopup_Savebtn.Text;
            var PopupCarrierDynamicTextField = NewCarrierDynamicInfoPopup_Textbox.Text;
            Browser.Click(NewCarrierDynamicInfoPopup_Cancelbtn);
            Browser.Click(CarrierDynamicInfo_AddNew_button);
            Browser.Click(NewCarrierDynamicInfoPopup_Closebtn);
            Browser.Click(CarrierDynamicInfo_AddNew_button);
            NewCarrierDynamicInfoPopup_Textbox.SendKeys(CarrierDynamicText.ToString());
            var CarrierDynamicText_InputData = NewCarrierDynamicInfoPopup_Textbox.GetDomAttribute("value");
            Browser.Click(NewCarrierDynamicInfoPopup_Savebtn);
            Thread.Sleep(4000);
            var Add_CarrierDynamicInfo_SuccessMessage = CarrierDynamicInfo_recordAdd_sucessmessage.Text;
            var CarrierDynamicInfo_Id = CarrierDynamicInfo_ID.Text;

            //Search with newly created record
            CarrierDynamicInfo_AutoSearch_textbox.Clear();
            CarrierDynamicInfo_AutoSearch_textbox.SendKeys(CarrierDynamicText_InputData.ToString());
            var Created_CarrierInfo_record_details = CarrierDynamicInfo_created.Text;

            //Validations
            Assert.That(PopupHeaderText, Is.EqualTo("New Carrier Dynamic Info"));
            Assert.That(PopupCancelbuttonText, Is.EqualTo("CANCEL"));
            Assert.That(PopupsavebuttonText, Is.EqualTo("SAVE"));
            Assert.That(Add_CarrierDynamicInfo_SuccessMessage, Does.Contain("Carrier Dynamic Info " + CarrierDynamicInfo_Id + " added Successfully."));
            Assert.That(Created_CarrierInfo_record_details, Does.Contain(CarrierDynamicText_InputData));
        }

        public void EditCarrierDynamicInfo(string UpdateCarrierDynamicText)
        {

            //create new carrier dynamic info record
            Browser.Click(CarrierDynamicInfo_AddNew_button);
            NewCarrierDynamicInfoPopup_Textbox.SendKeys(UpdateCarrierDynamicText.ToString());
            var CarrierDynamicText_InputData = NewCarrierDynamicInfoPopup_Textbox.GetDomAttribute("value");
            Browser.Click(NewCarrierDynamicInfoPopup_Savebtn);
            Thread.Sleep(4000);
            var Add_CarrierDynamicInfo_SuccessMessage = CarrierDynamicInfo_recordAdd_sucessmessage.Text;
            var CarrierDynamicInfo_Id = CarrierDynamicInfo_ID.Text;

            //Search with newly created record
            CarrierDynamicInfo_AutoSearch_textbox.Clear();
            CarrierDynamicInfo_AutoSearch_textbox.SendKeys(CarrierDynamicText_InputData.ToString());
            var Created_CarrierInfo_record_details = CarrierDynamicInfo_created.Text;


            //click on Edit icon and verify the popup details and go for Edit
            Browser.Click(CarrierDynamicInfo_Edit_Icon_button);
            var EditPopupTextboxfield = UpdateCarrierDynamicInfoPopup_TextField.Text;
            var EditPopupIdfield = UpdateCarrierDynamicInfoPopup_IDField.Text;
            var EditPopupCancelbuttonText = NewCarrierDynamicInfoPopup_Cancelbtn.Text;
            var EditPopupsavebuttonText = NewCarrierDynamicInfoPopup_Savebtn.Text;
            var UpdateCarrierInfo_popup_HeaderText = Update_CarrierInfo_popup_HeaderText.Text;
            NewCarrierDynamicInfoPopup_Textbox.SendKeys(CarrierDynamicText_InputData + "_Updated");
            var updateCarrierInfoExpectedUserData = NewCarrierDynamicInfoPopup_Textbox.GetDomAttribute("value");
            var updateCarrierInfoIDfieldvalue = UpdateCarrierDynamicInfoPopup_IDField.GetDomAttribute("value");
            Browser.Click(NewCarrierDynamicInfoPopup_Savebtn);
            Thread.Sleep(4000);
            var CarrierDynmaicInfoUpdatesuccessmessage = CarrierDynamicInfo_recordUpdate_sucessmessage.Text;

            //after updated record search with same record details
            CarrierDynamicInfo_AutoSearch_textbox.Clear();
            CarrierDynamicInfo_AutoSearch_textbox.SendKeys(updateCarrierInfoExpectedUserData.ToString());
            var UpdatedCarrierInfoActualData = CarrierDynamicInfo_Updated.Text;

            //validations
            Assert.That(Add_CarrierDynamicInfo_SuccessMessage, Does.Contain("Carrier Dynamic Info " + CarrierDynamicInfo_Id + " added Successfully."));
            Assert.That(EditPopupTextboxfield, Is.EqualTo("Carrier Dynamic Text "));
            Assert.That(EditPopupIdfield, Does.Contain("ID:"));
            Assert.That(EditPopupCancelbuttonText, Is.EqualTo("CANCEL"));
            Assert.That(EditPopupsavebuttonText, Is.EqualTo("SAVE"));
            Assert.That(UpdateCarrierInfo_popup_HeaderText, Is.EqualTo("Update Carrier Dynamic Info"));
            Assert.That(CarrierDynmaicInfoUpdatesuccessmessage, Is.EqualTo("Carrier Dynamic Info " + CarrierDynamicInfo_Id + " updated Successfully."));
            Assert.That(UpdatedCarrierInfoActualData, Is.EqualTo(updateCarrierInfoExpectedUserData));


        }


        public void DeleteCarrierDynamicInfo(string DeleteCarrierDynamicText)
        {
            //create new carrier dynamic info record
            Browser.Click(CarrierDynamicInfo_AddNew_button);
            NewCarrierDynamicInfoPopup_Textbox.SendKeys(DeleteCarrierDynamicText.ToString());
            var CarrierDynamicText_InputData = NewCarrierDynamicInfoPopup_Textbox.GetDomAttribute("value");
            Browser.Click(NewCarrierDynamicInfoPopup_Savebtn);
            Thread.Sleep(4000);
            var Add_CarrierDynamicInfo_SuccessMessage = CarrierDynamicInfo_recordAdd_sucessmessage.Text;
            var CarrierDynamicInfo_Id = CarrierDynamicInfo_ID.Text;

            //Search with newly created record
            CarrierDynamicInfo_AutoSearch_textbox.Clear();
            CarrierDynamicInfo_AutoSearch_textbox.SendKeys(CarrierDynamicText_InputData.ToString());
            var Created_CarrierInfo_record_details = CarrierDynamicInfo_created.Text;

            //click on delete icon and verify the popup details and go for delete
            Browser.Click(CarrierDynamicInfo_Detete_Icon_button);
            var Deletepopup_headertext = CarrierDynamicInfo_Detete_popup_HeaderText.Text;
            var DeletePopupCancelbuttonText = DeleteCarrierDynamicInfoPopup_Cancelbtn.Text;
            var DeletePopupDeletebuttonText = DeleteCarrierDynamicInfoPopup_Deletebtn.Text;
            var Deletewarningmessage = CarrierDynamicInfo_Detete_popup_warningmessage.Text;
            var deleteexpectedwarningmessage = Deletewarningmessage.ToString();
            Browser.Click(CarrierDynamicInfo_Delete_popup_closebutton);
            Browser.Click(CarrierDynamicInfo_Detete_Icon_button);
            Browser.Click(CarrierDynamicInfo_Detete_popup_Cancelbutton);
            Browser.Click(CarrierDynamicInfo_Detete_Icon_button);
            Browser.Click(DeleteCarrierDynamicInfoPopup_Deletebtn);
            Thread.Sleep(4000);
            var Actualdeletedrecordsuccessmessage = CarrierDynamicInfo_recordDelete_sucessmessage.Text;

            //after deleted record search with same record details
            CarrierDynamicInfo_AutoSearch_textbox.Clear();
            CarrierDynamicInfo_AutoSearch_textbox.SendKeys(CarrierDynamicText_InputData.ToString());
            var afterdeletedrecorddetails = DeletedcarrierDynamicInfoPopup_deletedrecorddetails.Text;

            
            //validations
            Assert.That(Add_CarrierDynamicInfo_SuccessMessage, Does.Contain("Carrier Dynamic Info " + CarrierDynamicInfo_Id + " added Successfully."));
            Assert.That(Deletepopup_headertext, Is.EqualTo("Delete"));
            Assert.That(DeletePopupCancelbuttonText, Is.EqualTo("CANCEL"));
            Assert.That(DeletePopupDeletebuttonText, Is.EqualTo("DELETE"));
            Assert.That(Deletewarningmessage, Does.Contain(deleteexpectedwarningmessage));
            Assert.That(Actualdeletedrecordsuccessmessage, Does.Contain("Carrier Dynamic Info " + CarrierDynamicInfo_Id + " deleted Successfully."));
        }

        public void ViewandSearchCarrierDynamicInfo(string ViewSearchCarrierDynamicText)
        {
            //verify the grid colomns displayed or not
            CarrierDynamicInfo_HomePage_GridcolParameters(true);

            //create new carrier dynamic info record
            Browser.Click(CarrierDynamicInfo_AddNew_button);
            NewCarrierDynamicInfoPopup_Textbox.SendKeys(ViewSearchCarrierDynamicText.ToString());
            var CarrierDynamicText_InputData = NewCarrierDynamicInfoPopup_Textbox.GetDomAttribute("value");
            Browser.Click(NewCarrierDynamicInfoPopup_Savebtn);
            Thread.Sleep(4000);
            var Add_CarrierDynamicInfo_SuccessMessage = CarrierDynamicInfo_recordAdd_sucessmessage.Text;
            var CarrierDynamicInfo_Id = CarrierDynamicInfo_ID.Text;

            //search and view with newly created record details with valid Text
            CarrierDynamicInfo_AutoSearch_textbox.Clear();
            CarrierDynamicInfo_AutoSearch_textbox.SendKeys(CarrierDynamicText_InputData.ToString());
            var Search_withvalid_Text = CarrierDynamicInfo_created.Text;

            //search and view with newly created record details with Valid ID
            CarrierDynamicInfo_AutoSearch_textbox.Clear();
            CarrierDynamicInfo_AutoSearch_textbox.SendKeys(CarrierDynamicInfo_Id.ToString());
            var Search_Valid_Id = CarrierDynamicInfo_created_ID.Text;

            //search and view with Invalid Text details
            CarrierDynamicInfo_AutoSearch_textbox.Clear();
            CarrierDynamicInfo_AutoSearch_textbox.SendKeys(CarrierDynamicText_InputData + "@#$%^&*(HG");
            var Search_Invalid_Text = Search_View_InvalidRecordDetails.Text;

            //search and view with Invalid Id details
            CarrierDynamicInfo_AutoSearch_textbox.Clear();
            CarrierDynamicInfo_AutoSearch_textbox.SendKeys(Search_Valid_Id + "1234");
            var Search_Invalid_Id = Search_View_InvalidRecordDetails.Text;


            //validations
            Assert.That(CarrierDynamicText_InputData, Does.Contain(Search_withvalid_Text));
            Assert.That(Search_Valid_Id, Is.EqualTo(CarrierDynamicInfo_Id));
            Assert.That(Search_Invalid_Text, Does.Contain("No results found."));
            Assert.That(Search_Invalid_Text, Does.Contain("No results found."));
        }


        public void ValidationsCarrierDynamicInfo(string NegativeScenariosText)
        {

            //create new dynamic info record
            Browser.Click(CarrierDynamicInfo_AddNew_button);
            NewCarrierDynamicInfoPopup_Textbox.SendKeys(NegativeScenariosText.ToString());
            var CarrierDynamicText_InputData = NewCarrierDynamicInfoPopup_Textbox.GetDomAttribute("value");
            Browser.Click(NewCarrierDynamicInfoPopup_Savebtn);
            Thread.Sleep(4000);


            //Scenario1 : Without Dynamic carrier text field value input
            Browser.Click(CarrierDynamicInfo_AddNew_button);
            Browser.Click(NewCarrierDynamicInfoPopup_Savebtn);
            Thread.Sleep(4000);
            var AddCarrierdynamicinfo_withoutText_ValidationMessage = CarrierDynamicInfo_Addwithouttext_Error.Text;

            //Scenario 2: Exceed TextBox input char limits

            NewCarrierDynamicInfoPopup_Textbox.SendKeys(NegativeScenariosText + "morethan200characters&*^$%^&$#@%^&*&^%$#dwedhwejjejehwejfenmrfbef");
            Browser.Click(NewCarrierDynamicInfoPopup_Savebtn);

            //Note: Application not allows morethan 100 char in textbox so unable to get the error message and locator
             var AddCarrier_TextInput_ExceedLimit_ValidationMessage = CarrierDynamicInfo_Textinput_exceedcharlimit_error.Text;

            //Scenario 3: Dublicate Record creates
            NewCarrierDynamicInfoPopup_Textbox.Clear();
            NewCarrierDynamicInfoPopup_Textbox.SendKeys(CarrierDynamicText_InputData);
            Browser.Click(NewCarrierDynamicInfoPopup_Savebtn);
            Thread.Sleep(4000);
            var AddCarrier_TextInput_dublicaterecord_ValidationMessage = CarrierDynamicInfo_Textinput_dublicaterecord_Error.Text;

            //validations
            Assert.That(AddCarrierdynamicinfo_withoutText_ValidationMessage, Does.Contain("Carrier Dynamic Text is required."));
            Assert.That(AddCarrier_TextInput_ExceedLimit_ValidationMessage, Does.Contain("Dynamic Carrier text length should be 1 to 200 characters."));
            Assert.That(AddCarrier_TextInput_dublicaterecord_ValidationMessage, Does.Contain("Sorry, Data validation failed.This Carrier Dynamic Info already exists!"));
        }
    }





    public class CP_CSPSettings_CarrierDynamicInfoPage : TestBase
    {
        IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='nestedMenuItem']//p[contains(text(),'CSP Settings')]")]
        public IWebElement CSVSettings_menu;

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='subMenuItems']//p[contains(text(),'BOC Dynamic Info')]")]
        public IWebElement BOC_Dynamic_Info_submenu;

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='subMenuItems']//p[contains(text(),'Card Holder Agreement')]")]
        public IWebElement Card_Holder_Agreement_submenu;

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='subMenuItems']//p[contains(text(),'Carrier Dynamic Info')]")]
        public IWebElement Carrier_Dynamic_Info_submenu;

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='subMenuItems']//p[contains(text(),'EMV Profile')]")]
        public IWebElement EMV_Profile_submenu;

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='subMenuItems']//p[contains(text(),'FOC Dynamic Info')]")]
        public IWebElement FOC_Dynamic_Info_submenu;

        [FindsBy(How = How.XPath, Using = "//p[@data-testid='secondNested' and contains(text(),'BOC Dynamic Info')]")]
        private IWebElement BOCDynamicInfo_menudropdowntext;

        [FindsBy(How = How.XPath, Using = "//div[@class='jss47 MuiBox-root css-0']//p[contains(text(),'New Card Holder Agreement')]")]
        private IWebElement NewCardHolderAgreementPage_HeaderText;

        [FindsBy(How = How.XPath, Using = "//div[@class='MuiDataGrid-columnHeaderTitleContainerContent']//div[contains(text(),'BOC Info ID')]")]
        private IWebElement BOCInfoID_GridColoumn;

        [FindsBy(How = How.XPath, Using = "//div[@class='MuiDataGrid-columnHeaderTitleContainerContent']//div[contains(text(),'BOC Dynamic Text')]")]
        private IWebElement BOCDynamicText_GridColoumn;

        [FindsBy(How = How.XPath, Using = "//div[@class='MuiDataGrid-columnHeaderTitleContainerContent']//div[contains(text(),'Last Updated')]")]
        private IWebElement LastUpdated_GridColoumn;

        [FindsBy(How = How.XPath, Using = "//div[@class='MuiDataGrid-columnHeaderTitleContainerContent']//div[contains(text(),'Actions')]")]
        private IWebElement Actions_GridColoumn;

        [FindsBy(How = How.XPath, Using = "//button[@aria-haspopup='menu' and contains(text(),'Columns')]")]
        private IWebElement BOCDynamicInfo_Columns_button;

        [FindsBy(How = How.XPath, Using = "//div[@class='MuiDataGrid-columnsManagementHeader css-1c0mwkm']//input[@type='text']")]
        private IWebElement BOCDynamicInfo_Columnspopup_Searchtextbox;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Row reordering')]")]
        private IWebElement BOCDynamicInfo_Columnspopup_Rowreordering_btn;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'BOC Info ID')]")]
        private IWebElement BOCDynamicInfo_Columnspopup_BOCInfoID_btn;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'BOC Dynamic Text')]")]
        private IWebElement BOCDynamicInfo_Columnspopup_BOCDynamicText_btn;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Last Updated')]")]
        private IWebElement BOCDynamicInfo_Columnspopup_LastUpdated_btn;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Actions')]")]
        private IWebElement BOCDynamicInfo_Columnspopup_Actions_btn;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Show/Hide All')]")]
        private IWebElement BOCDynamicInfo_Columnspopup_Show_HideAll_btn;

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Reset')]")]
        private IWebElement BOCDynamicInfo_Columnspopup_Resetbtn;

        [FindsBy(How = How.XPath, Using = "//button[@id=':rge:']")]
        private IWebElement BOCDynamicInfo_Filters_button;

        [FindsBy(How = How.XPath, Using = "//button[@id=':rgh:']")]
        private IWebElement BOCDynamicInfo_Export_button;

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Print')]")]
        private IWebElement BOCDynamicInfo_Print_button;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Search…']")]
        private IWebElement CardHolderAgreement_AutoSearch_textbox;

        [FindsBy(How = How.XPath, Using = "//button[@class='MuiButtonBase-root MuiIconButton-root MuiIconButton-sizeSmall css-irzi55']")]
        private IWebElement BOCDynamicInfo_AutoSearch_textboxclear;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='openModal']//p[contains(text(),'Add New')]")]
        private IWebElement CaradHolderAgreement_AddNew_button;

        [FindsBy(How = How.XPath, Using = "//div[@class='MuiDataGrid-columnHeaderTitle css-mh3zap' and contains(text(),'Carrier Info ID')]")]
        private IWebElement Carrier_homepage_IDGridcol;

        [FindsBy(How = How.XPath, Using = "//div[@class='MuiDataGrid-columnHeaderTitle css-mh3zap' and contains(text(),'Carrier Dynamic Text')]")]
        private IWebElement Carrier_homepage_DynamicTextcol;

        [FindsBy(How = How.XPath, Using = "//div[@class='MuiDataGrid-columnHeaderTitle css-mh3zap' and contains(text(),'Last Updated')]")]
        private IWebElement FOC_homepage_LastUpdatedcol;

        [FindsBy(How = How.XPath, Using = "//div[@class='MuiDataGrid-columnHeaderTitle css-mh3zap' and contains(text(),'Actions')]")]
        private IWebElement CarrierDynamic_homepage_Actioncol;

        [FindsBy(How = How.XPath, Using = "(//button[@data-testid='deleteCell'])[position()=1]")]

        private IWebElement CarrierDynamicInfo_Detete_Icon_button;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='cancelButton']")]

        private IWebElement CarrierDynamicInfo_Detete_popup_Cancelbutton;

        [FindsBy(How = How.XPath, Using = "//h2[contains(text(),'Delete')]")]
        private IWebElement CarrierDynamicInfo_Detete_popup_HeaderText;

        [FindsBy(How = How.XPath, Using = "//div[@class='MuiStack-root css-j7qwjs']")]
        private IWebElement CarrierDynamicInfo_Detete_popup_warningmessage;

        [FindsBy(How = How.XPath, Using = "(//button[@class='MuiButtonBase-root MuiIconButton-root MuiIconButton-sizeSmall textPrimary css-1pydezi'])[2]")]
        private IWebElement CardHolderAgreement_Edit_Icon_button;



        [FindsBy(How = How.XPath, Using = "//button[@data-testid='closeButton']")]
        private IWebElement CardHolderAggrementPopup_Closebtn;

        [FindsBy(How = How.XPath, Using = "//input[@data-testid='nameInputField']")]
        private IWebElement CardHolderAggrementPopup_Textbox;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='cancelCSP']")]
        private IWebElement CardHolderAggrementPopup_Cancelbtn;

        [FindsBy(How = How.XPath, Using = "//p[@class='MuiTypography-root MuiTypography-body1 css-qr1enj']")]
        private IWebElement UpdatecardholderAgreementPopup_IDField;

        [FindsBy(How = How.XPath, Using = "//label[text()='Name']")]
        private IWebElement UpdateCardHolderAgreementPopup_TextField;

        [FindsBy(How = How.XPath, Using = "//p[@class='MuiTypography-root MuiTypography-body1 jss129 css-9l3uo3' and contains(text(),'Update FOC Dynamic Info')]")]
        private IWebElement UpdateFocDynamicInfoPopup_HeaderText;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='cancelButton']")]
        private IWebElement DeleteCarrierDynamicInfoPopup_Cancelbtn;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='okButton']//p[contains(text(),'Delete')]")]
        private IWebElement DeleteCarrierDynamicInfoPopup_Deletebtn;

        [FindsBy(How = How.XPath, Using = "//div[@class='MuiDataGrid-overlay css-14349d1' and contains(text(),'No results found.')]")]
        private IWebElement DeletedcarrierDynamicInfoPopup_deletedrecorddetails;

        [FindsBy(How = How.XPath, Using = "//div[@class='MuiDataGrid-overlayWrapperInner css-0']//div[ contains(text(),'No results found.')]")]
        private IWebElement Search_View_InvalidRecordDetails;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='saveCSP']")]
        private IWebElement CardHolderAggrementPopup_Savebtn;

        [FindsBy(How = How.XPath, Using = "//p[@id=':rkm:-helper-text' and contains(text(),'BOC Dynamic Text is required.')]")]
        private IWebElement NewBocDynamicInfoPopup_validationmessage;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='2'])[position()=1]")]
        private IWebElement CardHolderAgreement_created;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='1'])[position()=1]")]
        private IWebElement CardHolderAgreement_created_ID;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='2'])[position()=1]")]
        private IWebElement CardHolderAgreement_Updated;

        [FindsBy(How = How.XPath, Using = "//div[@class='go1888806478 notistack-MuiContent notistack-MuiContent-success go167266335 go1725278324 go3162094071']//div[@id='notistack-snackbar']")]
        private IWebElement CardHolderAggrement_recordAdd_sucessmessage;

        [FindsBy(How = How.XPath, Using = "//p[@class='MuiFormHelperText-root Mui-error MuiFormHelperText-sizeMedium MuiFormHelperText-contained css-v7esy']")]
        private IWebElement CarrierDynamicInfo_Addwithouttext_Error;

        [FindsBy(How = How.XPath, Using = "//p[@class='MuiFormHelperText-root Mui-error MuiFormHelperText-sizeMedium MuiFormHelperText-contained css-v7esy']")]
        private IWebElement CarrierDynamicInfo_Textinput_exceedcharlimit_error;

        [FindsBy(How = How.XPath, Using = "//div[@class='go1888806478 notistack-MuiContent notistack-MuiContent-error go167266335 go3651055292 go3162094071']//div[@id='notistack-snackbar']")]
        private IWebElement CarrierDynamicInfo_Textinput_dublicaterecord_Error;

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-cell MuiDataGrid-cell--textRight'])[position()=1]")]
        private IWebElement CardHolderAgreement_ID;

        [FindsBy(How = How.XPath, Using = "//div[@class='go1888806478 notistack-MuiContent notistack-MuiContent-success go167266335 go1725278324 go3162094071']//div[@id='notistack-snackbar']")]
        private IWebElement Toster_sucessmessage;

        [FindsBy(How = How.XPath, Using = "//div[@class='go1888806478 notistack-MuiContent notistack-MuiContent-success go167266335 go1725278324 go3162094071']//div[@id='notistack-snackbar']")]
        private IWebElement CardHolderAgreement_recordUpdate_sucessmessage;

        [FindsBy(How = How.XPath, Using = "//div[@class='go1888806478 notistack-MuiContent notistack-MuiContent-success go167266335 go1725278324 go3162094071']//div[@id='notistack-snackbar']")]
        private IWebElement CarrierDynamicInfo_recordDelete_sucessmessage;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='closeDelete']")]
        private IWebElement CarrierDynamicInfo_Delete_popup_closebutton;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='closeDelete']")]
        private IWebElement BocDynamicInfo_Delete_popup_Deletebutton;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Update Card Holder Agreement')]")]
        private IWebElement Update_CardHolderAgreement_popup_HeaderText;

        public void ValidatePageTitle()
        {
            DriverUtil.IsElementPresent(CarrierDynamicInfoPage_HeaderText);
        }

        public void ValidateNewCarrierDynamicInfoDialogBox()
        {
            DriverUtil.IsElementPresent(CarrierDynamicInfoPage_HeaderText);
        }

        public void CarrierDynamicInfo_HomePage_GridcolParameters(Boolean CarrierInfo_homepage_gridcolmns)
        {

            if (Carrier_homepage_IDGridcol.Displayed && Carrier_homepage_DynamicTextcol.Displayed && CarrierDynamic_homepage_Actioncol.Displayed)
            {
                CarrierInfo_homepage_gridcolmns = true;
            }
            else
            {
                Browser.Close();
            }
        }





        public void AddCardHolderAgreementInfo(string CardHolderAgreementText)
        {
            //create new CardHolderAgreement info record verify the add new popup details
            Browser.Click(CaradHolderAgreement_AddNew_button);
            var PopupHeaderText = NewCardHolderAgreementPage_HeaderText.Text;
            var PopupCancelbuttonText = CardHolderAggrementPopup_Cancelbtn.Text;
            var PopupsavebuttonText = CardHolderAggrementPopup_Savebtn.Text;
            var PopupCarrierDynamicTextField = CardHolderAggrementPopup_Textbox.Text;
            Browser.Click(CardHolderAggrementPopup_Cancelbtn);
            Browser.Click(CaradHolderAgreement_AddNew_button);
            Browser.Click(CardHolderAggrementPopup_Closebtn);
            Browser.Click(CaradHolderAgreement_AddNew_button);
            CardHolderAggrementPopup_Textbox.SendKeys(CardHolderAgreementText.ToString());
            var CardHolderAggrementText_InputData = CardHolderAggrementPopup_Textbox.GetDomAttribute("value");
            Browser.Click(CardHolderAggrementPopup_Savebtn);
            Thread.Sleep(4000);
            var Add_CardHolderAggrement_SuccessMessage = CardHolderAggrement_recordAdd_sucessmessage.Text;
            var CardHolderAggrement_Id = CardHolderAgreement_ID.Text;

            //Search with newly created record
            CardHolderAgreement_AutoSearch_textbox.Clear();
            CardHolderAgreement_AutoSearch_textbox.SendKeys(CardHolderAggrementText_InputData.ToString());
            var Created_CardHolderAgreement_record_details = CardHolderAgreement_created.Text;

            //Validations
            Assert.That(PopupHeaderText, Is.EqualTo("New Card Holder Agreement"));
            Assert.That(PopupCancelbuttonText, Is.EqualTo("CANCEL"));
            Assert.That(PopupsavebuttonText, Is.EqualTo("SAVE"));
            Assert.That(Add_CardHolderAggrement_SuccessMessage, Does.Contain("Card Holder Agreement " + CardHolderAggrement_Id + " Added Successfully."));
            Assert.That(Created_CardHolderAgreement_record_details, Does.Contain(CardHolderAggrementText_InputData));
        }

        public void EditCardHolderAgreementInfo(string UpdateCardHolderAgreementText)
        {

            //create new carrier dynamic info record
            Browser.Click(CaradHolderAgreement_AddNew_button);
            CardHolderAggrementPopup_Textbox.SendKeys(UpdateCardHolderAgreementText.ToString());
            var CardHolderAggrementText_InputData = CardHolderAggrementPopup_Textbox.GetDomAttribute("value");
            Browser.Click(CardHolderAggrementPopup_Savebtn);
            Thread.Sleep(4000);
            var Add_CardHolderAggrement_SuccessMessage = CardHolderAggrement_recordAdd_sucessmessage.Text;
            var CardHolderAggrement_Id = CardHolderAgreement_ID.Text;

            //Search with newly created record
            CardHolderAgreement_AutoSearch_textbox.Clear();
            CardHolderAgreement_AutoSearch_textbox.SendKeys(CardHolderAggrementText_InputData.ToString());
            var Created_CardHolderAgreement_record_details = CardHolderAgreement_created.Text;


            //click on Edit icon and verify the popup details and go for Edit
            Browser.Click(CardHolderAgreement_Edit_Icon_button);
            var EditPopupTextboxfield = UpdateCardHolderAgreementPopup_TextField.Text;
            var EditPopupIdfield = UpdatecardholderAgreementPopup_IDField.Text;
            var EditPopupCancelbuttonText = CardHolderAggrementPopup_Cancelbtn.Text;
            var EditPopupsavebuttonText = CardHolderAggrementPopup_Savebtn.Text;
            var UpdateCardholder_popup_HeaderText = Update_CardHolderAgreement_popup_HeaderText.Text;
            CardHolderAggrementPopup_Textbox.SendKeys(CardHolderAggrementText_InputData + "_Updated");
            var updateCardholderExpectedUserData = CardHolderAggrementPopup_Textbox.GetDomAttribute("value");
            var updateCardholderIDfieldvalue = UpdatecardholderAgreementPopup_IDField.GetDomAttribute("value");
            Browser.Click(CardHolderAggrementPopup_Savebtn);
            Thread.Sleep(4000);
            var CardHolderAgreementUpdatesuccessmessage = CardHolderAgreement_recordUpdate_sucessmessage.Text;

            //after updated record search with same record details
            CardHolderAgreement_AutoSearch_textbox.Clear();
            CardHolderAgreement_AutoSearch_textbox.SendKeys(updateCardholderExpectedUserData.ToString());
            var UpdatedCardHolderActualData = CardHolderAgreement_Updated.Text;

            //validations
            Assert.That(Add_CardHolderAggrement_SuccessMessage, Does.Contain("Card Holder Agreement " + CardHolderAggrement_Id + " Added Successfully."));
            Assert.That(EditPopupTextboxfield, Is.EqualTo("Name"));
            Assert.That(EditPopupIdfield, Does.Contain("ID:"));
            Assert.That(EditPopupCancelbuttonText, Is.EqualTo("CANCEL"));
            Assert.That(EditPopupsavebuttonText, Is.EqualTo("SAVE"));
            Assert.That(UpdateCardholder_popup_HeaderText, Is.EqualTo("Update Card Holder Agreement"));
            Assert.That(CardHolderAgreementUpdatesuccessmessage, Is.EqualTo("Card Holder Agreement " + CardHolderAggrement_Id + " Updated Successfully."));
            Assert.That(UpdatedCardHolderActualData, Is.EqualTo(updateCardholderExpectedUserData));


        }


        public void DeleteCarrierDynamicInfo(string DeleteCarrierDynamicText)
        {
            //create new carrier dynamic info record
            Browser.Click(CarrierDynamicInfo_AddNew_button);
            NewCarrierDynamicInfoPopup_Textbox.SendKeys(DeleteCarrierDynamicText.ToString());
            var CarrierDynamicText_InputData = NewCarrierDynamicInfoPopup_Textbox.GetDomAttribute("value");
            Browser.Click(NewCarrierDynamicInfoPopup_Savebtn);
            Thread.Sleep(4000);
            var Add_CarrierDynamicInfo_SuccessMessage = CarrierDynamicInfo_recordAdd_sucessmessage.Text;
            var CarrierDynamicInfo_Id = CarrierDynamicInfo_ID.Text;

            //Search with newly created record
            CarrierDynamicInfo_AutoSearch_textbox.Clear();
            CarrierDynamicInfo_AutoSearch_textbox.SendKeys(CarrierDynamicText_InputData.ToString());
            var Created_CarrierInfo_record_details = CarrierDynamicInfo_created.Text;

            //click on delete icon and verify the popup details and go for delete
            Browser.Click(CarrierDynamicInfo_Detete_Icon_button);
            var Deletepopup_headertext = CarrierDynamicInfo_Detete_popup_HeaderText.Text;
            var DeletePopupCancelbuttonText = DeleteCarrierDynamicInfoPopup_Cancelbtn.Text;
            var DeletePopupDeletebuttonText = DeleteCarrierDynamicInfoPopup_Deletebtn.Text;
            var Deletewarningmessage = CarrierDynamicInfo_Detete_popup_warningmessage.Text;
            var deleteexpectedwarningmessage = Deletewarningmessage.ToString();
            Browser.Click(CarrierDynamicInfo_Delete_popup_closebutton);
            Browser.Click(CarrierDynamicInfo_Detete_Icon_button);
            Browser.Click(CarrierDynamicInfo_Detete_popup_Cancelbutton);
            Browser.Click(CarrierDynamicInfo_Detete_Icon_button);
            Browser.Click(DeleteCarrierDynamicInfoPopup_Deletebtn);
            Thread.Sleep(4000);
            var Actualdeletedrecordsuccessmessage = CarrierDynamicInfo_recordDelete_sucessmessage.Text;

            //after deleted record search with same record details
            CarrierDynamicInfo_AutoSearch_textbox.Clear();
            CarrierDynamicInfo_AutoSearch_textbox.SendKeys(CarrierDynamicText_InputData.ToString());
            var afterdeletedrecorddetails = DeletedcarrierDynamicInfoPopup_deletedrecorddetails.Text;


            //validations
            Assert.That(Add_CarrierDynamicInfo_SuccessMessage, Does.Contain("Carrier Dynamic Info " + CarrierDynamicInfo_Id + " added Successfully."));
            Assert.That(Deletepopup_headertext, Is.EqualTo("Delete"));
            Assert.That(DeletePopupCancelbuttonText, Is.EqualTo("CANCEL"));
            Assert.That(DeletePopupDeletebuttonText, Is.EqualTo("DELETE"));
            Assert.That(Deletewarningmessage, Does.Contain(deleteexpectedwarningmessage));
            Assert.That(Actualdeletedrecordsuccessmessage, Does.Contain("Carrier Dynamic Info " + CarrierDynamicInfo_Id + " deleted Successfully."));
        }

        public void ViewandSearchCarrierDynamicInfo(string ViewSearchCarrierDynamicText)
        {
            //verify the grid colomns displayed or not
            CarrierDynamicInfo_HomePage_GridcolParameters(true);

            //create new carrier dynamic info record
            Browser.Click(CarrierDynamicInfo_AddNew_button);
            NewCarrierDynamicInfoPopup_Textbox.SendKeys(ViewSearchCarrierDynamicText.ToString());
            var CarrierDynamicText_InputData = NewCarrierDynamicInfoPopup_Textbox.GetDomAttribute("value");
            Browser.Click(NewCarrierDynamicInfoPopup_Savebtn);
            Thread.Sleep(4000);
            var Add_CarrierDynamicInfo_SuccessMessage = CarrierDynamicInfo_recordAdd_sucessmessage.Text;
            var CarrierDynamicInfo_Id = CarrierDynamicInfo_ID.Text;

            //search and view with newly created record details with valid Text
            CarrierDynamicInfo_AutoSearch_textbox.Clear();
            CarrierDynamicInfo_AutoSearch_textbox.SendKeys(CarrierDynamicText_InputData.ToString());
            var Search_withvalid_Text = CarrierDynamicInfo_created.Text;

            //search and view with newly created record details with Valid ID
            CarrierDynamicInfo_AutoSearch_textbox.Clear();
            CarrierDynamicInfo_AutoSearch_textbox.SendKeys(CarrierDynamicInfo_Id.ToString());
            var Search_Valid_Id = CarrierDynamicInfo_created_ID.Text;

            //search and view with Invalid Text details
            CarrierDynamicInfo_AutoSearch_textbox.Clear();
            CarrierDynamicInfo_AutoSearch_textbox.SendKeys(CarrierDynamicText_InputData + "@#$%^&*(HG");
            var Search_Invalid_Text = Search_View_InvalidRecordDetails.Text;

            //search and view with Invalid Id details
            CarrierDynamicInfo_AutoSearch_textbox.Clear();
            CarrierDynamicInfo_AutoSearch_textbox.SendKeys(Search_Valid_Id + "1234");
            var Search_Invalid_Id = Search_View_InvalidRecordDetails.Text;


            //validations
            Assert.That(CarrierDynamicText_InputData, Does.Contain(Search_withvalid_Text));
            Assert.That(Search_Valid_Id, Is.EqualTo(CarrierDynamicInfo_Id));
            Assert.That(Search_Invalid_Text, Does.Contain("No results found."));
            Assert.That(Search_Invalid_Text, Does.Contain("No results found."));
        }


        public void ValidationsCarrierDynamicInfo(string NegativeScenariosText)
        {

            //create new dynamic info record
            Browser.Click(CarrierDynamicInfo_AddNew_button);
            NewCarrierDynamicInfoPopup_Textbox.SendKeys(NegativeScenariosText.ToString());
            var CarrierDynamicText_InputData = NewCarrierDynamicInfoPopup_Textbox.GetDomAttribute("value");
            Browser.Click(NewCarrierDynamicInfoPopup_Savebtn);
            Thread.Sleep(4000);


            //Scenario1 : Without Dynamic carrier text field value input
            Browser.Click(CarrierDynamicInfo_AddNew_button);
            Browser.Click(NewCarrierDynamicInfoPopup_Savebtn);
            Thread.Sleep(4000);
            var AddCarrierdynamicinfo_withoutText_ValidationMessage = CarrierDynamicInfo_Addwithouttext_Error.Text;

            //Scenario 2: Exceed TextBox input char limits

            NewCarrierDynamicInfoPopup_Textbox.SendKeys(NegativeScenariosText + "morethan200characters&*^$%^&$#@%^&*&^%$#dwedhwejjejehwejfenmrfbef");
            Browser.Click(NewCarrierDynamicInfoPopup_Savebtn);

            //Note: Application not allows morethan 100 char in textbox so unable to get the error message and locator
            var AddCarrier_TextInput_ExceedLimit_ValidationMessage = CarrierDynamicInfo_Textinput_exceedcharlimit_error.Text;

            //Scenario 3: Dublicate Record creates
            NewCarrierDynamicInfoPopup_Textbox.Clear();
            NewCarrierDynamicInfoPopup_Textbox.SendKeys(CarrierDynamicText_InputData);
            Browser.Click(NewCarrierDynamicInfoPopup_Savebtn);
            Thread.Sleep(4000);
            var AddCarrier_TextInput_dublicaterecord_ValidationMessage = CarrierDynamicInfo_Textinput_dublicaterecord_Error.Text;

            //validations
            Assert.That(AddCarrierdynamicinfo_withoutText_ValidationMessage, Does.Contain("Carrier Dynamic Text is required."));
            Assert.That(AddCarrier_TextInput_ExceedLimit_ValidationMessage, Does.Contain("Dynamic Carrier text length should be 1 to 200 characters."));
            Assert.That(AddCarrier_TextInput_dublicaterecord_ValidationMessage, Does.Contain("Sorry, Data validation failed.This Carrier Dynamic Info already exists!"));
        }
    }
}

