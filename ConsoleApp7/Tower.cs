using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Tower : Attraction
    {
        private double _ridePrice;

        public double RidePrice
        {
            get { return _ridePrice; }
            set { _ridePrice = value; }
        }
        public Tower(string name, int duration, int maxCapacity, double ridePrice)
            : base(name, duration, maxCapacity)
        {
            _ridePrice = ridePrice;
        }
        public double CalculateRevenue(int numberOfPeople = -1)
        {
            if (numberOfPeople == -1)
            {
                numberOfPeople = MaxCapacity;
            }
            return numberOfPeople * RidePrice;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $", Цена: {RidePrice} (Это башня)";
        }
    }
}
