using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcPeopleDataManagement.Models.Data;

namespace MvcPeopleDataManagement.Models.Repo
{
    public interface IPeopleRepo
    {
        Person Create(Person person);

        Person Read(int id);

        List<Person> Read();

        Person Update(Person person);

        bool Delete(int id);
    }
}
