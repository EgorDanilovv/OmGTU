class HelloWorld
{
    static void Main()
    {
        int n;
        Console.WriteLine("Введите пожалуйста количество двальнейших символов");
        n = Convert.ToInt32(Console.ReadLine());
        int aktuelle_Element;
        int vorheriges_Element = 0;
        int vorheriges_Element2 = 0;
        int anz=0;
        Console.WriteLine("Начинайте вводить последовательность");
        for (int i = 0; i < n; i++)
        {
            aktuelle_Element = Convert.ToInt32(Console.ReadLine());
            if (i == 0)
            {
                vorheriges_Element2 = aktuelle_Element;
            }
            if (i == 1)
            {
                vorheriges_Element = aktuelle_Element;
            }
            if (i == n-1)
            {

            }
            else
            {
                if (vorheriges_Element< vorheriges_Element2 & vorheriges_Element<aktuelle_Element)
                {
                    anz += 1;
                }
            }
        }
        Console.WriteLine("Задание 2: " + anz);
    }
}