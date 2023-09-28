class HelloWorld
{
    static void Main()
    {
        int n;
        Console.WriteLine("Введите пожалуйста количество двальнейших символов");
        n = Convert.ToInt32(Console.ReadLine());
        int aktuelle_Element;
        int anz=1;
        int ma = 0;
        int vorheriges_Element = 0;
        Console.WriteLine("Начинайте вводить последовательность");
        for (int i = 0; i < n; i++)
        {
            aktuelle_Element = Convert.ToInt32(Console.ReadLine());
            if (i == 0)
            {
                vorheriges_Element = aktuelle_Element;
            }
            else
            {
                if (vorheriges_Element == aktuelle_Element)
                {
                    anz += 1;
                    if (ma < anz) {  ma = anz; }
                }
                else
                {
                    anz = 1;
                }
                vorheriges_Element = aktuelle_Element;
            }
        }
        Console.WriteLine("Задание 3: " + ma);
    }
}