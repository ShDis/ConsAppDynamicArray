using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsAppDynamicArray
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsAppDynamicArray.List<int> list = new ConsAppDynamicArray.List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Remove(3);
            list.RemoveAt(1);
            Console.WriteLine(list.Count); // выводит 3
            Console.WriteLine(list[0]); // выводит 1
            Console.WriteLine(list[1]); // выводит 4
            Console.WriteLine(list[2]); // выводит 5

            Console.ReadKey();
        }
    }
}
