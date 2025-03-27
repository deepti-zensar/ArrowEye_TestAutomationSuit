using System;
using System.Collections.Generic;
using System.Threading;
using ArrowEye_Automation_Framework.Common;
using NUnit.Framework;
using OpenQA.Selenium;
using RandomString4Net;
using SeleniumExtras.PageObjects;

namespace ArrowEye_Automation_Portal.PageRepository
{
    public class CP_ClientInformationPage
    {
        [FindsBy(How = How.XPath, Using = "(//div[@id='root']//p[text()='Client Information'])[2]")]
        public IWebElement clientInfoText;

        [FindsBy(How = How.XPath, Using = "//div[@id='panel1bh-header']//p[text()='Client Information']")]
        public IWebElement clientInfoLabel;

        [FindsBy(How = How.XPath, Using = "//div[@id='panel1bh-header']//*[@data-testid='AddCircleIcon']")]
        public IWebElement clientInfoExpand;

        [FindsBy(How = How.XPath, Using = "//div[@id='panel1bh-header']//*[@data-testid='RemoveCircleIcon']")]
        public IWebElement clientInfoCollapse;

        [FindsBy(How = How.XPath, Using = "//label[text()='Client ID']")]
        public IWebElement clientIDLabel;

        [FindsBy(How = How.XPath, Using = "//label[text()='Client ID']/following-sibling::p")]
        public IWebElement clientIDData;

        [FindsBy(How = How.XPath, Using = "//label[text()='Name']")]
        public IWebElement nameLabel;

        [FindsBy(How = How.XPath, Using = "//label[text()='Name']/following-sibling::p")]
        public IWebElement nameData;

        [FindsBy(How = How.XPath, Using = "//label[text()='Description']")]
        public IWebElement descLabel;

        [FindsBy(How = How.XPath, Using = "//label[text()='Description']/following-sibling::p")]
        public IWebElement descData;

        [FindsBy(How = How.XPath, Using = "//div[@id='panel2bh-header']//p")]
        public IWebElement contactInfoLabel;

        [FindsBy(How = How.XPath, Using = "//div[@id='panel2bh-header']//*[@data-testid='AddCircleIcon']")]
        public IWebElement contactInfoExpand;

        [FindsBy(How = How.XPath, Using = "//div[@id='panel2bh-header']//*[@data-testid='RemoveCircleIcon']")]
        public IWebElement contactInfoCollapse;

        [FindsBy(How = How.XPath, Using = "//div[@id='panel2bh-content']//label[text()='Name']")]
        public IWebElement contactInfoNameLabel;

        [FindsBy(How = How.XPath, Using = "//div[@id='panel2bh-content']//label[text()='Name']/following-sibling::p")]
        public IWebElement contactInfoNameData;

        [FindsBy(How = How.XPath, Using = "//div[@id='panel2bh-content']//label[text()='Email']")]
        public IWebElement contactInfoEmailLabel;

        [FindsBy(How = How.XPath, Using = "//div[@id='panel2bh-content']//label[text()='Email']/following-sibling::p")]
        public IWebElement contactInfoEmailData;

        [FindsBy(How = How.XPath, Using = "//div[@id='panel2bh-content']//label[text()='Mobile No.']")]
        public IWebElement contactInfoMobileLabel;

        [FindsBy(How = How.XPath, Using = "//div[@id='panel2bh-content']//label[text()='Mobile No.']/following-sibling::p")]
        public IWebElement contactInfoMobileData;

        [FindsBy(How = How.XPath, Using = "//div[@id='panel2-0bh-header']//p")]
        public IWebElement addressLabel;

        [FindsBy(How = How.XPath, Using = "//div[@id='panel2-0bh-header']//*[@data-testid='AddCircleIcon']")]
        public IWebElement addressExpand;

        [FindsBy(How = How.XPath, Using = "//div[@id='panel2-0bh-header']//*[@data-testid='RemoveCircleIcon']")]
        public IWebElement addressCollapse;

        [FindsBy(How = How.XPath, Using = "//div[@id='panel2-0bh-content']//label[text()='Street 1']")]
        public IWebElement street1Label;

        [FindsBy(How = How.XPath, Using = "//div[@id='panel2-0bh-content']//label[text()='Street 1']/following-sibling::p")]
        public IWebElement street1Data;

