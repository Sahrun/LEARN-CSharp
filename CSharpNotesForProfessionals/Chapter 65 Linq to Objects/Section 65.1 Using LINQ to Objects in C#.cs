using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_65_Linq_to_Objects
{
    public class Section_65_1
    {
        public Section_65_1()
        {
            string[] cars = { "VW Golf",
                             "Opel Astra",
                            "Audi A4",
                            "Ford Focus",
                            "Seat Leon",
                            "VW Passat",
                            "VW Polo",
                            "Mercedes C-Class" };

            var list = from car in cars
                           // where car.Contains("VW")
                       orderby car ascending
                       select car;

            StringBuilder sb = new StringBuilder();

            foreach (var car in list)
            {
                sb.Append(car.ToString() + "\n");
            }

            Console.WriteLine(sb.ToString());


            var car1 = new Car("VW Golf", 270952);
            var car2 = new Car("Opel Astra", 56079);
            var car3 = new Car("Audi A4", 52493);
            var car4 = new Car("Ford Focus", 51677);
            var car5 = new Car("Seat Leon", 42125);
            var car6 = new Car("VW Passat", 97586);
            var car7 = new Car("VW Polo", 69867);
            var car8 = new Car("Mercedes C-Class", 67549);
            var cars1 = new List<Car> { car1, car2, car3, car4, car5, car6, car7, car8 };
            var list1 = from car in cars1
                        select car.Name;

            foreach (var entry in list)
            {
                Console.WriteLine(entry);
            }

            var listShort = from car in cars1
                            where car.UnitsSold > 60000
                            orderby car.UnitsSold descending
                            select car;
            sb = new StringBuilder();

            foreach (var car in listShort)
            {
                sb.AppendLine($"{car.Name} - {car.UnitsSold}");
            }

            Console.WriteLine(sb.ToString());

            listShort = from car in cars1
                        where car.UnitsSold % 2 != 0
                        orderby car.UnitsSold ascending
                        select car;

            sb = new StringBuilder();

            foreach (var car in listShort)
            {
                sb.AppendLine($"{car.Name} - {car.UnitsSold}");
            }

            Console.WriteLine(sb.ToString());
        }
    }

    public class Car
    {
        public string Name { get; private set; }
        public int UnitsSold { get; private set; }
        public Car(string name, int unitsSold)
        {
            Name = name;
            UnitsSold = unitsSold;
        }
    }
}
