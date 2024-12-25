// See https://aka.ms/new-console-template for more information
using System;

namespace ForLoop
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------1. UYGULAMA-----------------");

            for (int i = 0; i < 10; i++)// Konsol ekranına 10 kere Console.Writeline içerisinde string ifadeyi yazar.
            {
                Console.WriteLine("Kendime inaniyorum, ben bu yazilim isini hallederim!");
            }

            Console.WriteLine("-----------------2. UYGULAMA-----------------");

            for (int j = 1; j <= 20; j++)// Konsol ekranına 1 ile 20 arasındaki sayıları yazdırır.
            {
                Console.WriteLine(j);
            }

            Console.WriteLine("-----------------3. UYGULAMA-----------------");

            for (int k = 1; k <= 20; k++)//konsol ekranına 1 ile 20 arasındaki çift sayıları yazdırır.
            {
                if (k % 2 == 0)
                {
                    Console.WriteLine(k);
                }
            }
            //Konsol ekranina 1 ile 10 arasındaki çift sayılar asagidaki sekilde de yazilabilir.
            //for (int k = 2; k <= 20; k += 2)
            //{
            //    Console.WriteLine(k);

            //}

            Console.WriteLine("-----------------4. UYGULAMA-----------------");

            int sum = 0;
            for (int l = 50; l <= 150; l++)//50 ile 150 arasindaki sayilarin toplamini yazdirir.
            {
                sum += l;

            }
            Console.WriteLine($"50 ile 150 arasindaki sayilarin toplami {sum}");

            Console.WriteLine("-----------------5. UYGULAMA-----------------");

            int sumEven = 0;
            int sumOdd = 0;
            for (int i = 1; i <= 120; i++)// 1 ile 120 arasindaki tek ve cift sayilarin toplamini ayri ayri yazdirir.
            {
                if (i % 2 == 0)
                {
                    sumEven += i;

                }
                else if (i % 2 == 1)
                {
                    sumOdd += i;
                }


            }
            Console.WriteLine($"1 ile 120 arasindaki cift sayilarin toplami {sumEven}\n1 ile 120 arasindaki tek sayilarin toplami {sumOdd} ");
        }

    }
}
