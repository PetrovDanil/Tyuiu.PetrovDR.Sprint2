using Tyuiu.PetrovDR.Sprint2.Task6.V12.Lib;


namespace Tyuiu.PetrovDR.Sprint2.Task6.V12
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
            PrintCenteredLine("Задание #6", width);
            PrintCenteredLine("Вариант #12", width);
            PrintCenteredLine("Выполнил: Петров Данил Романович | РППб-25-1", width);
            Console.WriteLine(new string('*', width));

            PrintCenteredLine("УСЛОВИЕ:", width);
            PrintCenteredLine("Дата некоторого дня характеризуется тремя натуральными числами: g (год),", width);
            PrintCenteredLine("m (порядковый номер месяца) и n (число). По заданным g, n и m", width);
            PrintCenteredLine("определить дату предыдущего дня. Заданный год является високосным.", width);
            Console.WriteLine(new string('*', width));

            PrintCenteredLine("ИСХОДНЫЕ ДАННЫЕ:", width);
            Console.WriteLine(new string('*', width));


            Console.WriteLine("Введите день: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите месяц: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите год: ");
            int g = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(new string('*', width));
            PrintCenteredLine("РЕЗУЛЬТАТ:", width);
            Console.WriteLine(new string('*', width));

            if (((m < 1) || (m > 12)) || ((n < 1) || (n > 31)))
            {
                res = "Введены неверные данные";
            }
            else
            {
                res = "Предыдущая дата: " + ds.FindDateOfPreviousDay(g, m, n);
            }

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}