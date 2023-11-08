using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_14
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            List<Car> carList = new List<Car>()
            {
                new Car("lada", "vesta", 2021, "red", 1250000),
                new Car("lada", "niva", 2020, "green", 1400000),
                new Car("lada", "vesta", 2021, "white", 1500000),
                new Car("lada", "vesta", 2022, "blue", 1600000),
                new Car("lada", "vesta", 2023, "red", 1200000),
                new Car("lada", "vesta", 2019, "red", 1100000),

            };
            int choice = 0;
            do
            {
                Console.WriteLine("Введите номер пункта меню: ");
                Console.WriteLine("1. Добавление машины в список.");
                Console.WriteLine("2. Сортировать по марке автомобиля.");
                Console.WriteLine("3. Сортировать по цене автомобиля.");
                Console.WriteLine("4. Сортировать по цвету автомобиля.");
                Console.WriteLine("5. Выход.");

                
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Console.Write("Введите марку автомобиля: ");
                    string mark = Console.ReadLine();
                    Console.Write("Введите модель автомобиля: ");
                    string model = Console.ReadLine();
                    Console.Write("Введите год выпуска автомобиля: ");
                    int yearOfRelease = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите цвет автомобиля: ");
                    string color = Console.ReadLine();
                    Console.Write("Введите цену автомобиля: ");
                    double price = Convert.ToDouble(Console.ReadLine());
                    carList.Add(new Car(mark, model, yearOfRelease, color, price));
                }else if(choice == 2)
                {
                    var query = from car in carList orderby car.Mark select car;
                    foreach(var car in query)
                    {
                        Console.WriteLine(car.ToString());
                    }
                }
                else if (choice == 3)
                {
                    var query = from car in carList orderby car.Price select car;
                    foreach (var car in query)
                    {
                        Console.WriteLine(car.ToString());
                    }
                }
                else if (choice == 4)
                {
                    var query = from car in carList orderby car.Color select car;
                    foreach (var car in query)
                    {
                        Console.WriteLine(car.ToString());
                    }
                }
                else if (choice == 5)
                {
                    break;
                }

            } while (true);


        }

        public static void Task_1()
        {
            Customer customer1 = new Customer(1, "Chendler bing", "Ekaterinburg");
            Customer customer2 = new Customer(2, "Rachel Grin", "Perm");
            Customer customer3 = new Customer(3, "Joe Tribiani", "Ekaterinburg");
            Customer customer4 = new Customer(4, "Ross Geller", "Ekaterinburg");
            Customer customer5 = new Customer(5, "Fuibi Buffe", "Ekaterinburg");
            Customer customer6 = new Customer(6, "Ganter Jons", "Ekaterinburg");



            Order order1 = new Order(1, new DateTime(), customer1);
            Order order2 = new Order(2, new DateTime(), customer2);
            Order order3 = new Order(3, new DateTime(), customer3);
            Order order4 = new Order(4, new DateTime(), customer4);
        }

        
    }
}
