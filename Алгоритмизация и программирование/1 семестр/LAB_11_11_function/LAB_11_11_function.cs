using System;
using System.IO.Pipes;

class Programm
{
    static void Main()
    {

        Console.WriteLine("строк будет");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("столбцов будет");
        int m = Convert.ToInt32(Console.ReadLine());
        int[,] mas = new int[n, m];
        Massiv(n, m, mas);
        Pervoee(n, m, mas);
        Vtoroee(n, m, mas);
        Tretiee(n, m, mas);
    }
    static void Massiv(int n, int m, int[,] result)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                result[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
    static void Pervoee(int n, int m, int[,] result)
    {
        for (int i = 0; i < n; i++)
        {
            int max = int.MinValue;
            for (int j = 0; j < m; j++)
            {
                if (result[i, j] % 2 == 0 && result[i, j] > max)
                {
                    max = result[i, j];
                }
            }
            if (max == int.MinValue)
            {
                Console.WriteLine($"Задание N1, строка {i + 1}, Нет %2");
            }
            else { Console.WriteLine($"Задание N1, строка {i + 1}, макс = {max}"); }
        }
    }
    static void Vtoroee(int n, int m, int[,] result)
    {
        int[,] Perevernutoe = new int[m, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Perevernutoe[j, i] = result[i, j];
            }
        }
        for (int k = 0; k < m; k++)
        {
            int countstr = 0;
            for (int l = 0; l < n; l++)
            {
                if (Perevernutoe[k, l] != 0)
                {
                    countstr++;
                }
            }
            Console.WriteLine($"Задание N2, количество ненулевых жлементов в {k + 1} строке:{countstr}");
        }
    }
    static void Tretiee(int n, int m, int[,] result)
    {
        int[,] Perevernutoe = new int[m, n];
        int[,] Peresobiraem = new int[m, n];
        int[,] PP = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Perevernutoe[j, i] = result[i, j];
            }
        }
        for (int l = 0; l < m; l++)
        {
            if (m % 2 == 0 || l != m - 1)
            {
                for (int k = 0; k < n; k++)
                {
                    if (l % 2 != 0)
                    {
                        Peresobiraem[l, k] = Perevernutoe[l - 1, k];
                    }
                    else
                    {
                        Peresobiraem[l, k] = Perevernutoe[l + 1, k];
                    }
                }
            }
            else
            {
                for (int o = 0; o < n; o++)
                    Peresobiraem[l, o] = Perevernutoe[l, o];
            }
        }

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                PP[j, i] = Peresobiraem[i, j];
            }
        }
        Console.WriteLine("Задание N3:");
        for (int l = 0; l < n; l++)
        {
            for (int k = 0; k < m; k++)
            {
                Console.Write($" {PP[l, k]}");
            }
            Console.WriteLine("");
        }
    }
}
/*
для заданного массива размерность n×m определить 
1)  максимальный среди чётных элементов в каждой строке
2) количество ненулевых элементов в каждом столбце
3) программу преобразования массива по следующему принципу
первый столбец меняется с элементами второго столбца
третий столбец меняется с четвёртым и так далее
ограничения: 
заполнение массива функцией, как и все остальное
 */