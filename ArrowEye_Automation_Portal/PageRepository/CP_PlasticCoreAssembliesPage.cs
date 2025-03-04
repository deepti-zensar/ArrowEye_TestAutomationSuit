using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
using ArrowEye_Automation_Framework.Common;
using NUnit.Framework;
using ArrowEye_Automation_Framework;
using System.Threading;



namespace ArrowEye_Automation_Portal.PageRepository
{
    public class CP_PlasticCoreAssembliesPage : TestBase
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

       

        [FindsBy(How = How.XPath, Using = "//div[@class='jss13 MuiBox-root css-0']//p[contains(text(),'BOC Dynamic Info')]")]
        private IWebElement BOCDynamicInfoPage_HeaderText;

       

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Search…']")]
        private IWebElement NewBankIDNumber_AutoSearch_textbox;

       

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='openModal']//p[contains(text(),'Add New')]")]
        private IWebElement BankIdNumbers_AddNew_button;

       

       

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'New Bank ID Number')]")]
        private IWebElement NewBankIdNumber_Add_Popup_HeaderText;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='closeButton']")]
        private IWebElement NewBankIdNumber_Popup_Closebtn;

        [FindsBy(How = How.XPath, Using = "//input[@data-testid='bankIDNumber']")]
        private IWebElement NewBankIdCreation_Popup_Textbox;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='cancelBankID']")]
        private IWebElement NewBankIdNumber_Popup_Cancelbtn;

       

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='saveBankID']")]
        private IWebElement NewBankIdNumber_Popup_Savebtn;

       

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='2'])[position()=1]")]
        private IWebElement NewBankIdNumber_created;

       
        [FindsBy(How = How.XPath, Using = "//div[@class='go1888806478 notistack-MuiContent notistack-MuiContent-success go167266335 go1725278324 go3162094071']//div[@id='notistack-snackbar']")]
        private IWebElement NewBankIdNumber_recordAdd_sucessmessage;

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-cell MuiDataGrid-cell--textRight'])[position()=1]")]
        private IWebElement AddedNewBankIdNumber_ID;

       

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
        public void CreatePlasticCoreAssemblies(string CreateNewBankIdNumbers)
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

       



       

    }
}

