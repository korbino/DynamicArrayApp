using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrayApp
{
    public class DynamicArray<T>
    {

        private int capacity;
        private int logicalSize;

        public DynamicArray()
        {
            capacity = 1;
            T[] dynamicArray = new T[capacity];
            

        }

        
        //Add
        public void Add (T[] dynamicArray, T value)
        {
            //Check if there is fre space in array
            if (logicalSize == capacity)
            {
                Encrease(dynamicArray);
            }

                dynamicArray[logicalSize] = value;
                logicalSize++;
        }
        


        //Insert
        public void Insert(T[] dynamicArray, T value, int index)
        {
            ReleaseIndex(dynamicArray, index);
            dynamicArray[index] = value;  
        }

        //Get
        T Get (T[] dynamicArray, int index)
        {
            return dynamicArray[index];
        }

        //Remove

        //Capacity

        //Size

        //Encrease - encrease array capacity
        T[] Encrease(T[] oldDynamicArray)
        {
            T[] dynamicArray = new T[capacity*2];
            for (int i = 0; i <= capacity; i++)
            {
                dynamicArray[i] = oldDynamicArray[i];
            }
            return dynamicArray;
        }

        ////Swap
        //T[] Swap (T[] dynamicArray, int currentIndex, int nextIndex)
        //{
        //    T tempValue = dynamicArray[currentIndex];
        //    dynamicArray[currentIndex] = dynamicArray[nextIndex];
        //    dynamicArray[nextIndex] = tempValue;
        //    return dynamicArray;

        //}

        //Release index
        T[] ReleaseIndex(T[] dynamicArray, int index)
        {
            //checking if we have full array
            if (logicalSize == capacity)
            {
                Encrease(dynamicArray);
            }

            for (int i=logicalSize; i>=index; i--)
            {
                dynamicArray[i+1] = dynamicArray[i];
            }

            dynamicArray[index] = default(T); //just for visualization that we had release index

            return dynamicArray;
        }
    }
}
