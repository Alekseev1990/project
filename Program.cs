using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод строк с клавиатуры и образование нового массива

            string[] RES; // ссылка на массив строк
            int count; // текущее количество строк в массиве
            string s;
            string[] RES2; // дополнительная переменная-ссылка - сохраняет старый массив строк

            // Цикл ввода строк
            Console.WriteLine("Enter strings:");

            count = 0; // обнулить количество строк
            RES = new string[count]; // выделить память для 0 строк

            do
            {
                s = Console.ReadLine();

                // Выход из заполнения массива по пустой строке
                if (s != "")
                {
                    // если строка не пустая, то добавить строку в массив
                    count++;

                    // предварительно выделить память для нового массива в котором на 1 элемент больше
                    RES2 = new string[count];

                    // скопировать старый массив в новый
                    for (int i = 0; i < RES2.Length - 1; i++)
                        RES2[i] = RES[i];

                    // добавить последнюю введенную строку в массив RES2
                    RES2[count - 1] = s;

                    // Освобождать память, предварительно выделенную под RES не нужно,
                    // этим занимается сборщик мусора

                    // перенаправить ссылку RES на RES2
                    RES = RES2;
                }
            } while (s != "");

            // Вывод массива строк RES в цикле

            for (int i = 0; i < RES.Length; i++)
            {
                if (RES[i].Length <= 3)
                {
                    Console.WriteLine(RES[i]);
                }
            }
            Console.ReadKey();
        }
    }
}