using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int j = 106732567; j < 152673836 + 1; j++) { 
                double sqrtt;
                sqrtt = Math.Sqrt(j);
                int deliteli_sch = 0;
                if (Math.Round(sqrtt) == sqrtt)
                {
                    int max_del = 1;
                    for (int i = 2; i < Math.Round(sqrtt)-1; i++)
                    {
                        if (j % i==0)
                        {
                            if (max_del == 1)
                            {
                                max_del = j / i;
                            }
                            deliteli_sch=deliteli_sch+2;
                        }
                    }
                    if (deliteli_sch == 2)
                    {
                        Console.WriteLine($"{j}"+$"    {max_del}");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
