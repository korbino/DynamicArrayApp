using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicArray<int> array1 = new DynamicArray<int>();
            array1.Add(5);
            array1.Add(7);
            array1.Add(2);
            array1.Add(9);
            array1.Add(4);
            array1.Add(2);
            array1.Add(4);
            array1.Add(1);

            //printing array
            for (int i =0; i<array1.logicalSize; i++)
            {
                Console.Write(array1.Get(i));
            }
            Console.WriteLine();
            //inserting ...

            Console.WriteLine("Inserting");
            array1.Insert(3, 8);
            
            //printing array
            for (int i = 0; i < array1.logicalSize; i++)
            {
                Console.Write(array1.Get(i));
            }
            Console.WriteLine();


            Console.WriteLine("Removing");
            array1.Remove(5);
            //printing array
            for (int i = 0; i < array1.logicalSize; i++)
            {
                Console.Write(array1.Get(i));
            }
            Console.WriteLine();


            Console.ReadKey();

        }
    }
}
