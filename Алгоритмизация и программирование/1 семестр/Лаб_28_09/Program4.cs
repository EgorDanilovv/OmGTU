class HelloWorld
{
    static void Main()
    {
        int n;
        Console.WriteLine("Введите пожалуйста количество двальнейших символов");
        n = Convert.ToInt32(Console.ReadLine());
        int aktuelle_Element;
        int anz = 1;
        int ma;
        ma = n;
        int otr=0;
        int vorheriges_Element = 0;
        Console.WriteLine("Начинайте вводить последовательность");
        for (int i = 0; i < n; i++)
        {
            aktuelle_Element = Convert.ToInt32(Console.ReadLine());
            if (aktuelle_Element < 0)
            {
                otr += 1;
            }
            
            if (i == 0)
            {
                vorheriges_Element = aktuelle_Element;
            }
            else
            {
                if ((vorheriges_Element == aktuelle_Element) & (aktuelle_Element<0))
                {
                    anz += 1;
                }
                else
                {
                    if (ma > anz)
                    {
                        ma = anz;
                    }
                    if (aktuelle_Element < 0) { anz = 1;}
                }
            }
            if (ma > anz & i == n - 1)
            {
                ma = anz;
            }
                vorheriges_Element = aktuelle_Element;
        }
        if (otr > 0){
            Console.WriteLine("Задание 4: " + ma);
        }
        else { Console.WriteLine("Отриц чисел нету :(");}
    }
}