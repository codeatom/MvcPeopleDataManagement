using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcPeopleDataManagement.Models.Data;

namespace MvcPeopleDataManagement.Models.Repo
{
    public interface IPersonLanguageRepo
    {
        PersonLanguage Create(PersonLanguage personLanguage);

        PersonLanguage Read(int personId, int languageId);

        List<PersonLanguage> Read();

        bool Delete(int personId, int languageId);
    }
}
