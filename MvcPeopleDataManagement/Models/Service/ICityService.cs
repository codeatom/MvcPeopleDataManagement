using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcPeopleDataManagement.Models.Data;
using MvcPeopleDataManagement.Models.ViewModel;

namespace MvcPeopleDataManagement.Models.Service
{
    public interface ICityService
    {
        public City Add(CreateCity createCity);

        public CityViewModel All();

        public City FindById(int id);

        public City Edit(int id, CreateCity createCity);

        public CreateCity CityToCreateCity(City city);

        public bool Remove(int id);
    }
}
