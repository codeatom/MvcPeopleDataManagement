﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcPeopleDataManagement.Models.Data;

namespace MvcPeopleDataManagement.Models.ViewModel
{
    public class PersonViewModel
    {
        public string FilterText { get; set; }

        public Person Person { get; set; }

        public List<Person> PersonList { get; set; }
    }
}