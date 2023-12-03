using AdvanceSolutionpart1.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceSolutionpart1.Pages.Components.HomePageComponents.NavigationMenuComponent
{
    public class ManageListingComponent : CommonDriver
    {
        private IWebElement category;
        private IWebElement title;
        private IWebElement description;

        public void RenderManageListingElements()
        {
            try
            {
                Wait.WaitToBeVisible(driver, "Xpath", "//*[@class='ui striped table']//tr[1]//td[2]", 10);
                category = driver.FindElement(By.XPath("//*[@class='ui striped table']//tr[1]//td[2]"));
                title = driver.FindElement(By.XPath("//*[@class='ui striped table']//tr[1]//td[3]"));
                description = driver.FindElement(By.XPath("//*[@class='ui striped table']//tr[1]//td[4]"));

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public string ListCategory()
        {
            RenderManageListingElements();
            return category.Text;
        }
        public string ListTitle()
        {
            RenderManageListingElements();
            return title.Text;
        }

        public string ListDescription()
        {
            RenderManageListingElements();
            return description.Text;
        }


    }
}

