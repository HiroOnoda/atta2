using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class Animal
    {
        public static int count = 0;
        public string name = "spotty";
        public int age = 7;
        public float happines = 0.6f;
        public void print ()
        {
            Console.WriteLine("Name"+name);
            Console.WriteLine("age"+ age);
            Console.WriteLine("happines"+ happines);
        }
    }
    class Program
    {     
        static void Main(string[] args)
        {
            Animal cat = new Animal();
            cat.print();
            Console.
            Animal.count++;

            Animal dog = new Animal();
            dog.print();
            Animal.count++;
            Console.WriteLine(Animal.count);

            Console.ReadKey();
        }

    }
}
