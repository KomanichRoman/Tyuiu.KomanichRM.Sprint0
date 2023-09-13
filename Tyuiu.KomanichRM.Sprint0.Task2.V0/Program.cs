using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KomanichRM.Sprint0.Task2.V0.Lib;

namespace Tyuiu.KomanichRM.Sprint0.Task2.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.GetMessage("Роман"));
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
