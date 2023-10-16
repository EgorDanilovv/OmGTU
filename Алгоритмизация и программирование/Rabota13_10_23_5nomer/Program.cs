using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace OmGTU
{
    internal class First
    {
        static void Main(string[] args)
        {
            int n, m;
            m = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            int[,] mass = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mass[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }




            int k3, sum2, pro2, nul;
            int[,] five = new int[n, 3];
            k3 = 0;
            for (int i = 0; i < n - 1; i++)
            {
                nul = 0;
                pro2 = 1;
                sum2 = 0;
                for (int j = 0; j < m; j++)
                {
                    if (mass[i, j] == 0) nul++;
                    pro2 = pro2 * mass[i, j];
                    sum2 += mass[i, j];
                }
                five[i, 0] = nul;
                five[i, 1] = pro2;
                five[i, 2] = sum2;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = i; (j < n - 1); j++)
                {
                    if ((five[i, 0] == five[j, 0]) && (five[i, 1] == five[j, 1]) && (five[i, 2] == five[j, 2])) k3++;
                }
            }
            Console.WriteLine("Количество пар строк, состоящих из одних элементов равно: " + k3);
        }
    }
}