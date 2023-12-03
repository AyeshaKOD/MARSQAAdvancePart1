using AventStack.ExtentReports;
using AventStack.ExtentReports.Utils;
using AdvanceSolutionpart1.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceSolutionpart1.Pages.Components.HomePageComponents.AccountMenuComponent
{
    public class NotificationsComponent : CommonDriver
    {

        private IWebElement notificationDropDown;
        private IWebElement seeAllLink;
        private IWebElement loadMoreLink;
        private IWebElement showLessLink;
        private IWebElement notificationCheckBox;
        private IWebElement notificationDeleteIcon;
        private IWebElement notificationMarkAsRead;
        private IWebElement popUpMessage;
        private IWebElement selectAllIcon;
        private IWebElement unSelectAllIcon;

        public void RenderNotificationDropDown()
        {
            try
            {
                Wait.WaitToBeClickable(driver, "XPath", "//*[@class = 'ui top left pointing dropdown item']//i[2]", 5);
                notificationDropDown = driver.FindElement(By.XPath("//*[@class = 'ui top left pointing dropdown item']//i[2]"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }


        public void RenderSeeAllNotificationLink()
        {
            try
            {
                Wait.WaitToBeVisible(driver, "XPath", "//*[contains(text(),'See All...')]", 5);
                seeAllLink = driver.FindElement(By.XPath("//*[contains(text(),'See All...')]"));
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void RenderNotificationCheckbox()
        {
            try
            {
                Wait.WaitToBeClickable(driver, "Xpath", "//input[@type='checkbox' and @value='0']", 5);
                notificationCheckBox = driver.FindElement(By.XPath("//input[@type='checkbox' and @value='0']"));
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void RenderNotificationDeleteIcon()
        {
            try
            {
                Wait.WaitToBeVisible(driver, "XPath", "//*[@data-tooltip='Delete selection']", 5);
                notificationDeleteIcon = driver.FindElement(By.XPath("//*[@data-tooltip='Delete selection']"));

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void RenderMarkAsReadNotificationIcon()
        {
            try
            {
                Wait.WaitToBeVisible(driver, "XPath", "//*[@data-tooltip='Mark selection as read']", 5);
                notificationMarkAsRead = driver.FindElement(By.XPath("//*[@data-tooltip='Mark selection as read']"));

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void RenderSelectAllIcon()
        {
            try
            {
                Wait.WaitToBeVisible(driver, "XPath", "//*[@data-tooltip='Select all']", 5);
                selectAllIcon = driver.FindElement(By.XPath("//*[@data-tooltip='Select all']"));
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void RenderUnSelectAllIcon()
        {
            try
            {
                Wait.WaitToBeVisible(driver, "XPath", "//*[@data-tooltip='Unselect all']", 5);
                unSelectAllIcon = driver.FindElement(By.XPath("//*[@data-tooltip='Unselect all']"));
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        public string RenderPopUpMessage()
        {
            Wait.WaitToBeVisible(driver, "XPath", "//*[@class='ns-box-inner']", 5);
            popUpMessage = driver.FindElement(By.XPath("//*[@class='ns-box-inner']"));
            return popUpMessage.Text;
        }
        public void DeleteSelectedNotification()
        {
            RenderNotificationCheckbox();
            notificationCheckBox.Click();
            RenderNotificationDeleteIcon();
            notificationDeleteIcon.Click();
        }

        public void SelectAllNotification()
        {
            RenderSelectAllIcon();
            selectAllIcon.Click();

        }

        public void UnSelectAllNotification()
        {
            SelectAllNotification();
            RenderUnSelectAllIcon();
            unSelectAllIcon.Click();

        }
        public void MarkSelectedNotificationASRead()
        {
            RenderNotificationCheckbox();
            notificationCheckBox.Click();
            RenderMarkAsReadNotificationIcon();
            notificationMarkAsRead.Click();

        }

        public void GoToNotifications()
        {
            RenderNotificationDropDown();
            notificationDropDown.Click();
            RenderSeeAllNotificationLink();
            seeAllLink.Click();
            Thread.Sleep(3000);
        }

        public void RenderLoadMoreLink()
        {
            try
            {
                Wait.WaitToBeVisible(driver, "XPath", "//*[contains(text(),'Load More...')]", 5);
                loadMoreLink = driver.FindElement(By.XPath("//*[contains(text(),'Load More...')]"));
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void ClickOnLoadMoreLink()
        {
            RenderLoadMoreLink();
            loadMoreLink.Click();
        }

        public void ClickOnShowLessLink()
        {
            ClickOnLoadMoreLink();
            RenderShowLessLink();
            showLessLink.Click();
        }
        public void RenderShowLessLink()
        {
            try
            {
                Wait.WaitToBeVisible(driver, "XPath", "//*[contains(text(),'...Show Less')]", 5);
                showLessLink = driver.FindElement(By.XPath("//*[contains(text(),'...Show Less')]"));
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public string GetShowLessLink()
        {
            RenderShowLessLink();
            return showLessLink.Text;
        }

        public string GetLoadMoreLink()
        {
            RenderLoadMoreLink();
            return loadMoreLink.Text;
        }

        public bool RenderAllCheckBoxes()
        {
            Wait.WaitToBeClickable(driver, "XPath", "//input[@type='checkbox']", 5);
            ReadOnlyCollection<IWebElement> checkboxes = driver.FindElements(By.XPath("//input[@type='checkbox']"));
            bool status = true;

            foreach (IWebElement checkbox in checkboxes)
            {
                if (checkbox.Selected)
                {
                    status = true;
                }

                else
                {
                    status = false;
                }
            }

            return status;

        }

    }

}
