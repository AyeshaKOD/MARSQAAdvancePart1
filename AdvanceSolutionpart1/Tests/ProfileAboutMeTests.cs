﻿using AventStack.ExtentReports;
using AdvanceSolutionpart1.AssertionHelpers;
using AdvanceSolutionpart1.JSONObjectClasses;
using AdvanceSolutionpart1.Steps;
using AdvanceSolutionpart1.Utilities;
using AdvanceSolutionpart1.JSONObjectClasses;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AdvanceSolutionpart1.Tests
{
    [TestFixture]
    public class ProfileAboutMeTests : CommonDriver
    {
        private LoginSteps loginSteps;
        public JSONReader jsonReader;
        private LoginAssertion loginAssertion;
        private ProfileInfoSteps profileInfoSteps;
        private ProfileAboutMeAssertion profileAboutMeAssertion;

        public ProfileAboutMeTests()
        {
            loginSteps = new LoginSteps();
            loginAssertion = new LoginAssertion();
            profileInfoSteps = new ProfileInfoSteps();
            profileAboutMeAssertion = new ProfileAboutMeAssertion();
        }
        


        [Test]
        public void UpdateProfileAboutMeTest()
        {
            test = extent.CreateTest("Update Profile AboutMe Section");
            test.Log(Status.Info, "Profile About Me");
            string loginFilePath = ProjectPathHelper.projectPath + "\\TestData\\LoginInputFile\\Login.json";
            jsonReader = new JSONReader(loginFilePath);
            List<Login> login = new List<Login>();
            login = jsonReader.ReadLoginFile();
            foreach (var item in login)
            {
                //Login login = jsonReader.ReadLoginFile();
                 loginSteps.Login(item.LoginId, item.Password);
                 loginAssertion.AssertLogin(item.UserName);

            }
            string profileAboutMeFilePath = ProjectPathHelper.projectPath + "\\TestData\\ProfileAboutMe\\ProfileAboutMe.json";
            jsonReader = new JSONReader(profileAboutMeFilePath);
            List<ProfileAboutMe> profile = new List<ProfileAboutMe>();
            profile = jsonReader.ReadProfileAboutMeInputFile();
            foreach (var availability in profile)
            {
                profileInfoSteps.ProfileInfo(availability.Availability, availability.Hours, availability.EarnTarget);
                profileAboutMeAssertion.AssertAboutMe(availability.Availability, availability.Hours, availability.EarnTarget);
            }
        }
    }
}
