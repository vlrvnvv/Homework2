using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    public abstract class Animal
    {
        private int _health;

        public string Name { get; }

        public int Age { get; }

        public bool IsAlive 
        { 
            get 
            {
                return _health > 0;
            } 
        } 

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
            _health = 100;
        }

        public void Feed(int foodCount)
        {
            _health += foodCount;
        }

        public void Punish(int punchCount)
        {
            _health -= punchCount;
        }

        public virtual string Say()
        {
            return $"Имя: {Name} Возраст: {Age}";
        }

        public Color GetHealthIndicator()
        {
            if (_health < 50)
                return Color.White; 
            
            return Color.Green;
        }

    }
}
