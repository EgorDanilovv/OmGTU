using System;
using System.Text.RegularExpressions;

namespace appclass
{
    class Person
    {
        private string name;
        private int year;
        private string group;
        // Конструктор класса
        public Person(string Name, int Year, string Group)
        {
            name = Name;
            year = Year;
            group = Group;
        }
        public static void Main()
        {
            Console.WriteLine("Сколько человек?");
            int n = Convert.ToInt32(Console.ReadLine());
            Person [] people = new Person[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"ФИО персонажа N{i+1}");
                string FIO;
                FIO=Console.ReadLine();
                Console.WriteLine($"Возраст персонажа N{i+1}");
                int AGE;
                AGE = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Группа персонажа N{i+1}");
                string GR;
                GR = Console.ReadLine();
                people[i] = new Person(FIO, AGE, GR);

            }
            Console.WriteLine("\nВсе персоны");
            foreach (Person p in people)
            {
                Console.WriteLine("Имя\t" + p.name + "\nГод др\t" + p.year + "\nГруппа\t" + p.group + "\n");
            }
            int year_otbor;
            Console.WriteLine("Отбор по году:");
            year_otbor = Convert.ToInt32(Console.ReadLine());
            foreach(Person p in people)
            {
                if (p.year == year_otbor) { Console.WriteLine("Имя\t" + p.name + "\nГод др\t" + p.year + "\nГруппа\t" + p.group + "\n"); }
            }
            string group_otbor;
            Console.WriteLine("Отбор по гроуп");
            group_otbor = Console.ReadLine();
            foreach (Person p in people)
            {
                if (p.group == group_otbor) { Console.WriteLine("Имя\t" + p.name + "\nГод др\t" + p.year + "\nГруппа\t" + p.group + "\n"); }
            }
            Console.ReadKey();
        }
    }
}

/* 
Необходимо создать массив из экземпляров класса со следующей структурой: 
ФИО, год рождения, группа
В классе должен быть реализован 
1: конструкторы свойства - геттеры, сеттеры
2: метод выборки по году рождения и метод выборки по группе
Класс можно прописывать там, где мейн
Дополнительный файл не делать
    */