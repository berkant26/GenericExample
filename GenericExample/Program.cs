using System;

namespace GenericExample
{
    class Program
    {
        static void Main(string[] args)
        {
            MyGeneric<string> citys = new MyGeneric<string>();
            citys.Add("Eskisehir");
            citys.Add("New york");
            citys.Add("Dortmund");
            Console.WriteLine(citys.Count);
            
        }
    }
}
