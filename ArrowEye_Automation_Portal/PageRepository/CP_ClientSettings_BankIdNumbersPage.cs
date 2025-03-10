using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
using ArrowEye_Automation_Framework.Common;
using NUnit.Framework;
using ArrowEye_Automation_Framework;
using System.Threading;

namespace ArrowEye_Automation_Portal.PageRepository
{
    public class CP_ClientSettings_BankIdNumbersPage : TestBase
    {
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

        [FindsBy(How = How.XPath, Using = "//div[@class='jss13 MuiBox-root css-0']//p[contains(text(),'BOC Dynamic Info')]")]
        private IWebElement BOCDynamicInfoPage_HeaderText;

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
        private IWebElement NewBankIDNumber_AutoSearch_textbox;

        [FindsBy(How = How.XPath, Using = "//button[@class='MuiButtonBase-root MuiIconButton-root MuiIconButton-sizeSmall css-irzi55']")]
        private IWebElement BOCDynamicInfo_AutoSearch_textboxclear;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='openModal']//p[contains(text(),'Add New')]")]
        private IWebElement BankIdNumbers_AddNew_button;

        [FindsBy(How = How.XPath, Using = "(//button[@data-testid='DeleteButton'])[position()=1]")]

        private IWebElement BOCDynamicInfo_Detete_Icon_button;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='cancelButton']")]

        private IWebElement BOCDynamicInfo_Detete_popup_Cancelbutton;

        [FindsBy(How = How.XPath, Using = "//h2[@class='MuiTypography-root MuiTypography-h6 MuiDialogTitle-root jss24 css-ohyacs' and contains(text(),'Delete')]")]

        private IWebElement BOCDynamicInfo_Detete_popup_HeaderText;

        [FindsBy(How = How.XPath, Using = "//p[@class='MuiTypography-root MuiTypography-body1 jss25 css-q3n577']")]

        private IWebElement BOCDynamicInfo_Detete_popup_warningmessage;

        [FindsBy(How = How.XPath, Using = "(//button[@data-testid='editIcon'])[position()=1]")]
        private IWebElement NewBankIdNumber_Edit_Icon_button;

        [FindsBy(How = How.XPath, Using = "//input[@data-testid='binName']")]
        private IWebElement NewBankIdNumber_Edit_Binname_Textbox;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'New Bank ID Number')]")]
        private IWebElement NewBankIdNumber_Add_Popup_HeaderText;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='closeButton']")]
        private IWebElement NewBankIdNumber_Popup_Closebtn;

        [FindsBy(How = How.XPath, Using = "//input[@data-testid='bankIDNumber']")]
        private IWebElement NewBankIdCreation_Popup_Textbox;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='cancelBankID']")]
        private IWebElement NewBankIdNumber_Popup_Cancelbtn;

        [FindsBy(How = How.XPath, Using = "//p[@class='MuiTypography-root MuiTypography-body1 css-g8bn14']")]
        private IWebElement UpdateBankIdNumber_poPopup_IDField;

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Bank ID Number')]")]
        private IWebElement UpdateBankIdNumber_Popup_BankIdlabelText;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='cancelButton']")]
        private IWebElement DeleteBocDynamicInfoPopup_Cancelbtn;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='okButton']//p[contains(text(),'Delete')]")]
        private IWebElement DeleteBocDynamicInfoPopup_Deletebtn;

        [FindsBy(How = How.XPath, Using = "//div[@class='MuiDataGrid-overlay css-14349d1'][contains(text(),'No results found.')]")]
        private IWebElement DeleteBocDynamicInfoPopup_deletedrecorddetails;

        [FindsBy(How = How.XPath, Using = "//div[@class='MuiDataGrid-overlayWrapperInner css-0']//div[contains(text(),'No results found.')]")]
        private IWebElement Search_View_InvalidRecordDetails;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='saveBankID']")]
        private IWebElement NewBankIdNumber_Popup_Savebtn;

        [FindsBy(How = How.XPath, Using = "(//input[@class='MuiSwitch-input css-q7japm'])[position()=1]")]
        private IWebElement NewBankIdNumber_enable_disabled_statusbtn;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid=\"okButton\"]//p[@class='MuiTypography-root MuiTypography-body1 css-9l3uo3']")]
        private IWebElement NewBankIdNumber_enable_disable_popup_Disabledbutton;

        [FindsBy(How = How.XPath, Using = "//h2[@class='MuiTypography-root MuiTypography-h6 MuiDialogTitle-root jss104 css-ohyacs']")]
        private IWebElement NewBankIdNumber_disabled_popup_headertext;

        [FindsBy(How = How.XPath, Using = "//p[@class='MuiTypography-root MuiTypography-body1 jss105 css-q3n577']")]
        private IWebElement NewBankIdNumber_disabled_popup_warningmessage;

        [FindsBy(How = How.XPath, Using = "//span[@class='MuiBox-root css-1cwt7q0']")]
        private IWebElement NewBankIdNumber_disabled_popup_warningmessage_bankid;

        [FindsBy(How = How.XPath, Using = "//p[@id=':rkm:-helper-text' and contains(text(),'BOC Dynamic Text is required.')]")]
        private IWebElement NewBocDynamicInfoPopup_validationmessage;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='2'])[position()=1]")]
        private IWebElement NewBankIdNumber_created;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='2'])[position()=1]")]
        private IWebElement BankIdNumber_Updated;

        [FindsBy(How = How.XPath, Using = "//div[@class='go1888806478 notistack-MuiContent notistack-MuiContent-success go167266335 go1725278324 go3162094071']//div[@id='notistack-snackbar']")]
        private IWebElement NewBankIdNumber_recordAdd_sucessmessage;

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-cell MuiDataGrid-cell--textRight'])[position()=1]")]
        private IWebElement AddedNewBankIdNumber_ID;

        [FindsBy(How = How.XPath, Using = "(//p[@class='MuiTypography-root MuiTypography-body1 css-1cdulpx'])[position()=1]")]
        private IWebElement defaultt_status_bankid;

        [FindsBy(How = How.XPath, Using = "//div[@class='go1888806478 notistack-MuiContent notistack-MuiContent-success go167266335 go1725278324 go3162094071']//div[@id='notistack-snackbar']")]
        private IWebElement Toster_sucessmessage;

        [FindsBy(How = How.XPath, Using = "//div[@class='go1888806478 notistack-MuiContent notistack-MuiContent-success go167266335 go1725278324 go3162094071']//div[@id='notistack-snackbar']")]
        private IWebElement BankIdNumber_recordUpdate_sucessmessage;

        [FindsBy(How = How.XPath, Using = "//div[@class='go1888806478 notistack-MuiContent notistack-MuiContent-success go167266335 go1725278324 go3162094071']//div[@id='notistack-snackbar']")]
        private IWebElement BocDynamicInfo_recordDelete_sucessmessage;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='closeDelete']")]
        private IWebElement BocDynamicInfo_Delete_popup_closebutton;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='closeDelete']")]
        private IWebElement BocDynamicInfo_Delete_popup_Deletebutton;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Update Bank ID Number')]")]
        private IWebElement Update_BankId_popup_HeaderText;

        [FindsBy(How = How.XPath, Using = "//input[@data-testid='binName']")]
        private IWebElement NewBankIdNumber_popup_BinName;

        [FindsBy(How = How.XPath, Using = "(//div[@data-field='id'])[1]")]
        private IWebElement NewBankIdNumber_homepage_ID;

        [FindsBy(How = How.XPath, Using = "(//div[@data-field='bankIdNumber'])[1]")]
        private IWebElement NewBankIdNumber_homepage_BankIdNum;

        [FindsBy(How = How.XPath, Using = "(//div[@data-field='binName'])[1]")]
        private IWebElement NewBankIdNumber_homepage_BinNameNum;

        [FindsBy(How = How.XPath, Using = "(//div[@data-field='magTrackName'])[1]")]
        private IWebElement NewBankIdNumber_homepage_magTrackName;

        [FindsBy(How = How.XPath, Using = "(//div[@data-field='bcssName'])[1]")]
        private IWebElement NewBankIdNumber_homepage_bcssName;

        [FindsBy(How = How.XPath, Using = "(//div[@data-field='issuingBankName'])[1]")]
        private IWebElement NewBankIdNumber_homepage_issuingBankName;

        [FindsBy(How = How.XPath, Using = "(//div[@data-field='isActive'])[1]")]
        private IWebElement NewBankIdNumber_homepage_Status;

        [FindsBy(How = How.XPath, Using = "//div[@data-testid='mag_track_encoding']")]
        private IWebElement NewBankIdNumber_popup_magtrackencodingdd;

        [FindsBy(How = How.XPath, Using = "//div[@data-testid='bcss_configuration']")]
        private IWebElement NewBankIdNumber_popup_BCSSdd;

        [FindsBy(How = How.XPath, Using = "//div[@data-testid='issuing_bank']")]
        private IWebElement NewBankIdNumber_popup_IssuingBankdd;

        [FindsBy(How = How.XPath, Using = "//p[@class='MuiFormHelperText-root Mui-error MuiFormHelperText-sizeMedium MuiFormHelperText-contained css-v7esy']")]
        private IWebElement NewBankIdNumber_popup_Addwithouttext_Error;

        [FindsBy(How = How.XPath, Using = "//li[@class='MuiListItem-root MuiListItem-gutters MuiListItem-padding css-rqhalv']")]
        private IWebElement NewBankIdNumber_Textinput_dublicaterecord_Error;

        [FindsBy(How = How.XPath, Using = "//p[@class='MuiFormHelperText-root Mui-error MuiFormHelperText-sizeMedium MuiFormHelperText-contained MuiFormHelperText-filled css-v7esy']")]
        private IWebElement NewBankIdNumber_Textinput_exceedcharlimit_error;

        [FindsBy(How = How.XPath, Using = "//p[@class='MuiFormHelperText-root Mui-error MuiFormHelperText-sizeMedium MuiFormHelperText-contained MuiFormHelperText-filled css-v7esy']")]
        private IWebElement NewBankIdNumber_Textinput_alphnumeric_error;

        [FindsBy(How = How.XPath, Using = "//p[@class='MuiFormHelperText-root Mui-error MuiFormHelperText-sizeMedium MuiFormHelperText-contained MuiFormHelperText-filled css-v7esy']")]
        private IWebElement NewBankIdNumber_linked_active_inactive_error;

        [FindsBy(How = How.XPath, Using = "//p[@class='MuiFormHelperText-root Mui-error MuiFormHelperText-sizeMedium MuiFormHelperText-contained MuiFormHelperText-filled css-v7esy']")]
        private IWebElement NewBankIdNumber_binnameTextinput_exceed_error;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Export']")]
        public IWebElement NewBankIdNumber_Export;

        [FindsBy(How = How.XPath, Using = "//li[@role='menuitem']")]
        public IWebElement NewBankIdNumber_downloadCSV;

        public void ValidatePageTitle()
        {
            DriverUtil.IsElementPresent(BOCDynamicInfoPage_HeaderText);
        }

        public void ValidateNewIssuerDialogBox()
        {
            DriverUtil.IsElementPresent(NewBankIdNumber_Add_Popup_HeaderText);
        }

        public void ClientSettings_homepage_Fields(bool fields)
        {
            if (fields != false)
            {

                if (NewBankIdNumber_homepage_ID.Displayed && NewBankIdNumber_homepage_BankIdNum.Displayed && NewBankIdNumber_homepage_BinNameNum.Displayed && NewBankIdNumber_homepage_magTrackName.Displayed && NewBankIdNumber_homepage_bcssName.Displayed && NewBankIdNumber_homepage_issuingBankName.Displayed && NewBankIdNumber_homepage_Status.Displayed)
                {

                }
            }
            else
            {
                Browser.Close();
            }
        }

        public void ClientSettings_NewBankIdNumber_Fields(bool fields)
        {
            if (fields!=false)
            {

                if (NewBankIdNumber_popup_BinName.Displayed && NewBankIdNumber_popup_magtrackencodingdd.Displayed && NewBankIdNumber_popup_BCSSdd.Displayed && NewBankIdNumber_popup_IssuingBankdd.Displayed)
                {
                    
                }
            }
            else
            {
                Browser.Close();
            }
        }

        public void ClientSettings_NewBankIdNumber_EditableFields(bool fields)
        {
            if (fields != false)
            {

                if (NewBankIdNumber_popup_BinName.Displayed && NewBankIdNumber_popup_magtrackencodingdd.Displayed && NewBankIdNumber_popup_BCSSdd.Displayed && NewBankIdNumber_popup_IssuingBankdd.Displayed)
                {

                }
            }
            else
            {
                Browser.Close();
            }
        }
        public void CreateNewBankIdNumbers(string CreateNewBankIdNumbers)
        {
            //create new BankIdNumbers info record verify the add new popup details
            Browser.Click(BankIdNumbers_AddNew_button);
            var PopupHeaderText = NewBankIdNumber_Add_Popup_HeaderText.Text;
            var PopupCancelbuttonText = NewBankIdNumber_Popup_Cancelbtn.Text;
            var PopupsavebuttonText = NewBankIdNumber_Popup_Savebtn.Text;
            var Popupmandatory_BankIdNumberField = NewBankIdCreation_Popup_Textbox.Text;
            ClientSettings_NewBankIdNumber_Fields(true);
            Browser.Click(NewBankIdNumber_Popup_Cancelbtn);
            Browser.Click(BankIdNumbers_AddNew_button);
            Browser.Click(NewBankIdNumber_Popup_Closebtn);
            Browser.Click(BankIdNumbers_AddNew_button);
            NewBankIdCreation_Popup_Textbox.SendKeys(CreateNewBankIdNumbers.ToString());
            var NewBankIdNumberTextbox_InputData = NewBankIdCreation_Popup_Textbox.GetDomAttribute("value");
            Browser.Click(NewBankIdNumber_Popup_Savebtn);
            Thread.Sleep(4000);
            var Add_NewBankIdNumber_SuccessMessage = NewBankIdNumber_recordAdd_sucessmessage.Text;
            var NewlyaddedBankIdNumber_Id = AddedNewBankIdNumber_ID.Text;

            //Search with newly created record
            NewBankIDNumber_AutoSearch_textbox.Clear();
            NewBankIDNumber_AutoSearch_textbox.SendKeys(NewBankIdNumberTextbox_InputData.ToString());
            var Added_NewBankIdNumber_record_details = NewBankIdNumber_created.Text;

            //Validations
            Assert.That(PopupHeaderText, Is.EqualTo("New Bank ID Number"));
            Assert.That(PopupCancelbuttonText, Is.EqualTo("CANCEL"));
            Assert.That(PopupsavebuttonText, Is.EqualTo("SAVE"));
            Assert.That(Add_NewBankIdNumber_SuccessMessage, Does.Contain("Bank Id Number " + NewlyaddedBankIdNumber_Id + " Added Successfully."));
            Assert.That(Added_NewBankIdNumber_record_details, Does.Contain(NewBankIdNumberTextbox_InputData));

        }

        public void EditNewBankIdNumbers(string UpdateNewBankIdNumbers)
        {
            // //create new BankIdNumber info record
            Browser.Click(BankIdNumbers_AddNew_button);
            NewBankIdCreation_Popup_Textbox.SendKeys(UpdateNewBankIdNumbers.ToString());
            var NewBankIdNumberTextbox_InputData = NewBankIdCreation_Popup_Textbox.GetDomAttribute("value");
            Browser.Click(NewBankIdNumber_Popup_Savebtn);
            Thread.Sleep(4000);
            var Add_NewBankIdNumber_SuccessMessage = NewBankIdNumber_recordAdd_sucessmessage.Text;
            var NewlyaddedBankIdNumber_Id = AddedNewBankIdNumber_ID.Text;

            //Search with newly created record
            NewBankIDNumber_AutoSearch_textbox.Clear();
            NewBankIDNumber_AutoSearch_textbox.SendKeys(NewBankIdNumberTextbox_InputData.ToString());
            var Added_NewBankIdNumber_record_details = NewBankIdNumber_created.Text;
            //click on Edit icon and verify the popup details and go for Edit
            Browser.Click(NewBankIdNumber_Edit_Icon_button);
            //fields displayed
            ClientSettings_NewBankIdNumber_Fields(true);
            //Editable fields displayed
            ClientSettings_NewBankIdNumber_EditableFields(true);
            var EditPopupBankIdNumberlable = UpdateBankIdNumber_Popup_BankIdlabelText.Text;
            var EditPopupIDlabel = UpdateBankIdNumber_poPopup_IDField.Text;
            var EditPopupCancelbuttonText = NewBankIdNumber_Popup_Cancelbtn.Text;
            var EditPopupsavebuttonText = NewBankIdNumber_Popup_Savebtn.Text;
            var UpdateBankIdNumber_popup_HeaderText = Update_BankId_popup_HeaderText.Text;
            NewBankIdCreation_Popup_Textbox.SendKeys(NewBankIdNumberTextbox_InputData + "11");
            var updateBankIdNumberExpectedinput = NewBankIdCreation_Popup_Textbox.GetDomAttribute("value");
            var updateBankIdNumberIDfieldvalue = UpdateBankIdNumber_poPopup_IDField.GetDomAttribute("value");
            Browser.Click(NewBankIdNumber_Popup_Savebtn);
            Thread.Sleep(4000);
            var UpdateBankIdNumbersuccessmessage = BankIdNumber_recordUpdate_sucessmessage.Text;

            //after updated record search with same record details
            NewBankIDNumber_AutoSearch_textbox.Clear();
            NewBankIDNumber_AutoSearch_textbox.SendKeys(updateBankIdNumberExpectedinput.ToString());
            var UpdatedBankIdNumberActualData = BankIdNumber_Updated.Text;

            //validations
            Assert.That(Add_NewBankIdNumber_SuccessMessage, Does.Contain("Bank Id Number " + NewlyaddedBankIdNumber_Id + " Added Successfully."));
            Assert.That(EditPopupBankIdNumberlable, Is.EqualTo("Bank ID Number"));
            Assert.That(EditPopupIDlabel, Does.Contain("ID:"));
            Assert.That(EditPopupCancelbuttonText, Is.EqualTo("CANCEL"));
            Assert.That(EditPopupsavebuttonText, Is.EqualTo("SAVE"));
            Assert.That(UpdateBankIdNumber_popup_HeaderText, Is.EqualTo("Update Bank ID Number"));
            Assert.That(UpdateBankIdNumbersuccessmessage, Is.EqualTo("Bank Id Number " + NewlyaddedBankIdNumber_Id + " Updated Successfully."));
            Assert.That(UpdatedBankIdNumberActualData, Is.EqualTo(updateBankIdNumberExpectedinput));

        }
        //download BankIdnumber file
        public void BankIdNumber_Export(string fileName)
        {
            Browser.Click(NewBankIdNumber_Export);
            Browser.Click(NewBankIdNumber_downloadCSV);
            Thread.Sleep(4000);
            bool fileStatus = Extensions.Verify_Downloaded_CSV_PDF_files_Clear(fileName);
            Assert.That(fileStatus, Is.True);
        }

        public void View_export_NewBankIdNumbers(string Search_Export_BankIdNumbersText)
        {
            string filename = "React App.csv";
            //create new BankIdnumber info record 
            Browser.Click(BankIdNumbers_AddNew_button);
            NewBankIdCreation_Popup_Textbox.SendKeys(Search_Export_BankIdNumbersText.ToString());
            var NewBankIdNumberTextbox_InputData = NewBankIdCreation_Popup_Textbox.GetDomAttribute("value");
            Browser.Click(NewBankIdNumber_Popup_Savebtn);

            //Scenario 1: Navigating to Bank ID Numbers homepage
            Thread.Sleep(4000);
            var Add_NewBankIdNumber_SuccessMessage = NewBankIdNumber_recordAdd_sucessmessage.Text;
            var NewlyaddedBankIdNumber_Id = AddedNewBankIdNumber_ID.Text;

            //Scenario 2: Bank ID Numbers homepage and default value for status
            NewBankIdCreation_Popup_Textbox.Clear();
            NewBankIdCreation_Popup_Textbox.SendKeys(NewlyaddedBankIdNumber_Id);
            var defaultstatus_bankid = defaultt_status_bankid.Text;
            ClientSettings_homepage_Fields(true);

            //Scenario 3: Exporting Bank Id Number Grid
            BankIdNumber_Export(filename);

            //search and view with newly created record details with valid Text
            NewBankIDNumber_AutoSearch_textbox.Clear();
            NewBankIDNumber_AutoSearch_textbox.SendKeys(NewBankIdNumberTextbox_InputData.ToString());
            var Added_NewBankIdNumber_record_details = NewBankIdNumber_created.Text;

            //search and view with newly created record details with Valid ID
            NewBankIDNumber_AutoSearch_textbox.Clear();
            NewBankIDNumber_AutoSearch_textbox.SendKeys(NewlyaddedBankIdNumber_Id.ToString());
            var Search_Valid_Id = AddedNewBankIdNumber_ID.Text;

            //search and view with Invalid Text details
            NewBankIDNumber_AutoSearch_textbox.Clear();
            NewBankIDNumber_AutoSearch_textbox.SendKeys(NewBankIdNumberTextbox_InputData + "@#$%^&*(HG");
            var Search_Invalid_Text = Search_View_InvalidRecordDetails.Text;

            //search and view with Invalid Id details
            NewBankIDNumber_AutoSearch_textbox.Clear();
            NewBankIDNumber_AutoSearch_textbox.SendKeys(Search_Valid_Id + "123478666");
            var Search_Invalid_Id = Search_View_InvalidRecordDetails.Text;

            //validations
            Assert.That(Add_NewBankIdNumber_SuccessMessage, Does.Contain("Bank Id Number " + NewlyaddedBankIdNumber_Id + " Added Successfully."));
            Assert.That(defaultstatus_bankid, Is.EqualTo("Active"));
            Assert.That(Search_Valid_Id, Is.EqualTo(NewlyaddedBankIdNumber_Id));
            Assert.That(Search_Invalid_Text, Does.Contain("No results found."));
            Assert.That(Search_Invalid_Text, Does.Contain("No results found."));
        }

        public void ValidationsNewBankIdNumbers(string NegativeScenariosText)
        {
            //create new dynamic info record
            Browser.Click(BankIdNumbers_AddNew_button);
            NewBankIdCreation_Popup_Textbox.SendKeys(NegativeScenariosText.ToString());
            var BankIdNumber_UserInputData = NewBankIdCreation_Popup_Textbox.GetDomAttribute("value");
            Browser.Click(NewBankIdNumber_Popup_Savebtn);
            Thread.Sleep(4000);
            var Add_NewBankIdNumber_SuccessMessage = NewBankIdNumber_recordAdd_sucessmessage.Text;
            var NewlyaddedBankIdNumber_Id = AddedNewBankIdNumber_ID.Text;

            //Scenario 1A: Bank ID Number field value is not entered
            Browser.Click(BankIdNumbers_AddNew_button);
            Browser.Click(NewBankIdNumber_Popup_Savebtn);
            Thread.Sleep(4000);
            var AddBankIdNumber_withoutText_ValidationMessage = NewBankIdNumber_popup_Addwithouttext_Error.Text;

            //Scenario 1B: Enters a Bank ID Number that already exists
            NewBankIdCreation_Popup_Textbox.Clear();
            NewBankIdCreation_Popup_Textbox.SendKeys(BankIdNumber_UserInputData);
            Browser.Click(NewBankIdNumber_Popup_Savebtn);
            Thread.Sleep(4000);
            var AddBankIdNumber_TextInput_dublicaterecord_ValidationMessage = NewBankIdNumber_Textinput_dublicaterecord_Error.Text;

            //Scenario 1C: Only numeric characters and character length from 6 to 10 is allowed
            NewBankIdCreation_Popup_Textbox.Clear();
            NewBankIdCreation_Popup_Textbox.SendKeys(NegativeScenariosText +"1234567");
            Browser.Click(NewBankIdNumber_Popup_Savebtn);
            var AddBankIdNumber_TextInput_ExceedLimit_ValidationMessage = NewBankIdNumber_Textinput_exceedcharlimit_error.Text;

            //Scenario 1D: Only numeric characters and gives invalid alphanumeric chars
            NewBankIdCreation_Popup_Textbox.Clear();
            NewBankIdCreation_Popup_Textbox.SendKeys(NegativeScenariosText + "abcdefghijk");
            Browser.Click(NewBankIdNumber_Popup_Savebtn);
            var AddBankIdNumber_TextInput_alphnumeric_ValidationMessage = NewBankIdNumber_Textinput_alphnumeric_error.Text;

            //Scenario 2: When disabling a Bank ID Number which is linked to a active/ Inactie Program
            NewBankIdCreation_Popup_Textbox.Clear();
            NewBankIdCreation_Popup_Textbox.SendKeys(NewlyaddedBankIdNumber_Id);
            Browser.Click(NewBankIdNumber_enable_disabled_statusbtn);
            var disabledpopupheadertext = NewBankIdNumber_disabled_popup_headertext.Text;
            var popupwarningmessage = NewBankIdNumber_disabled_popup_warningmessage.Text;
            var popupwarningbankidnumber = NewBankIdNumber_disabled_popup_warningmessage_bankid.Text;
            var popupfullwarningmessage = popupwarningmessage + popupwarningbankidnumber;
            Browser.Click(NewBankIdNumber_enable_disable_popup_Disabledbutton);
            //if the bankid number is linked with active/inactive it throws the error, this scenarios not works in app.
            var bankIdnumber_linked_active_inactive_errormessage = NewBankIdNumber_linked_active_inactive_error.Text;

            //Scenario 3: When character are more than 50 in Bin Name field
            NewBankIdCreation_Popup_Textbox.Clear();
            NewBankIdCreation_Popup_Textbox.SendKeys(NewlyaddedBankIdNumber_Id);
            Browser.Click(NewBankIdNumber_Edit_Icon_button);
            NewBankIdNumber_Edit_Binname_Textbox.SendKeys(NegativeScenariosText+"abdcdffghhhhhhhhsdfwfwefwffwefwefwsvfgfregffwfwefwfdwfwref");
            //unable to get the error message in app
            var ExceedBinnametextboxlimiterror = NewBankIdNumber_binnameTextinput_exceed_error.Text;

            //validations
            Assert.That(AddBankIdNumber_withoutText_ValidationMessage, Does.Contain("Bank ID Number is required."));
            Assert.That(AddBankIdNumber_TextInput_dublicaterecord_ValidationMessage, Does.Contain("Bank Id Number " + NewlyaddedBankIdNumber_Id + " already exists."));
            Assert.That(AddBankIdNumber_TextInput_ExceedLimit_ValidationMessage, Does.Contain("The Bank ID number must be 6 to 10 characters in length."));
            Assert.That(AddBankIdNumber_TextInput_alphnumeric_ValidationMessage, Does.Contain("Bank ID number must be a number."));
            Assert.That(ExceedBinnametextboxlimiterror, Does.Contain("Bin Name must not exceed 50 characters"));
            Assert.That(bankIdnumber_linked_active_inactive_errormessage, Does.Contain("BIN can only be disabled for Retired programs. BIN is associated with Active/Inactive program(s) id: <Active/Inactive programs the Bank ID number is associated with>"));
        }

    }
}

