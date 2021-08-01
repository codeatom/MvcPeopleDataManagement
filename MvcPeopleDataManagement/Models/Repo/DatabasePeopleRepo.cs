using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcPeopleDataManagement.Database;
using MvcPeopleDataManagement.Models.Data;

namespace MvcPeopleDataManagement.Models.Repo
{
    public class DatabasePeopleRepo : IPeopleRepo
    {
        private readonly PeopleDbContext _personDbContext;

        public DatabasePeopleRepo(PeopleDbContext personDbContext)
        {
            _personDbContext = personDbContext;
        }

        public Person Create(Person person)
        {
            _personDbContext.Persons.Add(person);

            int result = _personDbContext.SaveChanges();

            if (result == 0)
            {
                throw new Exception("Unable to create person in database");
            }

            return person;
        }

        public Person Read(int id)   // return null if not found
        {
            return _personDbContext.Persons.Include(p => p.CurrentCity)
                                           .Include(p => p.State)
                                           .Include(p => p.PersonLanguages)
                                               .ThenInclude(pl => pl.Language)
                                           .SingleOrDefault(p => p.Id == id); 
        }

        public List<Person> Read()
        {
            return _personDbContext.Persons.Include(p => p.CurrentCity)
                                           .Include(p => p.State)
                                           .Include(p => p.PersonLanguages)
                                               .ThenInclude(pl => pl.Language)
                                           .ToList();
        }

        public Person Update(Person person)
        {
            Person originalPerson = Read(person.Id);
           
            if (originalPerson == null)
            {
                return null;
            }

            _personDbContext.Persons.Update(person);

            //originalPerson.FirstName = person.FirstName;
            //originalPerson.LastName = person.LastName;
            //originalPerson.CurrentCity = person.CurrentCity;
            //originalPerson.CellphoneNumber = person.CellphoneNumber;

            int result = _personDbContext.SaveChanges();

            if (result == 0)
            {
                return null;
            }

            return originalPerson;
        }

        public bool Delete(int id)
        {
            Person originalPerson = Read(id);

            if (originalPerson == null)
            {
                return false;
            }

            _personDbContext.Persons.Remove(originalPerson);

            int result = _personDbContext.SaveChanges();

            if (result == 0)
            {
                return false;
            }

            return true;
        }
    }
}
