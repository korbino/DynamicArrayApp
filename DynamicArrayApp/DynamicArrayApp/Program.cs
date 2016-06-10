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
            //Working with Stack
            Console.WriteLine("Working with Stack...\n");

            DynamicStack<int> stack1 = new DynamicStack<int>(1024);
            Random rnd = new Random();

            Console.WriteLine("Is empty - {0}", stack1.IsEmpty());
            Console.WriteLine("Is full - {0}", stack1.IsFull());

            Console.WriteLine("Pushing values");

            for (int i = 0; i < 20; i++)
            {
                stack1.Push(rnd.Next(9));
                stack1.Print();
            }
            stack1.Print();

            Console.WriteLine("Is empty - {0}", stack1.IsEmpty());
            Console.WriteLine("Is full - {0}", stack1.IsFull());
            Console.WriteLine();
            Console.WriteLine("Peek value: {0}", stack1.Peek());
            Console.WriteLine();

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("poped value: {0}", stack1.Pop());
                stack1.Print();
            }
            Console.WriteLine();


            //Working with Queue
            Console.WriteLine("Working with Queue...\n");

            DynamicQueue<int> queue1 = new DynamicQueue<int>(1024);

            Console.WriteLine("Is empty - {0}", queue1.IsEmpty());
            Console.WriteLine("Is full - {0}", queue1.IsFull());

            Console.WriteLine("Enquing values");

            
            for (int i=0; i<20; i++)
            {
                queue1.Enqueue(rnd.Next(9));
                queue1.Print();
            }
            
            Console.WriteLine("Is empty - {0}", queue1.IsEmpty());
            Console.WriteLine("Is full - {0}", queue1.IsFull());

            for (int i = 0; i <20; i++)
            {
                Console.WriteLine("Dequed value: {0}", queue1.Dequeue());
                queue1.Print();
            }
            Console.WriteLine("Is empty - {0}", queue1.IsEmpty());
            Console.WriteLine("Is full - {0}", queue1.IsFull());
            
            
            Console.ReadKey();

        }
    }
}
