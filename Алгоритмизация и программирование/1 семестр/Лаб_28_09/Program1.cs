class HelloWorld
{
    static void Main()
    {
        int n;
        Console.WriteLine("Введите пожалуйста количество двальнейших символов");
        n = Convert.ToInt32(Console.ReadLine());
        int aktuelle_Element;
        int vorheriges_Element = 0;
        int swh = 0;
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
                if ((aktuelle_Element>=0 & vorheriges_Element<0)| (aktuelle_Element < 0 & vorheriges_Element >= 0))
                {
                    swh+=1;
                }
                vorheriges_Element = aktuelle_Element;
            }
        }
        Console.WriteLine("Задание 1: "+swh);
    }
}
