﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CheeseMVC.Models;

namespace CheesePersistence.Models
{
    public class CheeseMenu
    {
        public int MenuID { get; set; }
        public Menu Menu { get; set; }

        public int CheeseID { get; set; }
        public Cheese Cheese { get; set; }
    }
}
