using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10026525.PROG6221.POE
{
    public class ingredientClass
    {

        //Declaring Variebles
        public string ingredientName { get; set; }
        public double Quantity { get; set; }
        public string Unit { get; set; }

        // creating a method for the ingredients
        public ingredientClass(string name, double quantity, string unit)
        {
            ingredientName = name;
            Quantity = quantity;
            Unit = unit;
        }
    }
}
