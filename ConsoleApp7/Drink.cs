using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Drink : CafeMenu
    {
        private int _volume;

        public int Volume
        {
            get { return _volume; }
            set { _volume = value; }
        }

        public Drink(string name, double price, string category, int volume)
            : base(name, price, category)
        {
            _volume = volume;
        }

        public double CalculateDiscountedPrice(double discountPercentage)
        {
            if (discountPercentage < 0 || discountPercentage > 100)
            {
                throw new ArgumentException("Процент скидки должен быть в диапазоне от 0 до 100.");
            }
            return Price * (1 - discountPercentage / 100);
        }
        public override string GetInfo()
        {
            return base.GetInfo() + $", Объем: {Volume} мл (это напиток)";
        }
    }
}
