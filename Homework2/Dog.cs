using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    public class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age)
        {
        }

        public override string Say()
        {
            string baseMessage = base.Say();
            string dogMessage = baseMessage + " Гав";

            return dogMessage;
        }
    }
}
