using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcPeopleDataManagement.Models.Data;

namespace MvcPeopleDataManagement.Models.Repo
{
    public interface ILanguageRepo
    {
        public Language Create(Language language);

        public Language Read(int id);

        public List<Language> Read();
       
        public Language Update(Language language);

        public bool Delete(Language language);
    }
}
