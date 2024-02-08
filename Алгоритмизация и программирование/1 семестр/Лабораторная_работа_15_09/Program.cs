using System;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;

class HelloWorld
{
    static void Main()
    {
        int anzahl_der_Elemente;
        Console.WriteLine("Введите пожалуйста количество двальнейших символов");
        anzahl_der_Elemente = Convert.ToInt32(Console.ReadLine());
        int aktuelle_Element;
        int vorheriges_Element=0;
        int anzahl_True_1 = 0;
        int min_Element = 0;
        int anzahl_True_2 = 0;
        int anzahl_True_3 = 0;
        Console.WriteLine("Начинайте вводить последовательность");
        for (int i = 0; i < anzahl_der_Elemente;i++)
        {
            aktuelle_Element = Convert.ToInt32(Console.ReadLine());
            if (i == 0)
            {
                vorheriges_Element = aktuelle_Element;
                min_Element = aktuelle_Element;
            }
            else
            {
                if ((vorheriges_Element + aktuelle_Element) % 3 == 0)
                {
                    anzahl_True_3 += 1;
                }
                if ( vorheriges_Element < aktuelle_Element)
                {
                    anzahl_True_1 += 1;
                }
                else if (vorheriges_Element > aktuelle_Element)
                {
                    if (aktuelle_Element < min_Element)
                    {
                        anzahl_True_2 += 1;
                        min_Element = aktuelle_Element;
                    }
                }
                vorheriges_Element = aktuelle_Element;
            }
        }
        Console.WriteLine("Ответ на первую задачу из второго блока: " + anzahl_True_1);
        Console.WriteLine("Ответ на вторую задачу из второго блока: " + anzahl_True_2);
        Console.WriteLine("Ответ на третью задачу из второго блока: " + anzahl_True_3);
    }
}