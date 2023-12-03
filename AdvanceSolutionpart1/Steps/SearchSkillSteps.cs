using AdvanceSolutionpart1.Pages.Components.HomePageComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceSolutionpart1.Steps
{
    public class SearchSkillSteps
    {
        SearchSkillComponent searchSkillComponent = new SearchSkillComponent();

        public void SearchSkillByCategory(string category, string subCategory)
        {
            searchSkillComponent.SearchByAllCategory(category, subCategory);
            searchSkillComponent.GoToLastPage();
        }

        public void SearchSkillByFilter(string filter)
        {
            searchSkillComponent.SearchByFilter(filter);
            searchSkillComponent.GoToLastPage();
        }

    }
}