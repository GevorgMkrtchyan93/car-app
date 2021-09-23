using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    class Lamborghiny : Car
    {
        public Lamborghiny(string color, int count, string bodi, int hp, int maxSpeed) : base("Yellow", 34, "Supercar")
        {
            _color = color;
            _count = count;
            _body = bodi;
            _hp = hp;
            _maxSpeed = maxSpeed;
        }

        public string _color;
        private int _count;
        private string _body;
        private int _hp;
        private int _maxSpeed;

        public void Create()
        {

            if (_hp >= 700 && _maxSpeed == 360)
            {
                Console.WriteLine($"The Lamborgini has {_hp} hp and a top speed of {_maxSpeed} k/h");
            }
            if (_hp >= 700 && _maxSpeed < 300)
            {
                Console.WriteLine("We will not produce this car");

            }

            if (_hp >= 700 && _maxSpeed > 360)
            {
                Console.WriteLine("It is a very good car,it is wort increasing the production");
            }
        }

    }
}
