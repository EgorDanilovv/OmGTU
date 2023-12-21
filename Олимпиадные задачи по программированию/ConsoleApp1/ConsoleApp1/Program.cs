using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace ConsoleApp1
{
    internal class Program
    {
        public class Animals
        {
            public string Name { get; set; }
            public int Year_of_Birth {  get; set; }
            public Animals(string n, int y) { Name = n; Year_of_Birth = y; }
        }
        public class dogs : Animals
        {
            public string Poroda { get; set; }
            public string Color { get; set; }
            public dogs(string a, string b, string n, int y ): base(n,y) { Poroda = a; Color = b; }
            public void Info() { Console.WriteLine("Имя" + Name + "\n год рождения" + Year_of_Birth + "\n порода" + Poroda + "\n Окрас" + Color); }
            public void Selection(dogs i, string c) { if (i.Color == c) { i.Info(); } }
        }
        public class cats: Animals
        {
            public string Poroda { get; set; }
            public string Color { get; set; }
            public cats(string d, string c, string n, int y): base(n,y) { Poroda = d; Color = c; }
            public void Info() { Console.WriteLine("Имя" + Name + "\n год рождения" + Year_of_Birth + "\n порода" + Poroda + "\n Окрас"+ Color); }
            public void Selection (cats i, string c) { if (i.Color == c) { i.Info(); } }
            public void Swag (cats i, string a) { i.Poroda = a;}
        }
        static void Main(string[] args)
        {
            dogs[] dog = new dogs[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < dog.Length; i++) { string a = Console.ReadLine(); string b = Console.ReadLine(); string n = Console.ReadLine(); int y = Convert.ToInt32(Console.ReadLine()); dog[i] = new dogs(a, b, n, y); }
            cats[] cat = new cats[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < cat.Length; i++) { string d = Console.ReadLine(); string c = Console.ReadLine(); string n = Console.ReadLine(); int y = Convert.ToInt32(Console.ReadLine()); cat[i] = new cats(d, c, n, y); }
            string Selection_Color_Dog = Console.ReadLine();
            string Poroda_Cat = Console.ReadLine();
            string Poroda_Cat_Posle = Console.ReadLine();
            Console.ReadKey();
        }
    }
} */
/* будет класс кого мы возьмем класс животные точно со следующими полями: наименование, год рождения 
 * 2 наследника: кошечки собачки, для собачко: порода, окраз; кошечки: порода, окраз
 * предусмотреть: заполнение, конструкторы свойства в мэйне - массивы, собачки - выборка по породе, кошка - окраз, учесть то что может поменять породу кошка.
 29.09 +
 11.11 +
 25.11 +


09.10 подстроки
туристы 11.11 
11.12 -
Pracktica 14.09
02.10 кратность
30.10Мышка новая вторая которая -
 */
using System;

class Inheritance
{
    class Pet
    {
        public string Name;
        public string BirthDate;

        public Pet(string name, string birthDate)
        {
            Name = name;
            BirthDate = birthDate;
        }
    }

    class Dog : Pet
    {
        public string Breed;
        public string Color;

        public Dog(string name, string birthDate, string breed, string color) : base(name, birthDate)
        {
            Breed = breed;
            Color = color;
        }
    }

    class Cat : Pet
    {
        public string Breed;
        public string Color;

        public Cat(string name, string birthDate, string breed, string color) : base(name, birthDate)
        {
            Breed = breed;
            Color = color;
        }

        public void ChangeBreed(string newBreed)
        {
            Breed = newBreed;
        }
    }

    static void Main()
    {
        Dog[] dogArray = new Dog[5] {
            new Dog("Гав", "2023", "хаски", "белый"),
            new Dog("Лайка", "2009", "коли", "белый"),
            new Dog("Желтуха", "2016", "лабрадор", "рыжий"),
            new Dog("Малыш", "2020", "боксер", "коричневый"),
            new Dog("прыжок", "2021", "пудель", "серый"),
        };

        Cat[] catArray = new Cat[5] {
            new Cat("Мур", "2010", "большеглазая", "серый"),
            new Cat("Мурмяуич", "2023", "сибирская", "белый"),
            new Cat("вася", "2020", "сфинкс", "черный"),
            new Cat("петя", "2001", "веслоухая", "белый"),
            new Cat("маруся", "2005", "черная", "черный"),
        };

        Cat randomCat = catArray[1];

        Console.WriteLine("{0} {1}", randomCat.Name, randomCat.Breed);
        randomCat.ChangeBreed("Word");
        Console.WriteLine("{0} {1}", randomCat.Name, randomCat.Breed);

        Console.WriteLine("Введите породу искомой собаки:");
        string dogBreed = Console.ReadLine();

        for (int i = 0; i < dogArray.Length; i++)
        {
            Dog dog = dogArray[i];
            if (dog.Breed == dogBreed)
            {
                Console.WriteLine(dog.Name);

            }
        }

        Console.WriteLine();

        Console.WriteLine("Введите окрас искомой кошки:");
        string catColor = Console.ReadLine();

        for (int i = 0; i < catArray.Length; i++)
        {
            Cat cat = catArray[i];
            if (cat.Color == catColor)
            {
                Console.WriteLine(cat.Name);

            }
        }
        Console.ReadKey();

    }
}