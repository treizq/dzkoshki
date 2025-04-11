using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class CafeMenu
    {
        private string _name; 
        private double _price; 
        private string _category;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        public CafeMenu(string name, double price, string category)
        {
            _name = name;
            _price = price;
            _category = category;
        }
        public virtual string GetInfo()
        {
            return $"№6\nБлюдо: {Name}, Цена: {Price} RUB, Кухня: {Category}";
        }
    }
}
