using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrayApp
{
    class DynamicQueue<T>
    {

        public DynamicArray<T> dynamicQueue;
        private int tail = 0;
        private int head = 0;

        public DynamicQueue()
        {
            dynamicQueue = new DynamicArray<T>();
        }
        
        
        //Enqueue
        public void Enqueue(T value)
        {
            dynamicQueue.Add(value);
            tail++;

        }

        //Dequeue
        public T Dequeue()
        {
            T value = dynamicQueue.Get(head);
            dynamicQueue.Remove(head);
            dynamicQueue.Insert(head, default(T));
            head++;
            return value;
        }

        //IsEmpty
        public bool IsEmpty()
        {
            bool isEmpty;

            if (head==tail)
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
            if(dynamicQueue.logicalSize == dynamicQueue.capacity)
            {
                isFull = true;
            } else
            {
                isFull = false;
            }
            return isFull;
        }

        //Print 

        public void Print()
        {
            for (int i = 0; i <= dynamicQueue.logicalSize - 1; i++)
            {
                Console.Write(dynamicQueue.Get(i));
            }
            Console.WriteLine();
        }
    }
}
