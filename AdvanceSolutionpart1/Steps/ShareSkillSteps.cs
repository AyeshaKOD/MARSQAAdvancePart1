using AdvanceSolutionpart1.Pages;
using AdvanceSolutionpart1.Pages.Components.HomePageComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AdvanceSolutionpart1.Steps
{
    public class ShareSkillSteps
    {

        ShareSkillComponent shareSkillComponent;
        public ShareSkillSteps()
        {

            shareSkillComponent = new ShareSkillComponent();
        }

        public void ShareSkill(string addTitle, string addDesc, string addCategory, string addSubCategory,
            string addTag, string addServiceType, string addLocationType, string addStartDate, string addEndDate, string addSkillTrade,
            string addSkillExchange, string addAmount, string addActiveStatus)
        {

            shareSkillComponent.CreateShareSkill(addTitle, addDesc, addCategory, addSubCategory,
            addTag, addServiceType, addLocationType, addStartDate, addEndDate, addSkillTrade,
            addSkillExchange, addAmount, addActiveStatus);

        }
    }
}
