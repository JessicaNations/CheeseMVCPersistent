using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CheesePersistence.Models;

namespace CheesePersistence.ViewModels
{
    public class AddMenuViewModel
    {
        public AddMenuViewModel()
        {

        }
        public AddMenuViewModel(List<Menu> list)
        {

        }
        [Required]
        [Display(Name = "Menu Name")]
        public string Name { get; set; }
    }
}
