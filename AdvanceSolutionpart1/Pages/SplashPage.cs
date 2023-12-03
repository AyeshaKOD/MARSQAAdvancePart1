using AdvanceSolutionpart1.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceSolutionpart1.Pages
{
    public class SplashPage : CommonDriver
    {
        private IWebElement signInButton;


        public void RenderSignInComponents()
        {
            try
            {
                Wait.WaitToBeVisible(driver, "XPath", "//*[@id=\"home\"]/div/div/div[1]/div/a", 10);
                signInButton = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }

        public void ClickSignInButton()
        {

            RenderSignInComponents();
            signInButton.Click();

        }
    }
}
