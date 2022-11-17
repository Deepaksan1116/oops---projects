using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Pizza_shop
{
    class pizza_topping
    {
        string _pizza_topping;

        public string Pizza_topping
        {
            get { return _pizza_topping; }
            set { _pizza_topping = value; }
        }
        public uint Get_pizza_topping_price() 
        {
            return 0;
        }
        private uint topping_price;

        public uint Topping_price
        {
            get {
                toppings temp = (toppings)Enum.Parse(typeof(toppings), Pizza_topping);
                    return (uint)temp;
                }
          
        }
    }
    enum toppings
    {
        Black_olives=20,
        Golden_corn=20,
        Mushroom=20,
        Fresh_tomato=20,
        Jalapeno=20,
        Red_pepper=20,
        Baby_corn=20,
        Crisp_capsicum=20,
        Barbeque_chicken = 50,
        Spicy_chicken = 50,
        Fried_chicken = 50,
        Chunkey_chicken = 50,
        Chicken_salami = 50,
        Mozzarella = 20,
        Asiago = 20,
        Parmesan = 20,
        Pecorino = 20,
    }
   
    
}
