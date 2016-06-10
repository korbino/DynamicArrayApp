﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrayApp
{
    class DynamicArray<T>
    {

        private int capacity;
        public int logicalSize;
        private T[] dynamicArray;

        public DynamicArray()
        {
            capacity = 1;
            dynamicArray = new T[capacity];
            

        }

        
        //Add
        public void Add (T value)
        {
            //Check if there is fre space in array
            if (logicalSize==capacity)
            {
                //need to encrease size
                dynamicArray = Encrease(dynamicArray);
            }
                
                dynamicArray[logicalSize] = value;
                logicalSize++;
            
        }
        


        //Insert
        public void Insert(int index, T value)
        {
            //checking if no need to encrease array befor shifting
            if (logicalSize == capacity)
            {
                //need to encrease size
                dynamicArray = Encrease(dynamicArray);
            }

            //Releasing Index by shifting elements in array
            for (int i=logicalSize; i>=index; i--)
            {
                dynamicArray[i + 1] = dynamicArray[i];
            }

            dynamicArray[index] = value;
            logicalSize++;
        }

        //Get
        public T Get(int index)
        {
            T value = dynamicArray[index];
            return value;
        }

        //Remove
        public void Remove(int index)
        {
            //removing element by shifting back elements
            for(int i=index; i<=logicalSize; i++)
            {
                dynamicArray[i] = dynamicArray[i + 1];
            }
            logicalSize--;

        }

        //Capacity

        //Size

        //Encrease - encrease array capacity

        T[] Encrease(T[] oldDynamicArray)
        {
            T[] dynamicArray = new T[capacity*2];
            for (int i = 0; i <= oldDynamicArray.Length-1; i++)
            {
                dynamicArray[i] = oldDynamicArray[i];
            }
            capacity = capacity * 2;
            return dynamicArray;
        }

    }
}