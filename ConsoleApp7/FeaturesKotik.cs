using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class FeaturesKotik
    {
   
        private string _nickname;
        private readonly string _breed;
        private double _height;
        private double _weight;

        public string Nickname
        {
            get { return _nickname; }
            set { _nickname = value; }
        }

        public string Breed
        {
            get { return _breed; }
        }

        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
        public string Owner { get; }

        public FeaturesKotik(string nickname, string breed, double height, double weight, string owner)
        {
            _nickname = nickname;
            _breed = breed;
            _height = height;
            _weight = weight;
            Owner = owner;
        }
        public string Information
        {
            get
            {
                return $"#2\nКличка: {Nickname}, Порода: {Breed}, Рост: {Height} cm, Вес: {Weight} kg, Владелец: {Owner}";
            }
        }
    }
}
