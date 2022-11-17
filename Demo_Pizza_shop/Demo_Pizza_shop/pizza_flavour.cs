using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Pizza_shop
{
    class pizza_flavour
    {
        string _pizza_flavour;

        public string Pizza_flavour
        {
            get { return _pizza_flavour; }
            set { _pizza_flavour = value; }
        }
        uint _flavour_price;

        public uint Flavour_price
        {
            get {
                flavour temp = (flavour)Enum.Parse(typeof(flavour), Pizza_flavour);
                return (uint)temp;
                }   
        }
        public override string ToString()
        {
            string str = string.Empty;
            str +="Pizza Flavour :" +_pizza_flavour + "\n";
            str +=
        }
    }
    enum flavour
    {
        Pepperoni=0,
        Mushrooms=1,
        Broccoli=2,
        Onions=3,
        Creamy_paneer=4,
        Tandoori_paneer=5,
        Peppy_paneer=6,
        Barbeque_chicken = 0,
        Chicken_tikka = 1,
        Chicken_pepproni = 2,
        Chicken_sasuage = 3,
        Fried_chicken = 4,
        Chicken_keema = 5,
    }
   
}
