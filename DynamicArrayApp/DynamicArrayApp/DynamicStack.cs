using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrayApp
{
    class DynamicStack<T>
    {

        public DynamicArray<T> dynamicStack;

        public DynamicStack(int maxArrayLenght)
        {
            dynamicStack = new DynamicArray<T>();
        }
        
        //Push
        public void Push (T value)
        {
            dynamicStack.Add(value);
        }

        //Pop
        public T Pop ()
        {
            T value = dynamicStack.Get(dynamicStack.logicalSize-1);
            dynamicStack.Remove(dynamicStack.logicalSize-1);
            return value;
        }

        //IsEmpty
        public bool IsEmpty()
        {
            bool isEmpty;
            if (dynamicStack.logicalSize == 0)
            {
                isEmpty = true;
            }
            else
            {
                isEmpty = false;
            }
            
            return isEmpty;
        }

        //IsFull
        public bool IsFull()
        {
            bool isFull;
            if (dynamicStack.logicalSize == dynamicStack.capacity)
            {
                isFull = true;
            }else
            {
                isFull = false;
            }

            return isFull;
        }

        //Peek
        public T Peek()
        {
            T value = dynamicStack.Get(dynamicStack.logicalSize-1);
            return value;
        }

        //Print 

        public void Print()
        {
            for (int i=0; i<=dynamicStack.logicalSize-1; i++)
            {
                Console.Write(dynamicStack.Get(i));
            }
            Console.WriteLine();
        }

    }
}
