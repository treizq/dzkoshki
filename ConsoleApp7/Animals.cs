using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Animal
    {

        private string _name;
        private double _weight;
        private string _breed;
        private DateTime _birthDate;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public string Breed
        {
            get { return _breed; }
            set { _breed = value; }
        }

        public DateTime BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }

        public Animal(string name, double weight, string breed, DateTime birthDate)
        {
            _name = name;
            _weight = weight;
            _breed = breed;
            _birthDate = birthDate;
        }

        public virtual string GetInfo()
        {
            return $"#4\nКличка: {Name}, Вес: {Weight} kg, Порода: {Breed}, Дата рождения: {BirthDate.ToShortDateString()}";
        }
    }
}
