﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcPeopleDataManagement.Models.Data
{
    public class Language
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
       
        public List<PersonLanguage> PersonLanguages { get; set; }

        public Language()
        {
            PersonLanguages = new List<PersonLanguage>();
        }
    }
}
