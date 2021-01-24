using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation
{
    class GameList<T>
    {
        T[] array;
        T[] tempArray;
        public GameList()
        {
            array = new T[0];
        }

        public void Add(T item)
        {
            tempArray = array;
            array = new T[array.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                array[i] = tempArray[i];
            }

            array[array.Length - 1] = item;
        }

        public int Length
        {
            get { return array.Length; }
        }

        public T[] Game
        {
            get { return array; }
        }
    }
}