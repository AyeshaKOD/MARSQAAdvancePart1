using AventStack.ExtentReports;
using AdvanceSolutionpart1.AssertionHelpers;
using AdvanceSolutionpart1.JSONObjectClasses;
using AdvanceSolutionpart1.Pages.Components.HomePageComponents.ProfileOverviewComponent;
using AdvanceSolutionpart1.Steps;
using AdvanceSolutionpart1.Utilities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvanceSolutionpart1.Pages.Components.HomePageComponents.ProfileOverviewComponent;

namespace AdvanceSolutionpart1.Tests
{
    [TestFixture]
    public class SkillsTests : CommonDriver
    {
        LoginSteps loginSteps = new LoginSteps();
        JSONReader jsonReader;
        LoginAssertion loginAssertion = new LoginAssertion();
        SkillsComponent skillsComponent = new SkillsComponent();
        SkillsSteps skillsSteps = new SkillsSteps();
        SkillsAssertion skillsAssertion = new SkillsAssertion();

        [Test, Order(1)]
        public void AddSkillsTest()
        {
            test = extent.CreateTest("Skills - Add New");
            test.Log(Status.Info, "Skills - Add New");
            string loginFilePath = ProjectPathHelper.projectPath + "\\TestData\\LoginInputFile\\Login.json";
            jsonReader = new JSONReader(loginFilePath);
            List<Login> login = new List<Login>();
            login = jsonReader.ReadLoginFile();
            foreach (var item in login)
            {
                loginSteps.Login(item.LoginId, item.Password);
                loginAssertion.AssertLogin(item.UserName);

            }

            string addSkillFilePath = ProjectPathHelper.projectPath + "\\TestData\\SkillsInputFiles\\AddSkill.json";
            jsonReader = new JSONReader(addSkillFilePath);
            List<AddSkill> addSkill = new List<AddSkill>();
            addSkill = jsonReader.ReadAddSkillInputFile();
            foreach (var skill in addSkill)
            {
                skillsSteps.AddSkill(skill.Skill, skill.Level);
                skillsAssertion.AssertAddSkill(skill.PopUpMessage);

            }



        }

        [Test, Order(2)]
        public void UpdateSkillsTest()
        {
            test = extent.CreateTest("Skills - Update");
            test.Log(Status.Info, "Skills - Update");
            string loginFilePath = ProjectPathHelper.projectPath + "\\TestData\\LoginInputFile\\Login.json";
            jsonReader = new JSONReader(loginFilePath);
            List<Login> login = new List<Login>();
            login = jsonReader.ReadLoginFile();
            foreach (var item in login)
            {
                loginSteps.Login(item.LoginId, item.Password);
                loginAssertion.AssertLogin(item.UserName);

            }

            string updateSkillFilePath = ProjectPathHelper.projectPath + "\\TestData\\SkillsInputFiles\\UpdateSkill.json";
            jsonReader = new JSONReader(updateSkillFilePath);
            List<UpdateSkill> updateSkill = new List<UpdateSkill>();
            updateSkill = jsonReader.ReadUpdateSkillInputFile();
            foreach (var skill in updateSkill)
            {
                skillsSteps.UpdateSkill(skill.Skill, skill.Level, skill.EditSkill, skill.EditLevel);
                skillsAssertion.AssertUpdateSkill(skill.PopUpMessage);

            }

        }


        [Test, Order(3)]
        public void DeleteSkillsTest()
        {
            test = extent.CreateTest("Skills - Delete");
            test.Log(Status.Info, "Skills - Delete");
            string loginFilePath = ProjectPathHelper.projectPath + "\\TestData\\LoginInputFile\\Login.json";
            jsonReader = new JSONReader(loginFilePath);
            List<Login> login = new List<Login>();
            login = jsonReader.ReadLoginFile();
            foreach (var item in login)
            {
                loginSteps.Login(item.LoginId, item.Password);
                loginAssertion.AssertLogin(item.UserName);

            }

            string updateSkillFilePath = ProjectPathHelper.projectPath + "\\TestData\\SkillsInputFiles\\DeleteSkill.json";
            jsonReader = new JSONReader(updateSkillFilePath);
            List<DeleteSkill> deleteSkill = new List<DeleteSkill>();
            deleteSkill = jsonReader.ReadDeleteSkillInputFile();
            foreach (var skill in deleteSkill)
            {
                skillsSteps.DeleteSkill(skill.Skill, skill.Level);
                skillsAssertion.AssertDeleteSkill(skill.PopUpMessage);

            }

        }


        [Test, Order(4)]
        public void AddExistingSkillTest()
        {
            test = extent.CreateTest("Skills - Add Existing Skill");
            test.Log(Status.Info, "Skills - Add Existing Skill");
            string loginFilePath = ProjectPathHelper.projectPath + "\\TestData\\LoginInputFile\\Login.json";
            jsonReader = new JSONReader(loginFilePath);
            List<Login> login = new List<Login>();
            login = jsonReader.ReadLoginFile();
            foreach (var item in login)
            {
                loginSteps.Login(item.LoginId, item.Password);
                loginAssertion.AssertLogin(item.UserName);

            }

            string addExistingSkillFilePath = ProjectPathHelper.projectPath + "\\TestData\\SkillsInputFiles\\AddExistingSkill.json";
            jsonReader = new JSONReader(addExistingSkillFilePath);
            List<AddExistingSkill> addExistingSkill = new List<AddExistingSkill>();
            addExistingSkill = jsonReader.ReadAddExistingSkillInputFile();
            foreach (var skill in addExistingSkill)
            {
                skillsSteps.AddExistingSkill(skill.Skill, skill.Level);
                skillsAssertion.AssertAddExistingSkill(skill.PopUpMessage);

            }



        }


    }
}