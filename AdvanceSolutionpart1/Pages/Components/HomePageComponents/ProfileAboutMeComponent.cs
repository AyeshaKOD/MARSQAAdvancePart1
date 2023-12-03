using AdvanceSolutionpart1.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceSolutionpart1.Pages.Components.HomePageComponents
{
    public class ProfileAboutMeComponent : CommonDriver
    {
        private IWebElement availabilityEditIcon;
        private IWebElement hoursEditIcon;
        private IWebElement earnTargetEditIcon;
        private IWebElement availabilityDropDown;
        private IWebElement hoursDropDown;
        private IWebElement earnTargetDropDown;
        private IWebElement availabilityType;
        private IWebElement numberOfHours;
        private IWebElement target;


        public void GetProfileAboutMeEditElements()
        {
            try
            {
                availabilityEditIcon = driver.FindElement(By.XPath("//*[@class ='ui list']/div[2]/div/span/i"));
                hoursEditIcon = driver.FindElement(By.XPath("//*[@class ='ui list']/div[3]/div/span/i"));
                earnTargetEditIcon = driver.FindElement(By.XPath("//*[@class ='ui list']/div[4]/div/span/i"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        public void GetProfileAboutMeElements()
        {
            try
            {
                availabilityType = driver.FindElement(By.XPath("//*[@class='ui list']/div[2]/div/span"));
                numberOfHours = driver.FindElement(By.XPath("//*[@class='ui list']/div[3]/div/span"));
                target = driver.FindElement(By.XPath("//*[@class='ui list']/div[4]/div/span"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public string GetAvailabilityType()
        {
            GetProfileAboutMeElements();
            return availabilityType.Text;
        }

        public string GetNumberOfHours()
        {
            GetProfileAboutMeElements();
            return numberOfHours.Text;

        }

        public string GetTarget()
        {
            GetProfileAboutMeElements();
            return target.Text;
        }







        public void GetProfileAboutMeDropDownElements()
        {
            try
            {
                availabilityDropDown = driver.FindElement(By.Name("availabiltyType"));
                hoursDropDown = driver.FindElement(By.Name("availabiltyHour"));
                earnTargetDropDown = driver.FindElement(By.Name("availabiltyTarget"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void UpdateProfileInfo(string availability, string hours, string earnTarget)
        {
            GetProfileAboutMeEditElements();
            availabilityEditIcon.Click();
            hoursEditIcon.Click();
            earnTargetEditIcon.Click();
            Thread.Sleep(1000);
            GetProfileAboutMeDropDownElements();
            availabilityDropDown.Click();
            SelectElement availablilityType = new SelectElement(availabilityDropDown);
            availablilityType.SelectByText(availability);
            hoursDropDown.Click();
            SelectElement availabilityHours = new SelectElement(hoursDropDown);
            availabilityHours.SelectByText(hours);
            earnTargetDropDown.Click();
            SelectElement availableEarnTarget = new SelectElement(earnTargetDropDown);
            availableEarnTarget.SelectByText(earnTarget);
            Thread.Sleep(1000);

        }
    }
}
