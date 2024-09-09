using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_52_Keywords_Section_52_17
{
    internal class Person
    {
        readonly string _name;
        readonly string _surname = "Surname";

        Person(string name)
        {
            _name = name;
        }


        private void ChangeName()
        {
            //_name = "another name";
            //_surname = "another name";
        }


        public class Car
        {
            public double Speed { get; set; }

            private readonly Car car = new Car();

            private void SomeMethod()
            {
                car.Speed = 100;
            }

        }



    }
}
