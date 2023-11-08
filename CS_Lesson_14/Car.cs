using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_14
{
    internal class Car
    {
        public string Mark { get; set; }
        public string Model { get; set; }
        public int YearOfRelease { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }

        public Car(string mark, string model, int yearOfRelease, string color, double price)
        {
            Mark = mark;
            Model = model;
            YearOfRelease = yearOfRelease;
            Color = color;
            Price = price;
        }

        public override string ToString()
        {
            return "Марка: " + Mark + 
                    "\nМодель: " + Model + 
                    "\nДата выпуска: " + YearOfRelease +
                    "\nЦвет: " + Color +
                    "\nЦена: " + Price;
        }
    }
}
