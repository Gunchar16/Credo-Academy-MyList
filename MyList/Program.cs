using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    public class Program
    {
        public static void Main()
        {
            var StringList = new MyList<string>("Giorgi", "Ioseliani");
            Console.WriteLine($"The Initial StringList:\t\t\t{StringList}");
            StringList.Add("Credo");
            Console.WriteLine($"StringList After Adding:\t\t{StringList}");
            StringList.Remove(1);
            Console.WriteLine($"StringList After Remove At Index(1):\t{StringList}");
            Console.WriteLine($"StringList[0]:\t\t\t\t{StringList[0]}");
            Console.WriteLine(new String('-', 80));


            var IntList = new MyList<int>(new int[] { 1, 6, 7, 2, 6, 8, 1, 2, 5, 7, 16 });
            Console.WriteLine($"The Initial IntList:\t\t\t{IntList}");
            IntList.Add(21);
            Console.WriteLine($"IntList After Adding:\t\t\t{IntList}");
            IntList.Remove(7);
            Console.WriteLine($"IntList After Remove At Index(7):\t{IntList}");
            Console.WriteLine($"IntList[9]:\t\t\t\t{IntList[9]}");
            Console.WriteLine(new String('-', 80));
        }

    }
}
