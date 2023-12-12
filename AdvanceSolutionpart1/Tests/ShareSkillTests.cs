using AventStack.ExtentReports;
using AdvanceSolutionpart1.AssertionHelpers;
using AdvanceSolutionpart1.JSONObjectClasses;
using AdvanceSolutionpart1.Pages.Components.HomePageComponents;
using AdvanceSolutionpart1.Pages.Components.SignIn;
using AdvanceSolutionpart1.Steps;
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
    public class ShareSkillTests : CommonDriver
    {
        private LoginSteps loginSteps;
        public JSONReader jsonReader;
        private LoginAssertion loginAssertion;
        private ShareSkillSteps shareSkillSteps;
        private ShareSkillAssertHelper shareSkillAssert;

        public ShareSkillTests ()
        {
             loginSteps = new LoginSteps();
             loginAssertion = new LoginAssertion();
             shareSkillSteps = new ShareSkillSteps();
             shareSkillAssert = new ShareSkillAssertHelper();
        }
        


        [Test, Order(1)]
        public void AddShareSkillTest()
        {
            test = extent.CreateTest("Share Skill");
            test.Log(Status.Info, "Skill");
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

            string shareSkillFilePath = ProjectPathHelper.projectPath + "\\TestData\\ShareSkillInputFile\\ShareSkill.json";
            jsonReader = new JSONReader(shareSkillFilePath);
            List<ShareSkill> shareSkill = new List<ShareSkill>();
            shareSkill = jsonReader.ReadShareSkillFile();
            foreach (var skill in shareSkill)
            {
                shareSkillSteps.ShareSkill(skill.Title, skill.Description, skill.Category, skill.SubCategory, skill.Tags, skill.ServiceType, skill.LocationType,
                    skill.StartDate, skill.EndDate, skill.SkillTrade, skill.SkillExchange, skill.Amount, skill.ActiveStatus);
                shareSkillAssert.AssertShareSkill(skill.PopUpMessage, skill.Category, skill.Title, skill.Description);
            }

        }


        [Test, Order(2)]
        public void AddShareSkillInvalidInputTest()
        {
            test = extent.CreateTest("Share Skill");
            test.Log(Status.Info, "Skill");
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
            string shareSkillFilePath = ProjectPathHelper.projectPath + "\\TestData\\ShareSkillInputFile\\ShareSkillInvalidInput.json";
            jsonReader = new JSONReader(shareSkillFilePath);
            List<ShareSkillInvalidInput> shareSkill = new List<ShareSkillInvalidInput>();
            shareSkill = jsonReader.ReadShareSkillInvalidInputFile();
            foreach (var skill in shareSkill)
            {
                shareSkillSteps.ShareSkill(skill.Title, skill.Description, skill.Category, skill.SubCategory, skill.Tags, skill.ServiceType, skill.LocationType,
                    skill.StartDate, skill.EndDate, skill.SkillTrade, skill.SkillExchange, skill.Amount, skill.ActiveStatus);
                shareSkillAssert.AssertShareSkillInvalidInput(skill.PopUpMessage);
            }

        }



    }
}
