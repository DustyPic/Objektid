using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objektid
{
    class Dog : Mammal
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }
        public string realyears { get; set; }
        public Dog()
    {
        Name: Jaan
        Age: 99
        Color: Purple
        Bark();
    }
        public int calculatingDogYears()
        {
            var realyears = Age * 7;
            return realyears;
        }
        public void Bark();
        {
        Console.WriteLine("Auh, auh!!");
            }
}
