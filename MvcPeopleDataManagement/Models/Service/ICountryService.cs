using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcPeopleDataManagement.Models.Data;
using MvcPeopleDataManagement.Models.ViewModel;

namespace MvcPeopleDataManagement.Models.Service
{
    public interface ICountryService
    {
        public Country Add(CreateCountry createCountry);

        public CountryViewModel All();

        public List<Country> Countries();

        public Country FindById(int id);

        public Country Edit(int id, CreateCountry createCountry);

        public CreateCountry CountryToCreateCountry(Country country);

        public bool Remove(int id);
    }
}
