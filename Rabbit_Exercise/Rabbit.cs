using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabbit_Exercise
{
    enum FurColor
    {
        White, Brown, Black, Grey

    }

    class Rabbit : Mammal
    {

        private string furColor;
        public string FurColor {
            get { return furColor; }

            set {
                if (string.IsNullOrEmpty(value.ToString()) || !Enum.IsDefined(typeof(FurColor), value))
                {
                    // insert logic
                    throw new ArgumentException("Invalid input, pick fur color");

                }
                else
                {
                    furColor = value;
                }

            } 
        }

        public Rabbit(string gender, string eyeColor, DateTime birthDate, string furColor) : base(gender, eyeColor, birthDate)
        {
            this.FurColor = furColor;

        }

        public override void Eat()
        {
            Console.WriteLine("Rabbit eats");
        }

        public override void Move()
        {
            Console.WriteLine("Rabbit jumps");
        }

        public override void Sleep()
        {
            Console.WriteLine("Rabbit sleeps like a rabbit");
        }
    }
}
