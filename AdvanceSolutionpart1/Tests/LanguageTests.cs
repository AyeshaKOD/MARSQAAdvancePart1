using AventStack.ExtentReports;
using AdvanceSolutionpart1.AssertionHelpers;
using AdvanceSolutionpart1.JSONObjectClasses;
using AdvanceSolutionpart1.Pages.Components.HomePageComponents.ProfileOverviewComponent;
using AdvanceSolutionpart1.Steps;
using AdvanceSolutionpart1.Utilities;
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
    public class LanguageTests : CommonDriver
    {
        private LoginSteps loginSteps;
       public JSONReader jsonReader;
        private LoginAssertion loginAssertion;
        LanguageSteps languageSteps;
        LanguageAssertions languageAssertions;

        public LanguageTests()
        {
            loginSteps = new LoginSteps();
            //JSONReader jsonReader;
            loginAssertion = new LoginAssertion();
            languageSteps = new LanguageSteps();
            languageAssertions = new LanguageAssertions();
        }
        [Test, Order(1)]
        public void AddLanguageTest()
        {
            test = extent.CreateTest("Languages - Add New");
            test.Log(Status.Info, "Languages - Add New");
            string loginFilePath = ProjectPathHelper.projectPath + "\\TestData\\LoginInputFile\\Login.json";
            jsonReader = new JSONReader(loginFilePath);
            List<Login> login = new List<Login>();
            login = jsonReader.ReadLoginFile();
            //Login login = jsonReader.ReadLoginFile();



            foreach (var item in login)
            {
                loginSteps.Login(item.LoginId, item.Password);
                loginAssertion.AssertLogin(item.UserName);

            }

            string addLanguageFilePath = ProjectPathHelper.projectPath + "\\TestData\\LanguagesInputFiles\\AddLanguage.json";
            jsonReader = new JSONReader(addLanguageFilePath);
            List<AddLanguage> addlanguage = new List<AddLanguage>();
            addlanguage = jsonReader.ReadAddLanguageInputFile();
            foreach (var language in addlanguage)
            {
                languageSteps.CreateLanguage(language.Language, language.Level);
                languageAssertions.AssertAddLanguage(language.PopUpMessage);
            }



        }


        [Test, Order(2)]
        public void UpdateLanguageTest()
        {
            test = extent.CreateTest("Languages - Update");
            test.Log(Status.Info, "Languages - Update");
            string loginFilePath = ProjectPathHelper.projectPath + "\\TestData\\LoginInputFile\\Login.json";
            jsonReader = new JSONReader(loginFilePath);
            List<Login> login = new List<Login>();
            login = jsonReader.ReadLoginFile();
            //Login login = jsonReader.ReadLoginFile();
            foreach (var item in login)
            {
                loginSteps.Login(item.LoginId, item.Password);
                loginAssertion.AssertLogin(item.UserName);

            }

            string updateLanguageFilePath = ProjectPathHelper.projectPath + "\\TestData\\LanguagesInputFiles\\UpdateLanguage.json";
            jsonReader = new JSONReader(updateLanguageFilePath);
            List<UpdateLanguage> editLanguage = new List<UpdateLanguage>();
            editLanguage = jsonReader.ReadUpdateLanguageInputFile();
            foreach (var language in editLanguage)
            {
                languageSteps.UpdateLanguage(language.Language, language.Level, language.EditLanguage, language.EditLevel);
                languageAssertions.AssertUpdateLanguage(language.PopUpMessage);

            }

        }


        [Test, Order(3)]
        public void DeleteLanguageTest()
        {
            test = extent.CreateTest("Languages - Delete");
            test.Log(Status.Info, "Languages - Delete");
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

            string deleteLanguageFilePath = ProjectPathHelper.projectPath + "\\TestData\\LanguagesInputFiles\\DeleteLanguage.json";
            jsonReader = new JSONReader(deleteLanguageFilePath);
            List<UpdateLanguage> deleteLanguage = new List<UpdateLanguage>();
            deleteLanguage = jsonReader.ReadUpdateLanguageInputFile();
            foreach (var language in deleteLanguage)
            {
                languageSteps.DeleteLanguage(language.Language, language.Level);
                languageAssertions.AssertDeleteLanguage(language.PopUpMessage);

            }

        }

        [Test, Order(4)]
        public void AddExistingLanguageTest()
        {
            test = extent.CreateTest("Languages - Add Existing Language");
            test.Log(Status.Info, "Languages - Add Existing Language");
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

            string addExistingLanguageFilePath = ProjectPathHelper.projectPath + "\\TestData\\LanguagesInputFiles\\AddExistingLanguage.json";
            jsonReader = new JSONReader(addExistingLanguageFilePath);
            List<AddExistingLanguage> addExistinglanguage = new List<AddExistingLanguage>();
            addExistinglanguage = jsonReader.ReadAddExistingLanguageInputFile();
            foreach (var language in addExistinglanguage)
            {
                languageSteps.AddExistingLanguage(language.Language, language.Level);
                languageAssertions.AssertAddExistingLanguage(language.PopUpMessage);
            }



        }


    }
}