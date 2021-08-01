using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcPeopleDataManagement.Models.Data;

namespace MvcPeopleDataManagement.Models.Service
{
    public interface IPersonLanguageService
    {
        public PersonLanguage Add(PersonLanguage personLanguage);

        public List<PersonLanguage> All();

        public PersonLanguage FindById(int personId, int languageId);

        public bool Remove(int personId, int languageId);
    }
}
