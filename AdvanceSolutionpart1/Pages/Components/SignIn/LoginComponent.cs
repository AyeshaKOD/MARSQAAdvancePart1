using AdvanceSolutionpart1.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceSolutionpart1.Pages.Components.SignIn
{
    public class LoginComponent : CommonDriver
    {
        private IWebElement emailTextbox;
        private IWebElement passwordTextbox;
        private IWebElement loginButton;



        public void RenderLoginComponents()
        {
            try
            {
                emailTextbox = driver.FindElement(By.XPath("//*[@placeholder='Email address']"));
                passwordTextbox = driver.FindElement(By.XPath("//*[@placeholder='Password']"));
                loginButton = driver.FindElement(By.XPath("//*[text()='Login']"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void DoLogin(string emailId, string password)
        {
            RenderLoginComponents();
            emailTextbox.SendKeys(emailId);
            passwordTextbox.SendKeys(password);
            loginButton.Click();

        }
    }
}
