using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Cat : Animal
    {
        public Cat(string name, double weight, string breed, DateTime birthDate)
            : base(name, weight, breed, birthDate)
        {
        }
        // мышь ловить
        public bool CatchMouse()
        {
            Random random = new Random();
            int chance = random.Next(0, 101);
            return chance > 50;
        }
        public override string GetInfo()
        {
            return base.GetInfo() + " (это кошка)";
        }
    }
}
