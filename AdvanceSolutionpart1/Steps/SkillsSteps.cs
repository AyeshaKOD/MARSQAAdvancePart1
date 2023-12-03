using AdvanceSolutionpart1.Pages.Components.HomePageComponents.ProfileOverviewComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceSolutionpart1.Steps
{
    public class SkillsSteps
    {
        SkillsComponent skillsComponent;

        public SkillsSteps()
        {
            skillsComponent = new SkillsComponent();
        }

        public void AddSkill(string skill, string skillLevel)
        {
            skillsComponent.GoToSkillsTab();
            skillsComponent.ResetSkillTable();
            skillsComponent.AddNewSkill(skill, skillLevel);
        }

        public void UpdateSkill(string skill, string skillLevel, string editSkill, string editSkillLevel)
        {
            skillsComponent.GoToSkillsTab();
            skillsComponent.ResetSkillTable();
            skillsComponent.AddNewSkill(skill, skillLevel);
            skillsComponent.EditSkill(editSkill, editSkillLevel);
        }

        public void DeleteSkill(string skill, string skilLevel)
        {
            skillsComponent.GoToSkillsTab();
            skillsComponent.ResetSkillTable();
            skillsComponent.AddNewSkill(skill, skilLevel);
            skillsComponent.DeleteSkill();
        }

        public void AddExistingSkill(string skill, string skillLevel)
        {
            skillsComponent.GoToSkillsTab();
            skillsComponent.ResetSkillTable();
            skillsComponent.AddNewSkill(skill, skillLevel);
            skillsComponent.ClosePopUp();
            skillsComponent.AddNewSkill(skill, skillLevel);



        }
    }
}
