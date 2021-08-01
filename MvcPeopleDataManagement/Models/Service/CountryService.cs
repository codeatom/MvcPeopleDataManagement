using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcPeopleDataManagement.Models.Data;
using MvcPeopleDataManagement.Models.Repo;
using MvcPeopleDataManagement.Models.ViewModel;

namespace MvcPeopleDataManagement.Models.Service
{
    public class CountryService : ICountryService
    {
        ICountryRepo _countryRepo;

        public CountryService(ICountryRepo countryRepo)
        {
            _countryRepo = countryRepo;
        }

        public Country Add(CreateCountry createCountry)
        {
            Country country = new Country();

            country.Name = createCountry.Name;

            country = _countryRepo.Create(country);

            return country;
        }

        public CountryViewModel All()
        {
            CountryViewModel countryViewModel = new CountryViewModel();
            countryViewModel.CountryList = _countryRepo.Read();

            return countryViewModel;
        }

        public List<Country> Countries()
        {
            return _countryRepo.Read();
        }

        public Country FindById(int id)
        {
            return _countryRepo.Read(id);
        }

        public Country Edit(int id, CreateCountry createCountry)
        {
            Country originalCountry = FindById(id);

            if (originalCountry == null)
            {
                return null;
            }

            originalCountry.Name = createCountry.Name;

            originalCountry = _countryRepo.Update(originalCountry);

            return originalCountry;
        }

        public CreateCountry CountryToCreateCountry(Country country)
        {
            CreateCountry createCountry = new CreateCountry();

            createCountry.Name = country.Name;

            return createCountry;
        }

        public bool Remove(int id)
        {
            Country country = _countryRepo.Read(id);

            if (country != null)
            {
                return _countryRepo.Delete(country);
            }

            return false;
        }
    }
}
