using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class MethodKotik
    {
        // Fields
        private string _nickname;
        private readonly string _breed;
        private double _height;
        private double _weight;
        private readonly string _owner;

        // Constructor
        public MethodKotik(string nickname, string breed, double height, double weight, string owner)
        {
            _nickname = nickname;
            _breed = breed;
            _height = height;
            _weight = weight;
            _owner = owner;
        }

        // Method to get Nickname
        public string GetNickname()
        {
            return _nickname;
        }

        // Method to set Nickname
        public void SetNickname(string nickname)
        {
            _nickname = nickname;
        }

        public string GetBreed()
        {
            return _breed;
        }

        public double GetHeight()
        {
            return _height;
        }

        public void SetHeight(double height)
        {
            _height = height;
        }

        public double GetWeight()
        {
            return _weight;
        }

        public void SetWeight(double weight)
        {
            _weight = weight;
        }

        public string GetOwner()
        {
            return _owner;
        }

        public string GetInformation()
        {
            return $"Кличка: {_nickname}, Порода: {_breed}, Рост: {_height} cm, Вес: {_weight} kg, Владелец: {_owner}";
        }
    }
}
