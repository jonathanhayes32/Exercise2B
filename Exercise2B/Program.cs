using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2B
{
    class Program
    {
        static void Main(string[] args)
            
        {
            AnimalSound();

        }
        public static void AnimalSound(string animal = "Cat", string sound = "meow")
          
        {
            Console.WriteLine("what sound does a cat make");
            Console.ReadLine();
            Console.WriteLine($"the {animal} goes \"{sound}\" ");
            Console.ReadLine();

            

        }


    }

}
