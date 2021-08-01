using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcPeopleDataManagement.Models.Data;

namespace MvcPeopleDataManagement.Models.Repo
{
    public interface ICityRepo
    {
        public City Create(City city);

        public List<City> Read();

        public City Read(int id);

        public City Update(City city);

        public bool Delete(City city);
    }
}
