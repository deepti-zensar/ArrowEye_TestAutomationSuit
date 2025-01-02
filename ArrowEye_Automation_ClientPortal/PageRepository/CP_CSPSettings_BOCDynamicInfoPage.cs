
using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
using ArrowEye_Automation_Framework.Common;
using NUnit.Framework;
using ArrowEye_Automation_Framework;


namespace ArrowEye_ClientPortal_Automation.PageRepository
{
    public class CP_CSPSettings_BOCDynamicInfoPage :TestBase
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
        private IWebElement BOCDynamicInfo_AutoSearch_textbox;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='openModal']//p[contains(text(),'Add New')]")]
        private IWebElement BOCDynamicInfo_AddNew_button;

        [FindsBy(How = How.XPath, Using = "(//button[@data-testid='DeleteButton'])[position()=1]")]
        private IWebElement BOCDynamicInfo_Detete_Icon_button;

        [FindsBy(How = How.XPath, Using = "(//button[@data-testid='editIcon'])[position()=1]")]
        private IWebElement BOCDynamicInfo_Edit_Icon_button;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'New BOC Dynamic Info')]")]
        private IWebElement NewBocDynamicInfoPopup_HeaderText;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='closeButton']")]
        private IWebElement NewBocDynamicInfoPopup_Closebtn;

        [FindsBy(How = How.XPath, Using = "//input[@data-testid='nameInputField']")]
        private IWebElement NewBocDynamicInfoPopup_Textbox;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='cancelCSP']")]
        private IWebElement NewBocDynamicInfoPopup_Cancelbtn;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='saveCSP']")]
        private IWebElement NewBocDynamicInfoPopup_Savebtn;

        [FindsBy(How = How.XPath, Using = "//p[@id=':rkm:-helper-text' and contains(text(),'BOC Dynamic Text is required.')]")]
        private IWebElement NewBocDynamicInfoPopup_validationmessage;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='2'])[position()=1]")]
        private IWebElement BocDynamicInfo_created;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='2'])[position()=1]")]
        private IWebElement BocDynamicInfo_Updated;

        [FindsBy(How = How.XPath, Using = "//div[@id='notistack-snackbar' and contains(text(),'added successfully')]")]
        private IWebElement BocDynamicInfo_recordAdd_sucessmessage;

        [FindsBy(How = How.XPath, Using = "//div[@id='notistack-snackbar' and contains(text(),'updated successfully')]")]
        private IWebElement BocDynamicInfo_recordUpdate_sucessmessage;

        [FindsBy(How = How.XPath, Using = "//div[@id='notistack-snackbar' and contains(text(),'deleted successfully')]")]
        private IWebElement BocDynamicInfo_recordDelete_sucessmessage;

        public void ValidatePageTitle()
        {
            DriverUtil.IsElementPresent(BOCDynamicInfoPage_HeaderText);
        }

        public void ValidateNewIssuerDialogBox()
        {
            DriverUtil.IsElementPresent(NewBocDynamicInfoPopup_HeaderText);
        }

        public void AddNewBOCDynamicInfo(string BOCDynamicText)
        {
            Browser.Click(BOCDynamicInfo_AddNew_button);
            Browser.Click(NewBocDynamicInfoPopup_Cancelbtn);
            Thread.Sleep(2000);
            Browser.Click(BOCDynamicInfo_AddNew_button);
            Browser.Click(NewBocDynamicInfoPopup_Closebtn);
            Thread.Sleep(2000);
            Browser.Click(BOCDynamicInfo_AddNew_button);
            NewBocDynamicInfoPopup_Textbox.SendKeys(BOCDynamicText.ToString());
            Thread.Sleep(5000);
            var AddnewBOCInfoExpectedInputData = NewBocDynamicInfoPopup_Textbox.GetAttribute("value");
            Browser.Click(NewBocDynamicInfoPopup_Savebtn);
            Thread.Sleep(5000);
            BOCDynamicInfo_AutoSearch_textbox.SendKeys(BOCDynamicText.ToString());
            Thread.Sleep(3000);
            var CreatedNewBOCInfoActualData = BocDynamicInfo_created.Text;
            Assert.That(CreatedNewBOCInfoActualData, Is.EqualTo(AddnewBOCInfoExpectedInputData));
        }

        public void UpdateBOCDynamicInfo(string BOCDynamicText)
        {
            Browser.Click(BOCDynamicInfo_AddNew_button);
            NewBocDynamicInfoPopup_Textbox.SendKeys(BOCDynamicText.ToString());
            Thread.Sleep(5000);
            Browser.Click(NewBocDynamicInfoPopup_Savebtn);
            Thread.Sleep(7000);
            BOCDynamicInfo_AutoSearch_textbox.SendKeys(BOCDynamicText.ToString());
            Thread.Sleep(3000);
            Browser.Click(BOCDynamicInfo_Edit_Icon_button);
            NewBocDynamicInfoPopup_Textbox.SendKeys("_Updated");
            var updateBOCInfoExpectedUserData= NewBocDynamicInfoPopup_Textbox.GetAttribute("value");
            Browser.Click(NewBocDynamicInfoPopup_Savebtn);
            Thread.Sleep(7000);
            var UpdatedBocInfoActualData = BocDynamicInfo_Updated.Text;
            Assert.That(UpdatedBocInfoActualData, Is.EqualTo(updateBOCInfoExpectedUserData));
        }

    }
}

