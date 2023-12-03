using AdvanceSolutionpart1.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceSolutionpart1.Pages.Components.HomePageComponents
{
    public class ShareSkillComponent : CommonDriver
    {
        private IWebElement title;
        private IWebElement description;
        private IWebElement category;
        private IWebElement subCategory;
        private IWebElement tags;
        private IWebElement serviceTypeHourlyBasis;
        private IWebElement serviceTypeOneOff;
        private IWebElement locationTypeOnsite;
        private IWebElement locationTypeOnline;
        private IWebElement startDate;
        private IWebElement endDate;
        private IWebElement skillTradeSkillExchange;
        private IWebElement skillTradeCredit;
        private IWebElement skillExchange;
        private IWebElement credit;
        private IWebElement activeStatus;
        private IWebElement hiddenStatus;
        private IWebElement saveButton;
        private IWebElement messageWindow;
        private IWebElement shareSkillButton;


        public void RenderShareSkillButton()
        {
            try
            {
                shareSkillButton = driver.FindElement(By.XPath("//*[contains(text(),'Share Skill')]"));
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void RenderShareSkillElements()
        {
            try
            {
                title = driver.FindElement(By.Name("title"));
                description = driver.FindElement(By.Name("description"));
                category = driver.FindElement(By.Name("categoryId"));
                tags = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));
                serviceTypeHourlyBasis = driver.FindElement(By.XPath("//input[@name='serviceType' and @value ='0']"));
                serviceTypeOneOff = driver.FindElement(By.XPath("//input[@name='serviceType' and @value ='1']"));
                locationTypeOnsite = driver.FindElement(By.XPath("//input[@name='locationType' and @value ='0']"));
                locationTypeOnline = driver.FindElement(By.XPath("//input[@name='locationType' and @value ='1']"));
                startDate = driver.FindElement(By.XPath("//*[@placeholder='Start date']"));
                endDate = driver.FindElement(By.XPath("//*[@placeholder='End date']"));
                skillTradeSkillExchange = driver.FindElement(By.XPath("//input[@name='skillTrades' and @value ='true']"));
                skillTradeCredit = driver.FindElement(By.XPath("//input[@name='skillTrades' and @value ='false']"));
                skillExchange = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input"));
                activeStatus = driver.FindElement(By.XPath("//input[@name='isActive' and @value ='true']"));
                hiddenStatus = driver.FindElement(By.XPath("//input[@name='isActive' and @value ='false']"));
                saveButton = driver.FindElement(By.XPath("//*[@value='Save']"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void CreateShareSkill(string addTitle, string addDesc, string addCategory, string addSubCategory,
            string addTag, string addServiceType, string addLocationType, string addStartDate, string addEndDate, string addSkillTrade,
            string addSkillExchange, string addAmount, string addActiveStatus)
        {
            RenderShareSkillButton();
            shareSkillButton.Click();
            Thread.Sleep(3000);
            RenderShareSkillElements();
            title.SendKeys(addTitle);
            description.SendKeys(addDesc);
            SelectElement newCategory = new SelectElement(category);
            newCategory.SelectByText(addCategory);
            Thread.Sleep(1000);
            subCategory = driver.FindElement(By.Name("subcategoryId"));
            SelectElement newSubCategory = new SelectElement(subCategory);
            newSubCategory.SelectByText(addSubCategory);
            tags.SendKeys(addTag);
            tags.SendKeys(Keys.Enter);


            if (addServiceType == "Hourly basis service")
            {
                serviceTypeHourlyBasis.Click();
            }
            else
            {
                serviceTypeOneOff.Click();
            }

            if (addLocationType == "On-site")
            {
                locationTypeOnsite.Click();
            }
            else
            {
                locationTypeOnline.Click();
            }

            startDate.Clear();
            startDate.SendKeys(addStartDate);
            endDate.SendKeys(addEndDate);
            if (addSkillTrade == "Skill-exchange")
            {
                skillTradeSkillExchange.Click();
                skillExchange.SendKeys(addSkillExchange);
                skillExchange.SendKeys(Keys.Enter);
            }
            else
            {
                skillTradeCredit.Click();
                credit = driver.FindElement(By.XPath("//*[@placeholder='Amount']"));
                credit.SendKeys(addAmount);
            }

            if (addActiveStatus == "Active")
            {
                activeStatus.Click();
            }
            else
            {
                hiddenStatus.Click();
            }
            saveButton.Click();
            Thread.Sleep(1000);


        }

        public string RenderShareSkillPopUpMessage()
        {

            messageWindow = driver.FindElement(By.XPath("//*[@class='ns-box-inner']"));
            return messageWindow.Text;

        }
    }

}
