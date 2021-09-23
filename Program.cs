using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car("Black", 50, "Crossover");
            string color = car.Color;
            color = car.Color;
            car.Color = "Red";
            Console.WriteLine($"The color of car {car.Color}");
            int count = car.Count;
            count = car.Count;
            car.Count = 110;
            Console.WriteLine($"Produce {car.Count} cars");
            string body = car.Body;
            body = car.Body;
            car.Body = "Sedan";
            Console.WriteLine($"Body of the car {car.Body}");

            Bmw bmw = new Bmw("Blue", 75, "Crossover","X5", "Harman Kardon");
            string colorBmw = bmw.Color;
            Console.WriteLine($"The color of car {bmw.Color}");
            int countBmw = bmw.Count;
            Console.WriteLine($"Produce {bmw.Count} cars");
            string bodyBmw = bmw.Body;
            Console.WriteLine($"Body of the car {bmw.Body}");

            Lamborghiny lamborghiny = new Lamborghiny("Yellow", 34, "Supercar", 700, 460);
            lamborghiny.Create();
            string colorL = lamborghiny.Color;
            Console.WriteLine($"The color of car {lamborghiny.Color}");
            int countL = lamborghiny.Count;
            Console.WriteLine($"Produce {lamborghiny.Count} cars");
            string bodyL = lamborghiny.Body;
            Console.WriteLine($"Body of the car {lamborghiny.Body}");

            Console.ReadLine();
        }
    }
}
