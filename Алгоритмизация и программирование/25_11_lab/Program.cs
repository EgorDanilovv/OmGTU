using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Bibiliotek
    {
        private string adres { set; get; }
        private int kniggi { set; get; }
        private int posititili { set; get; }
        private string FIO {  set; get; }
        private string raion {  set; get; }
        public Bibiliotek(string Adress, int Knigi,  int Posititili, string fio, string Raion) 
        {
            adres = Adress;
            kniggi = Knigi;
            posititili = Posititili;
            FIO = fio;
            raion = Raion;
        }
        public static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Введите количество библиокекк");
            n = Convert.ToInt32(Console.ReadLine());
            Bibiliotek[] vsiainfa = new Bibiliotek[n];
            for (int i = 0; i < n; i++)
            {
                string i1;
                int i2;
                int i3;
                string i4;
                string i5;
                Console.WriteLine($"Введите адрес {i+1} библиотеки");
                i1 = Console.ReadLine();
                Console.WriteLine($"Введите колво книг {i+1} библиотеки");
                
                i2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"колво посетителе {i+1} библиотеки");
                i3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"фио главы {i+1} библиотеки");
                i4 = Console.ReadLine();
                Console.WriteLine($"раййон {i+1} библиотеки");
                i5 = Console.ReadLine();
                vsiainfa[i] = new Bibiliotek(i1, i2, i3, i4, i5);
            }
            foreach (Bibiliotek p in vsiainfa)
            {
                Console.WriteLine("Адрес\t" + p.adres + "\nКол-во книг\t" + p.kniggi + "\nКол-во посетитеое\t" + p.posititili + "\nФИО главы\t" + p.FIO + "\nрайон\t" + p.raion +'\n');
            }
           
            Console.WriteLine("отбор по район");
            string otborr;
            otborr = Console.ReadLine();
            Console.WriteLine("Вот все библиотеки которые подошли под ваши запросы: \n");
            foreach (Bibiliotek p in vsiainfa)
            {
                Otbor_Raion(p);
            }

            Console.WriteLine("отбор по колву поситити");
            int otborp;
            otborp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вот все библиотеки которые подошли под ваши запросы: \n");
            foreach (Bibiliotek p in vsiainfa)
            {
                Otbor_Pos(p)
            }

            Console.WriteLine("отбор по колву книги");
            int otbork;
            otbork = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вот все библиотеки которые подошли под ваши запросы: \n");
            foreach (Bibiliotek p in vsiainfa)
            {
                Otbor_Knig(p);
            }

            Console.WriteLine("отбор по ФИО");
            string otborFIO;
            otborFIO = Console.ReadLine();
            Console.WriteLine("Вот все библиотеки которые подошли под ваши запросы: \n");
            foreach (Bibiliotek p in vsiainfa)
            {
                Otbor_FIO(p);
            }

            Console.ReadKey();
        }
        public Otbor_Raion(Bibiliotek)
        {
            if (otborr == p.raion) { Console.WriteLine("Адрес\t" + p.adres + "\nКол-во книг\t" + p.kniggi + "\nКол-во посетитеое\t" + p.posititili + "\nФИО главы\t" + p.FIO + "\nрайон\t" + p.raion + '\n'); }
        }
        public Otbor_Pos(Bibiliotek)
        {
            if (otborp < p.posititili) { Console.WriteLine("Адрес\t" + p.adres + "\nКол-во книг\t" + p.kniggi + "\nКол-во посетитеое\t" + p.posititili + "\nФИО главы\t" + p.FIO + "\nрайон\t" + p.raion + '\n'); }
        }
        public Otbor_Knig(Bibiliotek)
        {
            if (otbork > p.kniggi) { Console.WriteLine("Адрес\t" + p.adres + "\nКол-во книг\t" + p.kniggi + "\nКол-во посетитеое\t" + p.posititili + "\nФИО главы\t" + p.FIO + "\nрайон\t" + p.raion + '\n'); }

        }
        public Otbor_FIO(Bibiliotek)
        {
            if (otborFIO == p.FIO) { Console.WriteLine("Адрес\t" + p.adres + "\nКол-во книг\t" + p.kniggi + "\nКол-во посетитеое\t" + p.posititili + "\nФИО главы\t" + p.FIO + "\nрайон\t" + p.raion + '\n'); }
        }

    }
}
