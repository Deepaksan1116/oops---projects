using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Pizza_shop
{
    public class pizza_structure
    {
        string _pizza_size;
        string _pizza_base;
        string _pizza_type;

        public string Pizza_base
        {
            get { return _pizza_base; }
            set { _pizza_base = value; }
        }

        public string Pizza_size
        {
            get { return _pizza_size; }
            set { _pizza_size = value; }
        }
        

        public string Pizza_type
        {
            get { return _pizza_type; }
            set { _pizza_type = value; }
        }
        uint _type_price;
        uint _size_price;
        uint _base_price;

        private uint Base_price
        {
            get {
                pizza_sizes temp = (pizza_sizes)Enum.Parse(typeof(pizza_sizes), Pizza_size);
                return (uint)temp;
                }
           
        }

        private uint Size_price
        {
            get {
                pizza_bases temp = (pizza_bases)Enum.Parse(typeof(pizza_bases), Pizza_base);
                return (uint)temp;
                }
            
        }

        private uint Type_price
        {
            get {
                pizza_types temp = (pizza_types)Enum.Parse(typeof(pizza_types), Pizza_type);
                return (uint)temp;
                }
           
        }

        public uint Structure_price()
        {
            uint temp = Base_price + Size_price + Type_price;
            return temp;
        }
       
    }
    enum pizza_sizes
    { 
        Regular=100,
        Large=150,
        Extra_Large=200,
    }
    enum pizza_bases
    { 
        Regular=50,
        Thin=100,
        Thick=150,
    }
    enum pizza_types
    { 
        Veg=50,
        Non_Veg=100,
    }
}
