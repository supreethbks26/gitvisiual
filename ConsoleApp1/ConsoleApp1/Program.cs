using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Program p = new Program();
            Console.WriteLine(p.add(10, 5));
        }

        public int add(int x, int y)
        {
            return x + y;
        }
    }
}
