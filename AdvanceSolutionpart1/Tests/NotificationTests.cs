using AventStack.ExtentReports;
using AdvanceSolutionpart1.AssertionHelpers;
using AdvanceSolutionpart1.Steps;
using AdvanceSolutionpart1.Utilities;
using AdvanceSolutionpart1.JSONObjectClasses;
using AdvanceSolutionpart1.Utilities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AdvanceSolutionpart1.Tests
{
    [TestFixture]
    public class NotificationTests : CommonDriver
    {
        LoginSteps loginSteps = new LoginSteps();
        JSONReader jsonReader;
        LoginAssertion loginAssertion = new LoginAssertion();
        NotificationSteps notificationSteps = new NotificationSteps();
        NotificationAssertion notificationAssertion = new NotificationAssertion();

        [Test, Order(1)]
        public void NotificationsLoadMoreTest()
        {
            test = extent.CreateTest("Notifications - Load More");
            test.Log(Status.Info, "Notifications - Load More");
            string loginFilePath = ProjectPathHelper.projectPath + "\\TestData\\LoginInputFile\\Login.json";
            jsonReader = new JSONReader(loginFilePath);
            List<Login> login = new List<Login>();
            login = jsonReader.ReadLoginFile();
            foreach (var item in login)
            {
                loginSteps.Login(item.LoginId, item.Password);
                loginAssertion.AssertLogin(item.UserName);

            }
            notificationSteps.LoadMoreNotification();
            notificationAssertion.AssertShowLessNotifications();
        }

        [Test, Order(2)]
        public void NotificationsShowLessTest()
        {
            test = extent.CreateTest("Notifications - Show Less");
            test.Log(Status.Info, "Notifications - Show Less");
            string loginFilePath = ProjectPathHelper.projectPath + "\\TestData\\LoginInputFile\\Login.json";
            jsonReader = new JSONReader(loginFilePath);
            List<Login> login = new List<Login>();
            login = jsonReader.ReadLoginFile();
            foreach (var item in login)
            {
                loginSteps.Login(item.LoginId, item.Password);
                loginAssertion.AssertLogin(item.UserName);

            }
            notificationSteps.ShowLessNotification();
            notificationAssertion.AssertLoadMoreNotification();
        }

        [Test, Order(3)]
        public void DeleteNotificationTest()
        {
            test = extent.CreateTest("Notifications - Delete");
            test.Log(Status.Info, "Notifications - Delete");
            string loginFilePath = ProjectPathHelper.projectPath + "\\TestData\\LoginInputFile\\Login.json";
            jsonReader = new JSONReader(loginFilePath);
            List<Login> login = new List<Login>();
            login = jsonReader.ReadLoginFile();
            foreach (var item in login)
            {
                loginSteps.Login(item.LoginId, item.Password);
                loginAssertion.AssertLogin(item.UserName);

            }
            notificationSteps.DeleteNotification();
            notificationAssertion.AssertPopUpMessage();
        }


        [Test, Order(4)]
        public void MarkNotificationAsReadTest()
        {
            test = extent.CreateTest("Notifications - Mark As Read");
            test.Log(Status.Info, "Notifications - Mark As Read");
            string loginFilePath = ProjectPathHelper.projectPath + "\\TestData\\LoginInputFile\\Login.json";
            jsonReader = new JSONReader(loginFilePath);
            List<Login> login = new List<Login>();
            login = jsonReader.ReadLoginFile();
            foreach (var item in login)
            {
                loginSteps.Login(item.LoginId, item.Password);
                loginAssertion.AssertLogin(item.UserName);

            }
            notificationSteps.MarkNotificationAsRead();
            notificationAssertion.AssertPopUpMessage();
        }

        [Test, Order(5)]
        public void NotificationSelectAllTest()
        {
            test = extent.CreateTest("Notifications - Select All");
            test.Log(Status.Info, "Notifications - Select All");
            string loginFilePath = ProjectPathHelper.projectPath + "\\TestData\\LoginInputFile\\Login.json";
            jsonReader = new JSONReader(loginFilePath);
            List<Login> login = new List<Login>();
            login = jsonReader.ReadLoginFile();
            foreach (var item in login)
            {
                loginSteps.Login(item.LoginId, item.Password);
                loginAssertion.AssertLogin(item.UserName);

            }
            notificationSteps.SelectNotification();
            notificationAssertion.AssertSelectAllNotification();
        }

        [Test, Order(6)]
        public void NotificationUnSelectAllTest()
        {
            test = extent.CreateTest("Notifications - UnSelect All");
            test.Log(Status.Info, "Notifications - UnSelect All");
            string loginFilePath = ProjectPathHelper.projectPath + "\\TestData\\LoginInputFile\\Login.json";
            jsonReader = new JSONReader(loginFilePath);
            List<Login> login = new List<Login>();
            login = jsonReader.ReadLoginFile();
            foreach (var item in login)
            {
                loginSteps.Login(item.LoginId, item.Password);
                loginAssertion.AssertLogin(item.UserName);

            }
            notificationSteps.UnSelectNotification();
            notificationAssertion.AssertUnSelectAllNotification();
        }



    }
}

