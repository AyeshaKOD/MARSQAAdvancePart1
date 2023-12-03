using AdvanceSolutionpart1.JSONObjectClasses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AdvanceSolutionpart1.Utilities
{
    public class JSONReader
    {
        private readonly string _sampleJsonFilePath;
        public JSONReader(string sampleJsonFilePath)
        {
            _sampleJsonFilePath = sampleJsonFilePath;
        }

        public List<Login> ReadLoginFile()
        {
            using StreamReader reader = new(_sampleJsonFilePath);
            var json = reader.ReadToEnd();
            List<Login> list = JsonConvert.DeserializeObject<List<Login>>(json);
            return list;

        }

        public List<ShareSkill> ReadShareSkillFile()
        {
            using StreamReader reader = new(_sampleJsonFilePath);
            var json = reader.ReadToEnd();
            List<ShareSkill> list = JsonConvert.DeserializeObject<List<ShareSkill>>(json);
            return list;

        }

        public List<SearchSkill> ReadSearchSkillFile()
        {
            using StreamReader reader = new(_sampleJsonFilePath);
            var json = reader.ReadToEnd();
            List<SearchSkill> list = JsonConvert.DeserializeObject<List<SearchSkill>>(json);
            return list;

        }

        public List<ShareSkillInvalidInput> ReadShareSkillInvalidInputFile()
        {
            using StreamReader reader = new(_sampleJsonFilePath);
            var json = reader.ReadToEnd();
            List<ShareSkillInvalidInput> list = JsonConvert.DeserializeObject<List<ShareSkillInvalidInput>>(json);
            return list;

        }

        public List<ProfileAboutMe> ReadProfileAboutMeInputFile()
        {
            using StreamReader reader = new(_sampleJsonFilePath);
            var json = reader.ReadToEnd();
            List<ProfileAboutMe> list = JsonConvert.DeserializeObject<List<ProfileAboutMe>>(json);
            return list;

        }

        public List<AddLanguage> ReadAddLanguageInputFile()
        {
            using StreamReader reader = new(_sampleJsonFilePath);
            var json = reader.ReadToEnd();
            List<AddLanguage> list = JsonConvert.DeserializeObject<List<AddLanguage>>(json);
            return list;

        }

        public List<UpdateLanguage> ReadUpdateLanguageInputFile()
        {
            using StreamReader reader = new(_sampleJsonFilePath);
            var json = reader.ReadToEnd();
            List<UpdateLanguage> list = JsonConvert.DeserializeObject<List<UpdateLanguage>>(json);
            return list;

        }


        public List<DeleteLanguage> ReadDeleteLanguageInputFile()
        {
            using StreamReader reader = new(_sampleJsonFilePath);
            var json = reader.ReadToEnd();
            List<DeleteLanguage> list = JsonConvert.DeserializeObject<List<DeleteLanguage>>(json);
            return list;

        }

        public List<AddExistingLanguage> ReadAddExistingLanguageInputFile()
        {
            using StreamReader reader = new(_sampleJsonFilePath);
            var json = reader.ReadToEnd();
            List<AddExistingLanguage> list = JsonConvert.DeserializeObject<List<AddExistingLanguage>>(json);
            return list;

        }

        public List<AddSkill> ReadAddSkillInputFile()
        {
            using StreamReader reader = new(_sampleJsonFilePath);
            var json = reader.ReadToEnd();
            List<AddSkill> list = JsonConvert.DeserializeObject<List<AddSkill>>(json);
            return list;

        }

        public List<UpdateSkill> ReadUpdateSkillInputFile()
        {
            using StreamReader reader = new(_sampleJsonFilePath);
            var json = reader.ReadToEnd();
            List<UpdateSkill> list = JsonConvert.DeserializeObject<List<UpdateSkill>>(json);
            return list;

        }

        public List<DeleteSkill> ReadDeleteSkillInputFile()
        {
            using StreamReader reader = new(_sampleJsonFilePath);
            var json = reader.ReadToEnd();
            List<DeleteSkill> list = JsonConvert.DeserializeObject<List<DeleteSkill>>(json);
            return list;

        }

        public List<AddExistingSkill> ReadAddExistingSkillInputFile()
        {
            using StreamReader reader = new(_sampleJsonFilePath);
            var json = reader.ReadToEnd();
            List<AddExistingSkill> list = JsonConvert.DeserializeObject<List<AddExistingSkill>>(json);
            return list;

        }



    }
}
