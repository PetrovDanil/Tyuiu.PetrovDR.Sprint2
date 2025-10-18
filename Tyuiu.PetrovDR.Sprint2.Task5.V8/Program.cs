using Tyuiu.PetrovDR.Sprint2.Task5.V8.Lib;

namespace Tyuiu.PetrovDR.Sprint2.Task5.V8
{
    class Program
    {

        static void Main(string[] args)
        {
            void PrintCenteredLine(string text, int totalWidth)
            {
                var padding = totalWidth - text.Length - 2;
                Console.WriteLine($"* {text}{new string(' ', padding)}*");
            }
            var width = 75;



            DataService ds = new DataService();
            string res;

            PrintCenteredLine("Спринт #2 | Выполнил: Петров Д. Р. | РППб-25-1", width);
            Console.WriteLine(new string('*', width));
            PrintCenteredLine("Спринт #2", width);
            PrintCenteredLine("Тема: Алгоритмы разветвляющейся структуры", width);
            PrintCenteredLine("Задание #5", width);
            PrintCenteredLine("Вариант #8", width);
            PrintCenteredLine("Выполнил: Петров Данил Романович | РППб-25-1", width);
            Console.WriteLine(new string('*', width));

            PrintCenteredLine("УСЛОВИЕ:", width);
            PrintCenteredLine("Дата некоторого дня характеризуется двумя натуральными числами: m (месяц)", width);
            PrintCenteredLine("и n (число). По заданным n и m определить дату предыдущего дня", width);
            PrintCenteredLine("(принять, что n и m не характеризуют 1 января).", width);
            Console.WriteLine(new string('*', width));

            PrintCenteredLine("ИСХОДНЫЕ ДАННЫЕ:", width);
            Console.WriteLine(new string('*', width));


            Console.WriteLine("Введите день: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите месяц: ");
            int m = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(new string('*', width));
            PrintCenteredLine("РЕЗУЛЬТАТ:", width);
            Console.WriteLine(new string('*', width));

            if (((m < 1) || (m > 12)) || ((n < 1) || (n > 31)))
            {
                res = "Введены неверные данные";
            }
            else
            {
                res = "Предыдущая дата: " + ds.FindDateOfPreviousDay(m, n);
            }

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}