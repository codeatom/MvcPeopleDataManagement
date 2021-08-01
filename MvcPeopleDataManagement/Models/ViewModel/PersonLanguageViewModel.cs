using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcPeopleDataManagement.Models.Data;

namespace MvcPeopleDataManagement.Models.ViewModel
{
    public class PersonLanguageViewModel
    {
        public Person person { get; set; }

        public List<Language> Languages { get; set; }

        public List<Language> UnSpokenLanguages { get; set; }
    }
}
