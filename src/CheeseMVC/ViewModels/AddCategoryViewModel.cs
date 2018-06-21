﻿using CheeseMVC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.ViewModels
{
    public class AddCategoryViewModel //: CheeseCategory
    {
        [Required]
        [Display(Name = "Category Name")]
        public string Name { get; set; }
    }
}