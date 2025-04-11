using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Dish : CafeMenu
    {
        private int _calories;
        private int _weight; 
        public int Calories
        {
            get { return _calories; }
            set { _calories = value; }
        }

        public int Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }


        public Dish(string name, double price, string category, int calories, int weight)
            : base(name, price, category)
        {
            _calories = calories;
            _weight = weight;
        }

        public double CalculatePricePerGram()
        {
            return Price / Weight;
        }
        public override string GetInfo()
        {
            return base.GetInfo() + $", Калории: {Calories} кал, Вес: {Weight} грамм (это блюдо)";
        }
    }
}
