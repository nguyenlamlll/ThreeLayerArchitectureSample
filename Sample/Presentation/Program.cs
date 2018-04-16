using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputList = new List<string>();
            for (int i = 0; i < 3; i++)
            {
                string input = Console.ReadLine();
                inputList.Add(input);
            }
            foreach (var item in inputList)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
