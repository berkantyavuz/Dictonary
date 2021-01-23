using System;

namespace DictonaryList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int, string> myList = new MyList<int, string>();
            myList.Add(15, "Ali");
            myList.Add(45, "Hüseyin");
            myList.Add(24,"Sefa");

            myList.Write();

        }
    }
}
