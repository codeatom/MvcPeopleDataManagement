using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcPeopleDataManagement.Models.Data;
using MvcPeopleDataManagement.Models.ViewModel;

namespace MvcPeopleDataManagement.Models.Service
{
    public interface IPeopleService
    {
        public Person Add(CreatePerson createPerson);

        public PersonViewModel All();

        public Person FindById(int id);

        public List<Person> FindByKeyWord(string names);

        public Person Edit(int id, CreatePerson createPerson);

        public CreatePerson PersonToCreatePerson(Person person);

        List<Language> LanguageState(int id);

        public bool Remove(int id);
        
    }
}
