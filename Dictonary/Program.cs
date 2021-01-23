using System;

namespace Dictonary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int, string> myList = new MyList<int, string>();
            myList.Add(18,"Halil");
            myList.Add(20, "Mehmet");
            myList.Add(45, "Ali");
            myList.Add(24, "Sefa");
            myList.Add(34, "Ugur");

            myList.Write();


        }
    }
}
