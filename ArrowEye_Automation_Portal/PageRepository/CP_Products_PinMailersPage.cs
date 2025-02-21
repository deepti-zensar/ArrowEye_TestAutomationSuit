using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;
using ArrowEye_Automation_Framework.Common;
using NUnit.Framework;
using OpenQA.Selenium;
using RandomString4Net;
using SeleniumExtras.PageObjects;

namespace ArrowEye_Automation_Portal.PageRepository
{
    public class CP_Products_PinMailersPage
    {
        [FindsBy(How = How.XPath, Using = "//h5[text()='Pin Mailer']")]
        public IWebElement PINMailersText;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='AddButton']")]
        public IWebElement addNewPINMailer;

        [FindsBy(How = How.XPath, Using = "//p[text()='Carrier artwork/base image']")]
        public IWebElement carrierArtworkLabel;

        [FindsBy(How = How.XPath, Using = "//*[@data-testid='InfoOutlinedIcon']")]
        public IWebElement infoIcon;

        [FindsBy(How = How.XPath, Using = "//div[@role='tooltip']/div")]
        public IWebElement infoIconText;

        [FindsBy(How = How.XPath, Using = "//input[@data-testid='dropInput']")]
        public IWebElement fileUpload;

        [FindsBy(How = How.XPath, Using = "//div[@data-testid='uploading']")]
        public IWebElement uploadingStatus;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='Remove']")]
        public IWebElement removePDFButton;

        [FindsBy(How = How.XPath, Using = "//p[text()='Carrier details']")]
        public IWebElement carrierDetailsLabel;

        [FindsBy(How = How.XPath, Using = "//input[@data-testid='Carriertitle']")]
        public IWebElement carrierTitleField;

        [FindsBy(How = How.XPath, Using = "//input[@data-testid='Carrierdescription']")]
        public IWebElement carrierDescField;

        [FindsBy(How = How.XPath, Using = "//legend[@id='partof']")]
        public IWebElement partOfLabel;

        [FindsBy(How = How.XPath, Using = "//label[@id='consumersite']//input")]
        public IWebElement consumerSiteCheckBox;

        [FindsBy(How = How.XPath, Using = "//label[@id='corporatesite']//input")]
        public IWebElement corporateSiteCheckBox;

        [FindsBy(How = How.XPath, Using = "//label[@id='carrier-status']")]
        public IWebElement carrierStatusLabel;

        [FindsBy(How = How.XPath, Using = "//label[@id='turnon']//input")]
        public IWebElement turnedOnRadio;

        [FindsBy(How = How.XPath, Using = "//label[@id='turnoff']//input")]
        public IWebElement turnedOffRadio;

        [FindsBy(How = How.XPath, Using = "//label[@id='colormode']")]
        public IWebElement colorModeLabel;

        [FindsBy(How = How.XPath, Using = "//label[@id='grayscale']//input")]
        public IWebElement grayScaleRadio;

        [FindsBy(How = How.XPath, Using = "//label[@id='color']//input")]
        public IWebElement colorRadio;

        [FindsBy(How = How.XPath, Using = "//div[@id='notistack-snackbar']")]
        private IWebElement toasterMessage;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='PinMailerSubmit']")]
        public IWebElement submitButton;

        [FindsBy(How = How.XPath, Using = "//button[@data-testidd='cancelPinMailer']")]
        public IWebElement cancelButton;

        [FindsBy(How = How.XPath, Using = "(//p[text()='ID:']/following-sibling::p/b)[1]")]
        public IWebElement firstID;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Search..']")]
        private IWebElement searchBox;

        [FindsBy(How = How.XPath, Using = "//*[@data-testid='EditIcon']")]
        private IWebElement editIcon;

        [FindsBy(How = How.XPath, Using = "//*[@data-testid='addEditComponent']/p")]
        private IWebElement editCarrierLabel;

        [FindsBy(How = How.XPath, Using = "//button[@data-testid='deleteIcon']")]
        private IWebElement deleteButton;

        public void ValidatePageTitle()
        {            
            Assert.That(PINMailersText.Displayed, Is.True);
            Assert.That(PINMailersText.Text, Is.EqualTo("Pin Mailer"));
        }

        public void selectPartOfOption(string partOf)
        {            
            switch (partOf)
            {
                case "Consumer site":
                    Browser.Click(consumerSiteCheckBox);
                    break;

                case "Corporate site":
                    Browser.Click(corporateSiteCheckBox);
                    break;

            }
        }

        public void selectCarrierStatusOption(string carrierStatus)
        {
            switch (carrierStatus)
            {
                case "Turned on":
                    Browser.Click(turnedOnRadio);
                    break;
                case "Turned off":
                    Browser.Click(turnedOffRadio);
                    break;
            }
        }

        public void selectColorModeOption(string colorMode)
        {
            switch (colorMode)
            {
                case "Grayscale":
                    Browser.Click(grayScaleRadio);
                    break;
                case "Color":
                    Browser.Click(colorRadio);
                    break;
            }
        }

        public string AddNewPINMailer(string carrierTitle, string desc, string partOf, string carrierStatus, string colorMode)
        {
            ValidatePageTitle();
            Browser.Click(addNewPINMailer);
            Browser.WaitForElement(carrierArtworkLabel, 10);
            //validate info icon and text
            Assert.That(infoIcon.Displayed, Is.True);
            Browser.Click(infoIcon);
            Browser.WaitForElement(infoIconText, 2);
            Assert.That(infoIconText.Text, Is.EqualTo("Only upload PDF file."));
            //Upload PDF
            fileUpload.SendKeys(@"C:\Users\aa65658\Downloads\2272.pdf");
            //Validate uploading status
            Browser.WaitForElement(uploadingStatus, 10);
            Assert.That(uploadingStatus.Displayed, Is.True);
            //Remove PDF and reupload
            Browser.WaitForElement(removePDFButton, 20);
            Browser.Click(removePDFButton);
            Thread.Sleep(2000);
            fileUpload.SendKeys(@"C:\Users\aa65658\Downloads\2272.pdf");
            Browser.WaitForElement(removePDFButton, 20);
            //Validate and provide carrier details
            Assert.That(carrierDetailsLabel.Displayed, Is.True);
            carrierTitleField.SendKeys(carrierTitle);
            carrierDescField.SendKeys(desc);
            //Select Part of, Carrier Status and Color Mode
            Assert.That(partOfLabel.Displayed, Is.True);
            selectPartOfOption(partOf);
            Assert.That(carrierStatusLabel.Displayed, Is.True);
            selectCarrierStatusOption(carrierStatus);
            Assert.That(colorModeLabel.Displayed, Is.True);
            selectColorModeOption(colorMode);
            //Submit
            Browser.Click(submitButton);
            //Get toaster message
            Browser.WaitForElement(toasterMessage, 10);
            var toasterMessage_Text = toasterMessage.Text;
            Console.WriteLine(toasterMessage_Text);
            var toasterMessageID = Regex.Match(toasterMessage_Text, @"\d+").Value;
            //Get latest ID
            Thread.Sleep(4000);
            Browser.WaitForElement(firstID, 10);
            var firstIDText = firstID.Text;
            //Validate Toaster message
            Assert.That(firstID.Text, Is.EqualTo(toasterMessageID));
            Assert.That(toasterMessage_Text, Is.EqualTo("Pin Mailer " + firstIDText + " Added Successfully."));
            return toasterMessageID;
        }

        public void EditPINMailer(string carrierTitle, string desc, string partOf, string carrierStatus, string colorMode, string newCarrierTitle, string newDesc, string newPartOf, string newCarrierStatus, string newColorMode)
        {
            ValidatePageTitle();
            string createdID = AddNewPINMailer(carrierTitle, desc, partOf, carrierStatus, colorMode);
            //Search and Edit
            DriverUtilities.clearText(searchBox);
            searchBox.SendKeys(createdID);
            Browser.WaitForElement(editIcon, 10);
            Browser.Click(editIcon);
            Browser.WaitForElement(editCarrierLabel, 10);
            Assert.That(editCarrierLabel.Text, Does.Contain(createdID));
            //Remove PDF and reupload
            Browser.Click(removePDFButton);
            Thread.Sleep(2000);
            fileUpload.SendKeys(@"C:\Users\aa65658\Downloads\2272.pdf");
            Browser.WaitForElement(removePDFButton, 20);
            //Validate and provide carrier details
            Assert.That(carrierDetailsLabel.Displayed, Is.True);
            DriverUtilities.clearText(carrierTitleField);            
            carrierTitleField.SendKeys(newCarrierTitle);
            DriverUtilities.clearText(carrierDescField);            
            carrierDescField.SendKeys(newDesc);
            //Select Part of, Carrier Status and Color Mode
            Assert.That(partOfLabel.Displayed, Is.True);
            selectPartOfOption(partOf);
            selectPartOfOption(newPartOf);
            Assert.That(carrierStatusLabel.Displayed, Is.True);                        
            selectCarrierStatusOption(newCarrierStatus);
            Assert.That(colorModeLabel.Displayed, Is.True);
            selectColorModeOption(newColorMode);
            //Submit
            Browser.Click(submitButton);
            //Get toaster message
            Browser.WaitForElement(toasterMessage, 10);
            var toasterMessage_Text = toasterMessage.Text;
            Console.WriteLine(toasterMessage_Text);
            var toasterMessageID = Regex.Match(toasterMessage_Text, @"\d+").Value;            
            //Validate Toaster message
            Assert.That(createdID, Is.EqualTo(toasterMessageID));
            Assert.That(toasterMessage_Text, Is.EqualTo("Pin Mailer " + createdID + " Updated Successfully."));
        }

        public void DeletePINMailer(string carrierTitle, string desc, string partOf, string carrierStatus, string colorMode)
        {
            ValidatePageTitle();
            string createdID = "1240";// AddNewPINMailer(carrierTitle, desc, partOf, carrierStatus, colorMode);
            //Search and Edit
            DriverUtilities.clearText(searchBox);
            searchBox.SendKeys(createdID);
            Browser.WaitForElement(editIcon, 10);
            Browser.Click(editIcon);
            Browser.WaitForElement(editCarrierLabel, 10);
            Assert.That(editCarrierLabel.Text, Does.Contain(createdID));
            //Delete
            if (!deleteButton.Enabled)
            {
                selectCarrierStatusOption("Turned off");
                Browser.Click(submitButton);
                Browser.WaitForElement(searchBox, 10);
                DriverUtilities.clearText(searchBox);
                searchBox.SendKeys(createdID);
                Thread.Sleep(2000);
                Browser.WaitForElement(editIcon, 10);
                Browser.Click(editIcon);
                Browser.WaitForElement(editCarrierLabel, 10);

            }
            Browser.Click(deleteButton);            
            //Get toaster message
            Browser.WaitForElement(toasterMessage, 10);
            var toasterMessage_Text = toasterMessage.Text;
            Console.WriteLine(toasterMessage_Text);
            var toasterMessageID = Regex.Match(toasterMessage_Text, @"\d+").Value;
            //Validate Toaster message
            Assert.That(createdID, Is.EqualTo(toasterMessageID));
            Assert.That(toasterMessage_Text, Is.EqualTo("Pin Mailer " + createdID + " Deleted Successfully."));
        }


    }
}
