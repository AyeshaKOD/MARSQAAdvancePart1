using AdvanceSolutionpart1.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AdvanceSolutionpart1.Pages.Components.HomePageComponents.ProfileOverviewComponent
{
    public class LanguagesComponent : CommonDriver
    {

        private IWebElement addNewButton;
        private IWebElement addButton;
        private IWebElement languageTextBox;
        private IWebElement languageLevelDropdown;
        private IWebElement languageTab;
        private IWebElement popUpMessage;
        private IWebElement updateButton;
        private IWebElement editIcon;
        private IWebElement deleteIcon;
        private IWebElement closePopUpMessage;

        public void RenderLanguagesTab()
        {
            languageTab = driver.FindElement(By.XPath("//*[@class='item active' and text()='Languages']"));

        }

        public void GoToLanguagesTab()
        {
            RenderLanguagesTab();
            languageTab.Click();
        }


        public void RenderAddNewButton()
        {
            addNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));

        }

        public void RenderEditIcon()
        {
            editIcon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
        }

        public void RenderDeleteIcon()
        {
            deleteIcon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
        }

        public void RenderClosePopUp()
        {
            Wait.WaitToBeClickable(driver, "XPath", "//*[@class='ns-close']", 7);
            closePopUpMessage = driver.FindElement(By.XPath("//*[@class='ns-close']"));
        }

        public void ClosePopUp()
        {
            RenderClosePopUp();
            closePopUpMessage.Click();
        }
        public void RenderLanguageComponents()
        {
            addNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            languageTextBox = driver.FindElement(By.Name("name"));

            languageLevelDropdown = driver.FindElement(By.Name("level"));

        }

        public void RenderAddButton()
        {
            addButton = driver.FindElement(By.XPath("//*[@value ='Add']"));
        }

        public void RenderUpdateButton()
        {
            updateButton = driver.FindElement(By.XPath("//*[@value ='Update']"));
        }
        public void RenderPopUpMessage()
        {
            popUpMessage = driver.FindElement(By.XPath("//*[@class='ns-box-inner']"));
        }

        public void ResetLanguageTable()
        {
            int rowCount = driver.FindElements(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr")).Count;

            if (rowCount > 0)
            {
                for (int i = 0; i < rowCount; i++)
                {
                    driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i")).Click();
                    Thread.Sleep(1000);
                }
            }

            ClosePopUp();

        }

        public void AddLanguage(string languageName, string languageLevel)
        {

            RenderAddNewButton();
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div", 7);

            addNewButton.Click();
            Thread.Sleep(1000);

            RenderLanguageComponents();


            languageTextBox.SendKeys(languageName);

            SelectElement level = new SelectElement(languageLevelDropdown);

            level.SelectByValue(languageLevel);

            RenderAddButton();

            addButton.Click();

            Thread.Sleep(1000);

        }

        public string PopUpMessage()
        {
            RenderPopUpMessage();
            return popUpMessage.Text;
        }

        public void EditLanguage(string editLanguageName, string editLanguageLevel)
        {
            RenderEditIcon();
            editIcon.Click();
            RenderLanguageComponents();
            languageTextBox.Clear();
            languageTextBox.SendKeys(editLanguageName);
            SelectElement level = new SelectElement(languageLevelDropdown);
            level.SelectByValue(editLanguageLevel);
            RenderUpdateButton();
            updateButton.Click();
            Thread.Sleep(1000);

        }

        public void Delete()
        {
            RenderDeleteIcon();
            deleteIcon.Click();
            Thread.Sleep(1000);

        }
    }

}
