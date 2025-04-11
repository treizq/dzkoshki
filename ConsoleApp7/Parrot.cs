using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Parrot : Animal
    {
        public Parrot(string name, double weight, string breed, DateTime birthDate)
            : base(name, weight, breed, birthDate)
        {
        }

        public override string GetInfo()
        {
            return base.GetInfo() + " (это попугай)\n";
        }
    }
}
