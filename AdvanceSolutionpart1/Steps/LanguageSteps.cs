using AdvanceSolutionpart1.Pages.Components.HomePageComponents.ProfileOverviewComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AdvanceSolutionpart1.Steps
{
    public class LanguageSteps
    {

        LanguagesComponent languagesComponent;
        public LanguageSteps()
        {
            languagesComponent = new LanguagesComponent();
        }


        public void CreateLanguage(string languageName, string languageLevel)
        {
            languagesComponent.ResetLanguageTable();
            languagesComponent.AddLanguage(languageName, languageLevel);
        }

        public void UpdateLanguage(string languageName, string languageLevel, string updateLanguage, string updateLevel)
        {
            languagesComponent.ResetLanguageTable();
            languagesComponent.AddLanguage(languageName, languageLevel);
            languagesComponent.EditLanguage(updateLanguage, updateLevel);
        }

        public void DeleteLanguage(string languageName, string languageLevel)
        {
            languagesComponent.ResetLanguageTable();
            languagesComponent.AddLanguage(languageName, languageLevel);
            languagesComponent.Delete();

        }

        public void AddExistingLanguage(string languageName, string languageLevel)
        {
            languagesComponent.ResetLanguageTable();
            languagesComponent.AddLanguage(languageName, languageLevel);
            languagesComponent.ClosePopUp();
            languagesComponent.AddLanguage(languageName, languageLevel);
        }


    }
}

