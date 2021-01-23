using System;
using System.Collections.Generic;
using System.Text;

namespace Dictonary
{
    class MyList<T,Y>
    {
        T[] List1;
        Y[] List2;
        public MyList()
        {
            List1 = new T[0];
            List2 = new Y[0];

        }
        public void Add(T list1, Y list2)
        {
            T[] temp1 = new T[List1.Length];
            Y[] temp2 = new Y[List2.Length];

            temp1 = List1;
            temp2 = List2;

            List1 = new T[temp1.Length+1];
            List2 = new Y[temp2.Length+1];

            for (int i = 0; i < temp1.Length; i++)
            {
                List1[i] = temp1[i];
                List2[i] = temp2[i];
            }
            List1[List1.Length - 1] = list1;
            List2[List2.Length - 1] = list2;
        }
        public void Write()
        {
            for (int i = 0; i < List1.Length; i++)
            {
                Console.WriteLine($"{List1[i]} {List2[i]}");
            } 
        }
    }
}
