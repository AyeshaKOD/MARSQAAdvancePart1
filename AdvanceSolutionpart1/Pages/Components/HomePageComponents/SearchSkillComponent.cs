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
    public class SearchSkillComponent : CommonDriver
    {

        private IWebElement searchSkillIcon;
        private IWebElement categoryName;
        private IWebElement subCategoryName;
        private IWebElement onlineFilter;
        private IWebElement onsiteFilter;
        private IWebElement showAllFilter;
        private IWebElement lastPageNumber;
        private IWebElement sharedTitle;



        public void RenderSearchSkillIcon()
        {
            try
            {

                searchSkillIcon = driver.FindElement(By.XPath("//*[@class='search link icon']"));

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void RenderFilters()
        {
            onlineFilter = driver.FindElement(By.XPath("//*[contains(text(),'Online')]"));
            onsiteFilter = driver.FindElement(By.XPath("//*[contains(text(),'Onsite')]"));
            showAllFilter = driver.FindElement(By.XPath("//*[contains(text(),'ShowAll')]"));
        }


        public void SearchByAllCategory(string category, string subCategory)
        {
            RenderSearchSkillIcon();
            searchSkillIcon.Click();
            Thread.Sleep(2000);
            categoryName = driver.FindElement(By.LinkText(category));
            categoryName.Click();
            Thread.Sleep(2000);
            subCategoryName = driver.FindElement(By.LinkText(subCategory));
            subCategoryName.Click();

        }

        public void SearchByFilter(string filterName)
        {
            RenderSearchSkillIcon();
            searchSkillIcon.Click();
            RenderFilters();
            if (filterName == "Online")
            {
                onlineFilter.Click();
            }

            if (filterName == "On-site")
            {
                onsiteFilter.Click();
            }

            if (filterName == "ShowAll")
            {
                showAllFilter.Click();
            }

            Thread.Sleep(2000);
        }

        public void RenderLastPageNumber()
        {
            try
            {
                Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[2]/div/div[3]/div[2]/div/button[last()-1]", 5);
                lastPageNumber = driver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[2]/div/div[3]/div[2]/div/button[last()-1]"));
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void GoToLastPage()
        {
            RenderLastPageNumber();
            lastPageNumber.Click();
            Thread.Sleep(2000);
        }

        public void RenderSharedTitle()
        {
            try
            {
                Wait.WaitToBeVisible(driver, "XPath", "//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[2]/div/div[2]/div/div/div[last()]/div[1]/a[2]/p", 5);
                sharedTitle = driver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[2]/div/div[2]/div/div/div[last()]/div[1]/a[2]/p"));
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public string SharedSkillTitle()
        {
            RenderSharedTitle();
            return sharedTitle.Text;
        }
    }



}
