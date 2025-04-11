using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Attraction
    {
        private string _name;
        private int _duration; 
        private int _maxCapacity; 

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }

        public int MaxCapacity
        {
            get { return _maxCapacity; }
            set { _maxCapacity = value; }
        }
        public Attraction(string name, int duration, int maxCapacity)
        {
            _name = name;
            _duration = duration;
            _maxCapacity = maxCapacity;
        }
        public virtual string GetInfo()
        {
            return $"#5\nАттракцион: {Name}, Длительность: {Duration} минут, максимум мест: {MaxCapacity} человек";
        }
    }
}
