using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku;
            Console.Write("Anna luku > ");
            luku = int.Parse(Console.ReadLine());
            
            switch(luku);
            {
                ykkonen1: Console.WriteLine("yksi"); break;
                kakkonen2: Console.WriteLine("kaksi"); break;
                kolmonen: Console.WriteLine("kolme"); break;
                perus: Console.WriteLine("joku muu numero"); break;

            }
            Console.ReadLine();
        }
    }
}
