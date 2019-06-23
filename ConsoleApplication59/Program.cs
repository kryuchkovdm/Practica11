using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication50
{
    class Program
    {
        static void choose(int left, out int number)
        {
            number = 0;
            bool flag = true;
            while (flag == true)
            {//проверка правильности ввода
                Try(out number);
                if (number >= 1 && number <= left)
                {
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Неверное значение! Введите целое число от 1 до {0}", left);

                }
            }
        }
        static void Try(out int inputnumber)//проверка правильности ввода числа
        {
            inputnumber = 0;
            bool flag = true;
            while (flag == true)
            {
                try
                {

                    string x = Console.ReadLine();
                    inputnumber = int.Parse(x);
                    flag = false;
                }
                catch
                {
                    Console.WriteLine("Неверное значение! Введите целое число");
                    flag = true;
                }
            }
        }

        static void Main(string[] args)
        {


            int number1_2;

            Console.WriteLine("Введите 1, если хотите закодировать сообщение");
            Console.WriteLine("Введите 2, если хотите декодировать сообщение");
            choose(2, out number1_2);
            switch (number1_2)
            {
                case 1:
                    Console.WriteLine("Введите k");
                    Console.Write("k=");
                    int k;
                    bool f1 = true;
                    Try(out k);
                    while (f1 && k < 1)
                    {
                        Console.WriteLine("Неверное значение! Введите положительное число");
                        Try(out k);
                        if (k >= 1)
                        {
                            f1 = false;
                        }
                    }
                    Random rnd = new Random();
                    int[] mas = new int[k];
                    int f;
                    Console.WriteLine("Перестановка");
                    for (int i = 0; i < k; i++)
                    {
                        f = rnd.Next(1, k);
                        f1 = true;
                        while (f1)
                        {
                            if (mas.Contains(f))
                            {
                                f = rnd.Next(1, k + 1);
                            }
                            else
                            {
                                mas[i] = f;
                                Console.Write("{0} ", f);
                                f1 = false;
                            }
                        }
                    }
                    Console.WriteLine("\nВведите текст");
                    string text = Console.ReadLine();
                    string text2, text3;
                    f1 = true;
                    Console.WriteLine("\nИзмененный текст");
                    while (text.Length > 0 && f1)
                    {

                        while (f1)
                        {
                            if (text.Length < k)
                            {
                                while (text.Length <= k)
                                {
                                    text += " ";

                                }
                                f1 = false;
                            }
                            text2 = text.Substring(0, k);
                            text3 = "";
                            for (int i = 0; i < k; i++)
                            {
                                text3 += text2[mas[i] - 1];
                            }
                            Console.Write(text3);

                            text = text.Substring(k);
                        }
                    }
                    Console.WriteLine("\nнажмите Enter чтобы выйти");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("Введите k");
                    Console.Write("k=");
                    int k1;
                    bool f2 = true;
                    Try(out k1);
                    while (f2 && k1 < 1)
                    {
                        Console.WriteLine("Неверное значение! Введите положительное число");
                        Try(out k1);
                        if (k1 >= 1)
                        {
                            f2 = false;
                        }
                    }
                    int[] mas1 = new int[k1];
                    int n;

                    for (int i = 0; i < k1; i++)
                    {
                        f2 = true;
                        while (f2)
                        {
                            Console.WriteLine("\nВведите {0} элемент перестановки", i + 1);
                            choose(k1, out n);
                            if (!mas1.Contains(n))
                            {
                                mas1[i] = n;

                                f2 = false;
                            }
                            else
                            {
                                Console.WriteLine("Элемент уже содержится, введите другой");

                            }
                        }

                    }
                    Console.WriteLine("\nПерестановка");
                    Console.WriteLine();
                    for (int i = 0; i < k1; i++)
                    {
                        Console.Write("{0} ", mas1[i]);
                    }
                    Console.WriteLine("\nВведите текст");
                    string text4 = Console.ReadLine();
                    string text5, text6;
                    f2 = true;
                    Console.WriteLine("\nИзмененный текст");
                    while (text4.Length > 0 && f2)
                    {

                        while (f2)
                        {
                            if (text4.Length < k1)
                            {
                                while (text4.Length <= k1)
                                {
                                    text4 += " ";

                                }
                                f2 = false;
                            }
                            text5 = text4.Substring(0, k1);
                            text6 = "";
                            for (int i = 1; i <= k1; i++)
                            {
                                for (int j = 0; j < k1; j++)
                                {
                                    if (mas1[j] == i)
                                    {
                                        text6 += text5[j];
                                    }
                                }

                            }
                            Console.Write(text6);

                            text4 = text4.Substring(k1);
                        }
                    }
                    Console.WriteLine("\nнажмите Enter чтобы выйти");
                    Console.ReadKey();
                    break;

            }


        }
    }
}

