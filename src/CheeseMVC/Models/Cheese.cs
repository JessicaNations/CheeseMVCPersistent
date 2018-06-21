using System.Collections.Generic;
using CheesePersistence.Models;

namespace CheeseMVC.Models
{
    public class Cheese
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int CategoryID { get; set; }
        public CheeseCategory Category { get; set; }

        public IList<CheeseMenu> CheeseMenus; //{ get; set; }
    }
}
