using AdvanceSolutionpart1.Pages.Components.HomePageComponents.ProfileOverviewComponent;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceSolutionpart1.AssertionHelpers
{
    public class SkillsAssertion
    {
        SkillsComponent skillsComponent = new SkillsComponent();

        public void AssertAddSkill(string popUpMessage)
        {
            string expectedMessage = skillsComponent.PopUpMessage();
            Assert.That(expectedMessage == popUpMessage, "Skill not added successfully");


        }

        public void AssertUpdateSkill(string popUpMessage)
        {
            string expectedMessage = skillsComponent.PopUpMessage();
            Assert.That(expectedMessage == popUpMessage, "Skill not updated successfully");


        }


        public void AssertDeleteSkill(string popUpMessage)
        {
            string expectedMessage = skillsComponent.PopUpMessage();
            Assert.That(expectedMessage == popUpMessage, "Skill not deleted successfully");


        }

        public void AssertAddExistingSkill(string popUpMessage)
        {
            string expectedMessage = skillsComponent.PopUpMessage();
            Assert.That(expectedMessage == popUpMessage, "Duplicate Data Added");


        }

    }
}
