using System;

namespace Rabbit_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Parse("20.11.2018");

            Rabbit rabbit = new Rabbit("Malesdsfa", "Red", date, "White");


            rabbit.Eat();
            Console.WriteLine("Rabbit's age is " + rabbit.GetAge());
            rabbit.Move();
            rabbit.Sleep();

            Console.WriteLine(rabbit.Gender);
            Console.WriteLine(rabbit.EyeColor);
            Console.WriteLine(rabbit.FurColor);
            Console.WriteLine(rabbit.BirthDate.ToString("dd-MM-yyyy"));
        }
    }
}
