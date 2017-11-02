using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objektid
{
    class Program
    {

        static void Main(string[] args)
        {
            /*
            Dog dog1 = new Dog();
            dog1.Age = 99;
            dog1.Color = "Lilla";
            dog1.Name = "Jaan";

            Console.WriteLine("Koera värv on: " + dog1.Color);
            Console.WriteLine("Koera vanus on: " + dog1.Age);
            Console.WriteLine("Koera nimi on: " + dog1.Name);

            Dog dog2 = new Dog();
            Console.WriteLine("Sisesta koera nimi: ");
            dog2.Name = Console.ReadLine();
            Console.WriteLine("Sisesta koera värv: ");
            dog2.Color = Console.ReadLine();
            dog2.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Koera värv on: " + dog2.Color);
            Console.WriteLine("Koera vanus on: " + dog2.Age);
            Console.WriteLine("Koera nimi on: " + dog2.Name);
            */

            Dog dog3 = new Dog();
            Console.WriteLine(dog3.Name);
            Console.WriteLine(dog3.Color);
            Console.WriteLine(dog3.Age);
            dog3.Bark();
            Console.WriteLine("Koera tegelik vanus on: ") + dog3.calculatingDogYears());
            
        }
    }
}


