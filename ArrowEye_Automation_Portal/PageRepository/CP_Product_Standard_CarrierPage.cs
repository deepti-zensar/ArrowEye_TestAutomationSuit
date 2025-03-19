using ArrowEye_Automation_Framework.Common;
using ArrowEye_Automation_Framework;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Threading;
using RandomString4Net;


namespace ArrowEye_Automation_Portal.PageRepository
{
    public class CP_Product_Standard_CarrierPage : TestBase
    {
        [FindsBy(How = How.XPath, Using = "//h5[contains(text(),' Standard Carriers')]")]
        public IWebElement StandardCarrierhomePageTitle;

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='nestedMenuItem']//p[contains(text(),'CSP Settings')]")]
        public IWebElement CSVSettings_menu;

        [FindsBy(How = How.XPath, Using = "//div[@class='MuiInputBase-root MuiInput-root MuiInput-underline MuiInputBase-colorPrimary MuiInputBase-formControl MuiInputBase-adornedStart css-jcincl']")]
        private IWebElement NewID_StandardCarrier_AutoSearch_textbox;


        [FindsBy(How = How.XPath, Using = "//button[@data-testid='AddButton']")]
        private IWebElement StandardCarrier_AddNew_button;

        [FindsBy(How = How.XPath, Using = "(//div[@data-testid='historyGrid'])[1]")]
        private IWebElement StandardCarrier_ViewHistory_button;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='closeHistory']")]
        private IWebElement ViewHistory_closebtn;

        [FindsBy(How = How.XPath, Using = "(//div[@data-testid='downloadIcon'])[1]")]
        private IWebElement StandardCarrier_Download_button;

        [FindsBy(How = How.XPath, Using = "(//div[@data-testid='letCarPrograms'])[1]")]
        private IWebElement SharedByPrograms;

        [FindsBy(How = How.XPath, Using = "//*[name()='svg' and @data-testid='closeButtonIcon']")]
        private IWebElement SharedByPrograms_closebtn;

        [FindsBy(How = How.XPath, Using = "//div[@data-testid='productsModal']")]
        private IWebElement Productsbtn;

        [FindsBy(How = How.XPath, Using = "//h2[@id='history-modal-title']")]
        private IWebElement Productspopup_headertext;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='closeHistory']")]
        private IWebElement Productspopup_closebtn;

        [FindsBy(How = How.XPath, Using = "//p[@class='MuiTypography-root MuiTypography-body1 jss1350 css-9l3uo3']")]
        private IWebElement Productspopup_titlemessage;

        [FindsBy(How = How.XPath, Using = "//div[@class='MuiDataGrid-columnHeaderTitle css-mh3zap']")]
        private IWebElement clinetproductmapid;

        [FindsBy(How = How.XPath, Using = "//div[@class='MuiDataGrid-virtualScrollerRenderZone css-1inm7gi']")]
        private IWebElement clinetproductmapidgrid;

        [FindsBy(How = How.XPath, Using = "//input[@data-testid='input-element']")]
        private IWebElement clinetproductmapidtextbox;

        [FindsBy(How = How.XPath, Using = "(//span[@data-testid='cellOne'])[1]")]
        private IWebElement clinetproductId;

        [FindsBy(How = How.XPath, Using = "//button[@data-testidd='cancelStdCar']")]
        private IWebElement StandardCarrier_Cancel_button;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Carrier details')]")]
        private IWebElement CarrierDetails_section_HeaderText;

        [FindsBy(How = How.XPath, Using = "//p[@class='MuiTypography-root MuiTypography-body1 jss2385 css-9l3uo3' and contains(text(),'Carrier preview')]")]
        private IWebElement CarrierPreview_section_headertext;

        [FindsBy(How = How.XPath, Using = "//p[@class='MuiTypography-root MuiTypography-body1 css-9l3uo3' and contains(text(),'Carrier artwork/base image')]")]
        private IWebElement Carrierartwork_baseimage;

        [FindsBy(How = How.XPath, Using = "//div[@data-testid='addEditComponent']")]
        private IWebElement Edit_Carrierar_Id;

        [FindsBy(How = How.XPath, Using = "//p[@id='history-modal-title']")]
        private IWebElement ViewHistory;

        [FindsBy(How = How.XPath, Using = "(//p[@class='MuiTypography-root MuiTypography-body2 jss1429 css-68o8xu'])[1]")]
        private IWebElement ID;

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-columnHeaderTitle css-mh3zap'])[1]")]
        private IWebElement ViewHistory_ID;

        [FindsBy(How = How.XPath, Using = "(//p[@class='MuiTypography-root MuiTypography-body2 jss1429 css-68o8xu'])[2]")]
        private IWebElement Version;

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-columnHeaderTitle css-mh3zap'])[2]")]
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

        [FindsBy(How = How.XPath, Using = "(//p[@class='MuiTypography-root MuiTypography-body2 jss1429 css-68o8xu'])[5]")]
        private IWebElement ProductMap;

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-columnHeaderTitle css-mh3zap'])[4]")]
        private IWebElement Text;

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-columnHeaderTitle css-mh3zap'])[5]")]
        private IWebElement User;

        [FindsBy(How = How.XPath, Using = "(//p[@class='MuiTypography-root MuiTypography-body2 jss1429 css-68o8xu'])[6]")]
        private IWebElement SaharedBy;

        [FindsBy(How = How.XPath, Using = "//h6[@id='modal-modal-title']")]
        private IWebElement SaharedProgramsText;

        [FindsBy(How = How.XPath, Using = "(//p[@data-testid='Label'])[1]")]
        private IWebElement MainCategories;

        [FindsBy(How = How.XPath, Using = "(//p[@data-testid='Label' and text()='New Category'])[1]")]
        private IWebElement NewCategory;

        [FindsBy(How = How.XPath, Using = "(//p[@data-testid='Label' and text()='New Category'])[2]")]
        private IWebElement NewchildCategory;

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='down']")]
        private IWebElement MoveDown;

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='default']")]
        private IWebElement MakeDefault;

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='add']")]
        private IWebElement AddNewSubCategory_option;

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='rename']")]
        private IWebElement RenameCategory;

        [FindsBy(How = How.XPath, Using = "(//p[@data-testid='Label'])[2]")]
        private IWebElement subCategories;

        [FindsBy(How = How.XPath, Using = "(//p[@data-testid='Label'])[3]")]
        private IWebElement secondsubCategories;

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='up']")]
        private IWebElement subCategories_MoveUp;

        [FindsBy(How = How.XPath, Using = "//h2[@id='child-modal-title']")]
        private IWebElement DeleteCategorylabeltext;

        [FindsBy(How = How.XPath, Using = "(//*[name()='svg' and @class='MuiSvgIcon-root'])[2]")]
        private IWebElement DeleteCategorypopupclosebtn;

        [FindsBy(How = How.XPath, Using = "//p[@id='child-modal-description']")]
        private IWebElement DeleteCategorypopupwarningmsg;

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='down']")]
        private IWebElement subCategories_MoveDown;

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='default']")]
        private IWebElement Categories_MakeDefault;

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='add']")]
        private IWebElement AddNew_subcategory;

        [FindsBy(How = How.XPath, Using = "//button[text()='Cancel']")]
        private IWebElement categorydeletepopup_cancel_btn;

        [FindsBy(How = How.XPath, Using = "//button[text()='Delete']")]
        private IWebElement categorydeletepopup_delete_btn;

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='rename']")]
        private IWebElement subCategories_Rename;

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='delete']")]
        private IWebElement subCategories_delete;

        [FindsBy(How = How.XPath, Using = "//li[@data-testid='turnoff']")]
        private IWebElement subCategories_turnoff;

        [FindsBy(How = How.XPath, Using = "(//p[@data-testid='Label'])[3]")]
        private IWebElement subchildCategories;

        [FindsBy(How = How.XPath, Using = "//p[@class='MuiTypography-root MuiTypography-body1 jss1051 css-9l3uo3']")]
        private IWebElement SaharedProgramsMessage;

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiDataGrid-columnHeaderTitle css-mh3zap'])[3]")]
        private IWebElement Date;


        [FindsBy(How = How.XPath, Using = "//*[name()='svg' and @data-testid='InfoOutlinedIcon']")]
        private IWebElement SatndardCarrier_fileupload_Tooltip;

        [FindsBy(How = How.XPath, Using = "//span[@class='MuiTypography-root MuiTypography-Body1 css-1rig6vh']")]
        private IWebElement FileType_accepts_dragarop_message;

        [FindsBy(How = How.XPath, Using = "//p[@class='MuiTypography-root MuiTypography-body1 css-u693l5']")]
        private IWebElement Filesize_accepts_message;

        [FindsBy(How = How.XPath, Using = "//input[@data-testid='Carriertitle']")]
        private IWebElement CarrierTitle_Textbox;

        [FindsBy(How = How.XPath, Using = "//input[@data-testid='Carrierdescription']")]
        private IWebElement CarrierDescription_Textbox;

        [FindsBy(How = How.XPath, Using = "//legend[@id='partof']")]
        private IWebElement Partof;

        [FindsBy(How = How.XPath, Using = "//label[@id='carrier-status']")]
        private IWebElement CarrierStatus;

        [FindsBy(How = How.XPath, Using = "//label[@id='colormode']")]
        private IWebElement Colormode;

        [FindsBy(How = How.XPath, Using = "//label[@id='afixlocation']")]
        private IWebElement Setaffixlocation;

        [FindsBy(How = How.XPath, Using = "//span[@data-testid='forConsumerOrder']")]
        private IWebElement partof_consumersite;

        [FindsBy(How = How.XPath, Using = "//span[@data-testid='forCorpOrder']")]
        private IWebElement partof_corporatesite;

        [FindsBy(How = How.XPath, Using = "(//*[name()='svg' and @data-testid='RadioButtonUncheckedIcon'])[1]")]
        private IWebElement Carrierstatus_turnedon;

        [FindsBy(How = How.XPath, Using = "(//*[name()='svg' and @data-testid='RadioButtonUncheckedIcon'])[2]")]
        private IWebElement Carrierstatus_turnedoff;

        [FindsBy(How = How.XPath, Using = "(//*[name()='svg' and @data-testid='RadioButtonUncheckedIcon'])[3]")]
        private IWebElement Colormode_Grayscale;

        [FindsBy(How = How.XPath, Using = "(//*[name()='svg' and @data-testid='RadioButtonUncheckedIcon'])[4]")]
        private IWebElement Colormode_color;

        [FindsBy(How = How.XPath, Using = "(//*[name()='svg' and @data-testid='RadioButtonUncheckedIcon'])[5]")]
        private IWebElement Setaffixlocation_Leftmiddle;

        [FindsBy(How = How.XPath, Using = "(//*[name()='svg' and @data-testid='RadioButtonUncheckedIcon'])[6]")]
        private IWebElement Setaffixlocation_Leftbottom;

        [FindsBy(How = How.XPath, Using = "(//*[name()='svg' and @data-testid='RadioButtonUncheckedIcon'])[7]")]
        private IWebElement Setaffixlocation_rightmiddle;

        [FindsBy(How = How.XPath, Using = "(//*[name()='svg' and @data-testid='RadioButtonUncheckedIcon'])[8]")]
        private IWebElement Setaffixlocation_rightbottom;

        [FindsBy(How = How.XPath, Using = "//p[@class='MuiTypography-root MuiTypography-body1 jss111 css-9l3uo3' and contains(text(),'Categories assignment')]")]
        private IWebElement CategoriesAssignments;

        [FindsBy(How = How.XPath, Using = "//p[@class='MuiTypography-root MuiTypography-body1 jss111 css-9l3uo3' and contains(text(),'Categories')]")]
        private IWebElement Categories;

        [FindsBy(How = How.XPath, Using = "//h5[@class='MuiTypography-root MuiTypography-h5 jss146 css-zq6grw' and contains(text(),'Assigned categories*')]")]
        private IWebElement AssignedCategories;

        [FindsBy(How = How.XPath, Using = "(//span[@data-testid='checkbox'])[1]")]
        private IWebElement select_check_Categories;

        [FindsBy(How = How.XPath, Using = "(//span[@data-testid='checkbox'])[2]")]
        private IWebElement select_check_Categories_child;

        [FindsBy(How = How.XPath, Using = "(//span[@class='MuiChip-label MuiChip-labelMedium css-11lqbxm'])[1]")]
        private IWebElement select_check_AssignedCategories;

        [FindsBy(How = How.XPath, Using = "(//span[@class='MuiChip-label MuiChip-labelMedium css-11lqbxm'])[2]")]
        private IWebElement select_check_child_AssignedCategories;

        [FindsBy(How = How.XPath, Using = "//p[@class='MuiTypography-root MuiTypography-body1 jss111 css-9l3uo3' and contains(text(),'Client Product Map')]")]
        private IWebElement ClientProductMap;

        [FindsBy(How = How.XPath, Using = "//input[@id='Client product map ID']")]
        private IWebElement ClientProductMapIDTextbox;

        [FindsBy(How = How.XPath, Using = "//button[@type='submit' and contains(text(),'Add')]")]
        private IWebElement ClientProductMapIDAddbutton;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='letStdSubmit']")]
        private IWebElement Update_standardCarreir_Sbmitbtn;

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiGrid-root MuiGrid-item css-1wxaqej'])[2]")]
        private IWebElement Addproductmapids;

        [FindsBy(How = How.XPath, Using = "(//*[name()='svg' and @data-testid='CancelIcon'])[2]")]
        private IWebElement RemoveProductId;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='letStdSubmit']")]
        private IWebElement Submit_StandardCarrier;

        [FindsBy(How = How.XPath, Using = "//p[@class='MuiTypography-root MuiTypography-body1 css-11jlrbr']")]
        private IWebElement Uploadfileerror;

        [FindsBy(How = How.XPath, Using = "//p[@id='Carrier title-helper-text']")]
        private IWebElement CarrierTitleerror;

        [FindsBy(How = How.XPath, Using = "//p[@class='MuiFormHelperText-root MuiFormHelperText-sizeMedium jss183 css-j7o63n']")]
        private IWebElement Partoferror;

        [FindsBy(How = How.XPath, Using = "(//p[@class='MuiFormHelperText-root jss183 css-j7o63n'])[1]")]
        private IWebElement CarrierStatuserror;

        [FindsBy(How = How.XPath, Using = "(//p[@class='MuiFormHelperText-root jss183 css-j7o63n'])[2]")]
        private IWebElement Colormodeerror;

        [FindsBy(How = How.XPath, Using = "(//p[@class='MuiFormHelperText-root jss183 css-j7o63n'])[3]")]
        private IWebElement Setaffixerror;

        [FindsBy(How = How.XPath, Using = "//p[@data-testid='noCategorySelected']")]
        private IWebElement Assignedcategorieserror;

        [FindsBy(How = How.XPath, Using = "//p[@class='MuiFormHelperText-root Mui-error css-j7o63n']']")]
        private IWebElement dublicateproductIderror;

        [FindsBy(How = How.XPath, Using = "//p[@class='MuiFormHelperText-root Mui-error css-j7o63n']")]
        private IWebElement ProductmapidlimitsExceedserror;

        [FindsBy(How = How.XPath, Using = "//button[@data-testidd='cancelStdCar']")]
        private IWebElement StandardCarrier_Cancelbutton;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='letStdSubmit']")]
        private IWebElement StandardCarrier_Submitbutton;

        [FindsBy(How = How.XPath, Using = "//p[@data-testid='secondNested']")]
        private IWebElement StandardCarrier_homepagelable;

        [FindsBy(How = How.XPath, Using = "//div[@class='MuiDataGrid-overlayWrapperInner css-0']//div[contains(text(),'No results found.')]")]
        private IWebElement Search_View_InvalidRecordDetails;

        [FindsBy(How = How.XPath, Using = "//p[@class='MuiTypography-root MuiTypography-body2 MuiTypography-noWrap jss1487 css-oucs7i']")]
        private IWebElement Created_StandardCarrier_name;

        [FindsBy(How = How.XPath, Using = "//p[@class='MuiTypography-root MuiTypography-body2 MuiTypography-noWrap jss510 css-oucs7i']")]
        private IWebElement Updated_StandardCarrier_name;

        [FindsBy(How = How.XPath, Using = "//div[@data-testid='editLetCarIcon']")]
        private IWebElement Edit_StandardCarrierdetails;

        [FindsBy(How = How.XPath, Using = "(//div[@data-colindex='2'])[position()=1]")]
        private IWebElement BankIdNumber_Updated;

        [FindsBy(How = How.XPath, Using = "//div[@class='go1888806478 notistack-MuiContent notistack-MuiContent-success go167266335 go1725278324 go3162094071']//div[@id='notistack-snackbar']")]
        private IWebElement StandardCarrier_recordAdd_sucessmessage;

        [FindsBy(How = How.XPath, Using = "//div[@class='go1888806478 notistack-MuiContent notistack-MuiContent-success go167266335 go1725278324 go3162094071']//div[@id='notistack-snackbar']")]
        private IWebElement StandardCarrier_recordUpdate_sucessmessage;

        [FindsBy(How = How.XPath, Using = "(//p[@class='MuiTypography-root MuiTypography-body2 css-1ndd0bs'])[position()=1]")]
        private IWebElement AddedNewStandardCarrier_ID;

        [FindsBy(How = How.XPath, Using = "(//p[@class='MuiTypography-root MuiTypography-body2 css-1ndd0bs'])[position()=1]")]
        private IWebElement Joblocator;


        [FindsBy(How = How.XPath, Using = "(//p[@class='MuiTypography-root MuiTypography-body2 css-1ndd0bs'])[position()=1]")]
        private IWebElement UpdatedNewStandardCarrier_ID;

        [FindsBy(How = How.XPath, Using = "(//p[@class='MuiTypography-root MuiTypography-body1 css-1cdulpx'])[position()=1]")]
        private IWebElement defaultt_status_bankid;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='Remove']")]
        public IWebElement RemovePDFbutton;

        [FindsBy(How = How.XPath, Using = "//*[name()='svg' and @data-testid='CloudUploadOutlinedIcon']")]
        public IWebElement FileUploadbtn;

        [FindsBy(How = How.XPath, Using = "//img[@data-testid='upload']")]
        public IWebElement SuccessFile;

        [FindsBy(How = How.XPath, Using = "//div[@data-testid='uploading']")]
        public IWebElement FileProgressbar;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='Cancel upload']")]
        public IWebElement CancelUploading;



        public void Verify_StandardCarrier_homepage_elements(bool fields)
        {
            if (fields != false)
            {
                Thread.Sleep(7000);
                if (CarrierPreview_section_headertext.Displayed && Carrierartwork_baseimage.Displayed
                    && SatndardCarrier_fileupload_Tooltip.Displayed && CarrierDetails_section_HeaderText.Displayed
                    && CarrierTitle_Textbox.Displayed && FileType_accepts_dragarop_message.Displayed
                    && Filesize_accepts_message.Displayed && CarrierDescription_Textbox.Displayed
                    && Partof.Displayed && partof_consumersite.Displayed && partof_corporatesite.Displayed
                    && Carrierstatus_turnedon.Displayed && Carrierstatus_turnedoff.Displayed
                    && Colormode_Grayscale.Displayed && Colormode_color.Displayed && Setaffixlocation_Leftmiddle.Displayed &&
                    Setaffixlocation_Leftbottom.Displayed && Setaffixlocation_rightmiddle.Displayed
                    && Setaffixlocation_rightbottom.Displayed
                    && CarrierStatus.Displayed && Colormode.Displayed
                    && Setaffixlocation.Displayed && CategoriesAssignments.Displayed && Categories.Displayed
                    && select_check_Categories.Displayed && select_check_AssignedCategories.Displayed
                    && ClientProductMap.Displayed && ClientProductMapIDTextbox.Displayed
                    && ClientProductMapIDAddbutton.Displayed && StandardCarrier_Cancelbutton.Displayed)

                {

                }
            }
            else
            {
                Browser.Close();
            }
        }

        public void Verify_Editable_StandardCarrier_Parameters(bool fields)
        {
            if (fields != false)
            {
                Thread.Sleep(7000);
                if (Edit_Carrierar_Id.Displayed && Carrierartwork_baseimage.Displayed
                    && CarrierTitle_Textbox.Displayed && CarrierDescription_Textbox.Displayed
                    && Partof.Displayed && partof_consumersite.Displayed && partof_corporatesite.Displayed
                    && Carrierstatus_turnedon.Displayed && Carrierstatus_turnedoff.Displayed
                    && Colormode_Grayscale.Displayed && Colormode_color.Displayed && Setaffixlocation_Leftmiddle.Displayed
                    && Setaffixlocation_Leftbottom.Displayed && Setaffixlocation_rightmiddle.Displayed
                    && Setaffixlocation_rightbottom.Displayed
                    && CarrierStatus.Displayed && Colormode.Displayed
                    && Setaffixlocation.Displayed && CategoriesAssignments.Displayed && Categories.Displayed
                    && select_check_Categories.Displayed && select_check_AssignedCategories.Displayed
                    && ClientProductMap.Displayed && ClientProductMapIDTextbox.Displayed
                    && ClientProductMapIDAddbutton.Displayed && StandardCarrier_Cancelbutton.Displayed)

                {

                }
            }
            else
            {
                Browser.Close();
            }
        }


        public void Verify_Carrier_Preview_Carrier_Details(bool fields)
        {
            if (fields != false)
            {
                Thread.Sleep(7000);
                if (SaharedBy.Displayed && ProductMap.Displayed
                    && LOC.Displayed && Name.Displayed
                    && Version.Displayed && ID.Displayed)

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
                    Date.Displayed && Text.Displayed && User.Displayed)

                {

                }
            }
            else
            {
                Browser.Close();
            }
        }



        public void View_ctegories_subcategories_CategoriesList(bool fields)
        {
            if (fields != false)
            {
                Thread.Sleep(7000);
                if (MainCategories.Displayed && subCategories.Displayed
                    && subchildCategories.Displayed)

                {

                }
            }
            else
            {
                Browser.Close();
            }
        }

        public void Verify_Maincategory_options(bool fields)
        {
            if (fields != false)
            {
                Thread.Sleep(7000);
                if (MoveDown.Displayed && MakeDefault.Displayed
                    && AddNewSubCategory_option.Displayed && RenameCategory.Displayed)

                {

                }
            }
            else
            {
                Browser.Close();
            }
        }


        public void Verify_Subcategory_options(bool fields)
        {
            if (fields != false)
            {
                Thread.Sleep(7000);
                if (subCategories_MoveUp.Displayed && subCategories_MoveDown.Displayed
                    && Categories_MakeDefault.Displayed && AddNew_subcategory.Displayed
                    && subCategories_Rename.Displayed && subCategories_delete.Displayed
                    && subCategories_turnoff.Displayed)

                {

                }
            }
            else
            {
                Browser.Close();
            }
        }

        public void Verify_delete_categorypopup_elements(bool fields)
        {
            if (fields != false)
            {
                Thread.Sleep(7000);
                if (DeleteCategorylabeltext.Displayed && DeleteCategorypopupclosebtn.Displayed
                    && DeleteCategorypopupwarningmsg.Displayed && categorydeletepopup_cancel_btn.Displayed &&
                    categorydeletepopup_delete_btn.Displayed)

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
                    && SahredByPopup_Id.Displayed &&
                    SahredByPopup_Version.Displayed && ProgramName.Displayed && Sharedby_Status.Displayed)

                {

                }
            }
            else
            {
                Browser.Close();
            }
        }

        public void Verify_ProductMap_popup_Details(bool fields)
        {
            if (fields != false)
            {
                Thread.Sleep(7000);
                if (Productspopup_headertext.Displayed && Productspopup_closebtn.Displayed
                    && Productspopup_titlemessage.Displayed && clinetproductmapidgrid.Displayed
                    && clinetproductmapid.Displayed && clinetproductmapidtextbox.Displayed && clinetproductId.Displayed)


                {

                }
            }
            else
            {
                Browser.Close();
            }
        }

        //download sharedbyprogram popup file
        public void SharedByProgram_StandardCarrier_Export(string fileName)
        {
            Browser.Click(ExportBtn);
            Thread.Sleep(4000);
            bool fileStatus = Extensions.Verify_Downloaded_CSV_PDF_files_Clear(fileName);
            Assert.That(fileStatus, Is.True);
        }

        //download standard Carrier uploaded file
        public void DownloadFile(string fileName)
        {
            Browser.Click(StandardCarrier_Download_button);
            Thread.Sleep(4000);
            bool fileStatus = Extensions.Verify_Downloaded_CSV_PDF_files_Clear(fileName);
            Assert.That(fileStatus, Is.True);
        }

        public void CreateStandardCarrier(string StandardCarrierCreates)
        {
            //create new standard Carrier record and verify the add new carrier elements details
            var homepage = StandardCarrierhomePageTitle.Displayed;
            Browser.Click(StandardCarrier_AddNew_button);
            Browser.Click(StandardCarrier_Cancel_button);
            Thread.Sleep(2000);
            Browser.Click(StandardCarrier_AddNew_button);
            Verify_StandardCarrier_homepage_elements(true);
            var CarrierPreviewheadertext = CarrierPreview_section_headertext.Text;
            var CarrierDetailsHeaderText = CarrierDetails_section_HeaderText.Text;
            var baseimageuploadheadertext = Carrierartwork_baseimage.Text;
            var FileuploadTooltip = SatndardCarrier_fileupload_Tooltip.GetDomAttribute("value");
            var FileTypeDragDropText = FileType_accepts_dragarop_message.Text;
            var FilesizeacceptText = Filesize_accepts_message.Text;
            Extensions.FileUpload(FileUploadbtn, "StandardCarrierDemofile", FileProgressbar, CancelUploading, SuccessFile, RemovePDFbutton);
            CarrierTitle_Textbox.SendKeys(StandardCarrierCreates.ToString());
            var input_carrierTitle = CarrierTitle_Textbox.GetDomAttribute("value");
            CarrierDescription_Textbox.SendKeys(StandardCarrierCreates + "1234");

            Browser.Click(partof_consumersite);
            Browser.Click(Carrierstatus_turnedoff);
            Browser.Click(Colormode_Grayscale);
            Browser.Click(Setaffixlocation_Leftmiddle);
            Browser.Click(select_check_Categories);
            Browser.Click(select_check_Categories_child);

            bool childcategories = select_check_child_AssignedCategories.Displayed;
            bool selectedcategories = select_check_AssignedCategories.Displayed;
            //remove subchildassigned categories
            Browser.Click(select_check_Categories_child);

            string randomnumber = RandomString.GetString(Types.NUMBERS, 5);
            ClientProductMapIDTextbox.SendKeys(randomnumber);
            Browser.Click(ClientProductMapIDAddbutton);
            bool addedproductIds = Addproductmapids.Displayed;
            //adding multiple productId
            ClientProductMapIDTextbox.SendKeys(randomnumber);
            Browser.Click(ClientProductMapIDAddbutton);
            //remove clientproductmapId
            Browser.Click(RemoveProductId);
            Browser.Click(Submit_StandardCarrier);
            Thread.Sleep(4000);
            var Add_StandardCarrier_SuccessMessage = StandardCarrier_recordAdd_sucessmessage.Text;
            var NewlyaddedStandardCarrier_Id = AddedNewStandardCarrier_ID.Text;

            //Search with newly created record
            NewID_StandardCarrier_AutoSearch_textbox.Clear();
            NewID_StandardCarrier_AutoSearch_textbox.SendKeys(NewlyaddedStandardCarrier_Id.ToString());
            var Output_Carriertitle = Created_StandardCarrier_name.Text;

            //Validations
            Assert.That(CarrierPreviewheadertext, Is.EqualTo("Carrier preview"));
            Assert.That(CarrierDetailsHeaderText, Is.EqualTo("Carrier details"));
            Assert.That(baseimageuploadheadertext, Is.EqualTo("Carrier artwork/base image"));
            Assert.That(FileuploadTooltip, Is.EqualTo("Only upload PDF file."));
            Assert.That(Add_StandardCarrier_SuccessMessage, Does.Contain("Standard Carrier " + NewlyaddedStandardCarrier_Id + " Added Successfully."));
            Assert.That(Output_Carriertitle, Does.Contain(input_carrierTitle));



        }

        public void EditStandardCarrier(string UpdateStandardCarrierdetails)
        {

            Browser.Click(StandardCarrier_AddNew_button);
            Extensions.FileUpload(FileUploadbtn, "StandardCarrierDemofile", FileProgressbar, CancelUploading, SuccessFile, RemovePDFbutton);
            CarrierTitle_Textbox.SendKeys(UpdateStandardCarrierdetails.ToString());
            var input_carrierTitle = CarrierTitle_Textbox.GetDomAttribute("value");
            CarrierDescription_Textbox.SendKeys(UpdateStandardCarrierdetails + "1234");
            Browser.Click(partof_consumersite);
            Browser.Click(Carrierstatus_turnedoff);
            Browser.Click(Colormode_Grayscale);
            Browser.Click(Setaffixlocation_Leftmiddle);
            Browser.Click(select_check_Categories);
            Browser.Click(select_check_Categories_child);
            //remove subchildassigned categories
            Browser.Click(select_check_Categories_child);
            string randomnumber = RandomString.GetString(Types.NUMBERS, 5);
            ClientProductMapIDTextbox.SendKeys(randomnumber);
            Browser.Click(ClientProductMapIDAddbutton);
            bool addedproductIds = Addproductmapids.Displayed;
            //adding multiple productId
            ClientProductMapIDTextbox.SendKeys(randomnumber);
            Browser.Click(ClientProductMapIDAddbutton);
            //remove clientproductmapId
            Browser.Click(RemoveProductId);
            Browser.Click(Submit_StandardCarrier);
            Thread.Sleep(4000);
            var Add_StandardCarrier_SuccessMessage = StandardCarrier_recordAdd_sucessmessage.Text;
            var NewlyaddedStandardCarrier_Id = AddedNewStandardCarrier_ID.Text;
            //Search with newly created record
            NewID_StandardCarrier_AutoSearch_textbox.Clear();
            NewID_StandardCarrier_AutoSearch_textbox.SendKeys(NewlyaddedStandardCarrier_Id.ToString());
            var Output_Carriertitle = Created_StandardCarrier_name.Text;

            //Edit button click
            Browser.Click(Edit_StandardCarrierdetails);
            //Editable Parameter
            Verify_Editable_StandardCarrier_Parameters(true);
            CarrierTitle_Textbox.SendKeys(UpdateStandardCarrierdetails + "Edit_StandardCarrier");
            var input_UpdatecarrierTitle = CarrierTitle_Textbox.GetDomAttribute("value");
            CarrierDescription_Textbox.SendKeys(UpdateStandardCarrierdetails + "Edit_StandardCarrier");
            Browser.Click(partof_corporatesite);
            Browser.Click(Colormode_color);
            Browser.Click(Setaffixlocation_rightmiddle);
            randomnumber = RandomString.GetString(Types.NUMBERS, 5);
            ClientProductMapIDTextbox.SendKeys(randomnumber);
            Browser.Click(ClientProductMapIDAddbutton);
            Thread.Sleep(3000);
            //submit btn
            Browser.Click(Update_standardCarreir_Sbmitbtn);
            Thread.Sleep(4000);
            var Update_StandardCarrier_SuccessMessage = StandardCarrier_recordUpdate_sucessmessage.Text;
            var UpdatedStandardCarrier_Id = AddedNewStandardCarrier_ID.Text;

            //Search with newly Updated record
            NewID_StandardCarrier_AutoSearch_textbox.Clear();
            NewID_StandardCarrier_AutoSearch_textbox.SendKeys(UpdatedStandardCarrier_Id.ToString());
            var Output_UpdatedCarriertitle = Updated_StandardCarrier_name.Text;

            //Validations

            Assert.That(Add_StandardCarrier_SuccessMessage, Does.Contain("Standard Carrier " + NewlyaddedStandardCarrier_Id + " Added Successfully."));
            Assert.That(Update_StandardCarrier_SuccessMessage, Does.Contain("Standard Carrier " + NewlyaddedStandardCarrier_Id + " Updated Successfully."));
            Assert.That(Output_UpdatedCarriertitle, Does.Contain(input_UpdatecarrierTitle));

        }


        public void Maintanence_StandardCarrier(string MaintanenceStandardCarrier)
        {
            //bug: CRP-7249
            //Note: create,moveup,movedown,make default,trrnoff,rename,delete categories are working after navigates from categories page to someother page and comeback to subcategory page.
            var homepage = StandardCarrierhomePageTitle.Displayed;
            View_ctegories_subcategories_CategoriesList(true);
            //Right click main category
            Browser.Element_RightClick(MainCategories);
            Verify_Maincategory_options(true);

            Browser.Element_RightClick(MainCategories);
            //click on addnewsubcategory option
            Browser.Click(AddNewSubCategory_option);
            Browser.Click(MainCategories);

            //Right click sub category
            Browser.Element_RightClick(subCategories);
            Verify_Subcategory_options(true);

            //click on newlyadded subcategory
            Browser.Element_RightClick(subCategories);

            //Rename category
            Browser.Click(RenameCategory);
            subCategories.SendKeys("AutomationTestCategory");
            var RenameInputs = subCategories.GetDomAttribute("value");

            //move down
            Browser.Element_RightClick(subCategories);
            Browser.Click(MoveDown);

            //move up
            Browser.Element_RightClick(subCategories);
            Browser.Click(subCategories_MoveUp);

            //Add subchaildcategory from sub category
            Browser.Element_RightClick(NewCategory);
            Browser.Click(AddNewSubCategory_option);
            Browser.Click(NewCategory);

            //delete subcategory
            Browser.Element_RightClick(NewchildCategory);
            Browser.Click(subCategories_delete);
            Verify_delete_categorypopup_elements(true);
            Browser.Click(categorydeletepopup_delete_btn);

            //Right click main category
            Browser.Element_RightClick(MainCategories);
            Browser.Click(AddNewSubCategory_option);
            Browser.Click(MainCategories);
            //right click on second sub category
            Browser.Element_RightClick(secondsubCategories);
            //make default
            Browser.Click(MakeDefault);

        }

        public void Validations_StandardCarrier(string NegativeScenariosText)
        {
            //All Validations errors
            Browser.Click(StandardCarrier_AddNew_button);
            Browser.Click(Submit_StandardCarrier);
            var fileuploaderror = Uploadfileerror.Text;
            var TitleError = CarrierTitleerror.Text;
            var partoferror = Partoferror.Text;
            var carrierstatuserror = CarrierStatuserror.Text;
            var colormodeerror = Colormodeerror.Text;
            var setaffixlocationerror = Setaffixerror.Text;
            var Assignedcategerror = Assignedcategorieserror.Text;
            var dublicateproductmapid = 123;
            ClientProductMapIDTextbox.SendKeys(dublicateproductmapid.ToString());
            Browser.Click(ClientProductMapIDAddbutton);
            var ProductIddublicateerror = dublicateproductIderror.Text;
            var exceedlimit = 12345645656565765456 + dublicateproductmapid.ToString();
            var ExeedlimitsofproductId = ProductmapidlimitsExceedserror.Text;
            bool submitbuttonelabled = Submit_StandardCarrier.Enabled;
            Browser.Click(StandardCarrier_Cancel_button);

            Browser.Click(StandardCarrier_AddNew_button);
            Extensions.FileUpload(FileUploadbtn, "StandardCarrierDemofile", FileProgressbar, CancelUploading, SuccessFile, RemovePDFbutton);
            CarrierTitle_Textbox.SendKeys(NegativeScenariosText.ToString());
            var input_carrierTitle = CarrierTitle_Textbox.GetDomAttribute("value");
            CarrierDescription_Textbox.SendKeys(NegativeScenariosText + "1234");
            Browser.Click(partof_consumersite);
            Browser.Click(Carrierstatus_turnedoff);
            Browser.Click(Colormode_Grayscale);
            Browser.Click(Setaffixlocation_Leftmiddle);
            Browser.Click(select_check_Categories);
            Browser.Click(select_check_Categories_child);
            //remove subchildassigned categories
            Browser.Click(select_check_Categories_child);
            string randomnumber = RandomString.GetString(Types.NUMBERS, 5);
            ClientProductMapIDTextbox.SendKeys(randomnumber);
            Browser.Click(ClientProductMapIDAddbutton);
            bool addedproductIds = Addproductmapids.Displayed;
            //adding multiple productId
            ClientProductMapIDTextbox.SendKeys(randomnumber);
            Browser.Click(ClientProductMapIDAddbutton);
            //remove clientproductmapId
            Browser.Click(RemoveProductId);
            Browser.Click(Submit_StandardCarrier);
            Thread.Sleep(4000);
            var Add_StandardCarrier_SuccessMessage = StandardCarrier_recordAdd_sucessmessage.Text;
            var NewlyaddedStandardCarrier_Id = AddedNewStandardCarrier_ID.Text;

            //Search with newly Updated record
            NewID_StandardCarrier_AutoSearch_textbox.Clear();
            NewID_StandardCarrier_AutoSearch_textbox.SendKeys(NewlyaddedStandardCarrier_Id.ToString());

            //Edit button click
            Browser.Click(Edit_StandardCarrierdetails);
            //turn on status
            Browser.Click(Carrierstatus_turnedon);
            Browser.Click(Submit_StandardCarrier);
            Thread.Sleep(6000);

            //Search with newly Updated record
            NewID_StandardCarrier_AutoSearch_textbox.Clear();
            NewID_StandardCarrier_AutoSearch_textbox.SendKeys(NewlyaddedStandardCarrier_Id.ToString());

            //Scenario1: Viewing the Standard carrier Previews & Carrier details
            Verify_Carrier_Preview_Carrier_Details(true);
            //Scenario 2: Viewing the History of Standard carriers
            Browser.Click(StandardCarrier_ViewHistory_button);
            Verify_ViewHistoryPopup_Parameters(true);
            Browser.Click(ViewHistory_closebtn);

            //Scenario 3: Downloading the Standard Carrier
            Browser.Click(StandardCarrier_Download_button);
            //Note: download not works in app
            DownloadFile("StandardCarrierDemofile");

            //Scenario 4: Viewing and Exporting Shared By: Programs
            Browser.Click(Edit_StandardCarrierdetails);
            //carrier status turned on
            Browser.Click(Carrierstatus_turnedon);
            Browser.Click(Update_standardCarreir_Sbmitbtn);
            Thread.Sleep(6000);
            Browser.Click(SharedByPrograms);
            Verify_SharedByPrograms_popup_Details(true);
            SharedByProgram_StandardCarrier_Export("data.csv");
            Browser.Click(SharedByPrograms_closebtn);
            //Scenario 5: Viewing Client Product Map
            Browser.Click(Productsbtn);
            Verify_ProductMap_popup_Details(true);
            var mapid = clinetproductId.GetDomAttribute("value");
            clinetproductmapidtextbox.Clear();
            clinetproductmapidtextbox.SendKeys(mapid);
            Productspopup_closebtn.Click();


        }

    }
}