        [FindsBy(How = How.XPath, Using = "//div[@id='panel2-0bh-content']//label[text()='Street 2']")]
        public IWebElement street2Label;

        [FindsBy(How = How.XPath, Using = "//div[@id='panel2-0bh-content']//label[text()='Street 2']/following-sibling::p")]
        public IWebElement street2Data;

        [FindsBy(How = How.XPath, Using = "//div[@id='panel2-0bh-content']//label[text()='City']")]
        public IWebElement cityLabel;

        [FindsBy(How = How.XPath, Using = "//div[@id='panel2-0bh-content']//label[text()='City']/following-sibling::p")]
        public IWebElement cityData;

        [FindsBy(How = How.XPath, Using = "//div[@id='panel2-0bh-content']//label[text()='Zip']")]
        public IWebElement zipLabel;

        [FindsBy(How = How.XPath, Using = "//div[@id='panel2-0bh-content']//label[text()='Zip']/following-sibling::p")]
        public IWebElement zipData;

        [FindsBy(How = How.XPath, Using = "//div[@id='panel2-0bh-content']//label[text()='State']")]
        public IWebElement stateLabel;

        [FindsBy(How = How.XPath, Using = "//div[@id='panel2-0bh-content']//label[text()='State']/following-sibling::p")]
        public IWebElement stateData;

        [FindsBy(How = How.XPath, Using = "//div[@id='panel2-0bh-content']//label[text()='Country']")]
        public IWebElement countryLabel;

        [FindsBy(How = How.XPath, Using = "//div[@id='panel2-0bh-content']//label[text()='Country']/following-sibling::p")]
        public IWebElement countryData;

        public void ValidatePageTitle()
        {
            Browser.WaitForElement(clientInfoText, 10);
            Assert.That(clientInfoText.Displayed, Is.True);
            Assert.That(clientInfoText.Text, Is.EqualTo("Client Information"));
        }

        public void ValidateClientInformation_Homepage()
        {
            ValidatePageTitle();            
            Assert.That(clientInfoLabel.Displayed, Is.True);
            Assert.That(clientInfoExpand.Displayed, Is.True);
            Browser.Click(clientInfoExpand);
            Browser.WaitForElement(clientInfoCollapse,10);
            Thread.Sleep(2000);
            Assert.That(clientIDLabel.Displayed, Is.True);
            Assert.That(clientIDData.Displayed, Is.True);
            Assert.That(nameLabel.Displayed, Is.True);
            Assert.That(nameData.Displayed, Is.True);
            Assert.That(descLabel.Displayed, Is.True);
            Assert.That(descData.Displayed, Is.True);
            Assert.That(contactInfoLabel.Displayed, Is.True);
            Assert.That(contactInfoExpand.Displayed, Is.True);
            Browser.Click(contactInfoExpand);
            Browser.WaitForElement(contactInfoCollapse, 10);
            Thread.Sleep(2000);
            Assert.That(contactInfoNameLabel.Displayed, Is.True);
            Assert.That(contactInfoNameData.Displayed, Is.True);
            Assert.That(contactInfoEmailLabel.Displayed, Is.True);
            Assert.That(contactInfoEmailData.Displayed, Is.True);
            Assert.That(contactInfoMobileLabel.Displayed, Is.True);            
            Assert.That(addressLabel.Displayed, Is.True);
            Assert.That(addressExpand.Displayed, Is.True);
            Browser.Click(addressExpand);
            Browser.WaitForElement(addressCollapse, 10);
            Thread.Sleep(2000);
            Assert.That(street1Label.Displayed, Is.True);
            Assert.That(street1Data.Displayed, Is.True);
            Assert.That(street2Label.Displayed, Is.True);
            Assert.That(street2Data.Displayed, Is.True);
            Assert.That(cityLabel.Displayed, Is.True);
            Assert.That(cityData.Displayed, Is.True);
            Assert.That(zipLabel.Displayed, Is.True);
            Assert.That(zipData.Displayed, Is.True);
            Assert.That(stateLabel.Displayed, Is.True);
            Assert.That(stateData.Displayed, Is.True);
            Assert.That(countryLabel.Displayed, Is.True);
            Assert.That(countryData.Displayed, Is.True);
        }
    }        
}
