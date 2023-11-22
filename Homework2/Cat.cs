using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    public class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age)
        {
        }

        public override string Say()
        {
            string baseMessage = base.Say();
            string catMessage = baseMessage + " Мяу";

            return catMessage;
        }
    }
}
