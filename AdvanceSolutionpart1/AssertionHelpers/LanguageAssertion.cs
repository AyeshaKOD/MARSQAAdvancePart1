using AdvanceSolutionpart1.Pages.Components.HomePageComponents.ProfileOverviewComponent;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceSolutionpart1.AssertionHelpers
{
    public class LanguageAssertions
    {
        LanguagesComponent languagesComponent = new LanguagesComponent();
        public void AssertAddLanguage(string popUpMessage)
        {
            string expectedMessage = languagesComponent.PopUpMessage();
            Assert.That(expectedMessage == popUpMessage, "Language not added successfully");
        }

        public void AssertUpdateLanguage(string popUpMessage)
        {
            string expectedMessage = languagesComponent.PopUpMessage();
            Assert.That(expectedMessage == popUpMessage, "Language not updated successfully");
        }

        public void AssertDeleteLanguage(string popUpMessage)
        {
            string expectedMessage = languagesComponent.PopUpMessage();
            Assert.That(expectedMessage == popUpMessage, "Language not deleted successfully");
        }

        public void AssertAddExistingLanguage(string popUpMessage)
        {
            string expectedMessage = languagesComponent.PopUpMessage();
            Assert.That(expectedMessage == popUpMessage, "Dulicate language added");
        }

    }
}

