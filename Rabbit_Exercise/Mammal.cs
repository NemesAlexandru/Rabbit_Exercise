using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabbit_Exercise
{
    enum Gender
    {
        Male, Female
    }

    enum Color
    {
        Blue, Red, Black
    }

    abstract class Mammal
    {
        private string gender;
        private string eyeColor;
        private DateTime birthDate;

        public string Gender {
            get { return gender; }

            set { 
                if (string.IsNullOrEmpty(value.ToString()) || !Enum.IsDefined(typeof(Gender), value))
                {
                    // insert logic
                    throw new ArgumentException("Invalid input, pick gender");

                }
                else {
                    gender = value;
                } 
        
            }
        }

        public string EyeColor
        {
            get { return eyeColor; }

            set
            {
                if (string.IsNullOrEmpty(value.ToString()) || !Enum.IsDefined(typeof(Color), value))
                {
                    // insert logic
                    throw new ArgumentException("Invalid input, pick color");

                }
                else
                {
                    eyeColor = value;
                }

            }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }

            set
            {
                if (value > DateTime.Now)
                {
                    // insert logic
                    throw new ArgumentException("Invalid date, must be in the past");

                }
                else
                {
                    birthDate = value;
                }

            }
        }

        public Mammal(string gender, string eyeColor, DateTime birthDate)
        {
            this.Gender = gender;
            this.EyeColor = eyeColor;
            this.BirthDate = birthDate;

        }


        public abstract void Move();
        public abstract void Sleep();
        public abstract void Eat();
        public int GetAge()
        {
            return DateTime.Now.Year - birthDate.Year;
        }

    }
}
