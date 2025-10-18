using Tyuiu.PetrovDR.Sprint2.Task7.V4.Lib;

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

            PrintCenteredLine("Спринт #2 | Выполнил: Петров Д. Р. | РППб-25-1", width);
            Console.WriteLine(new string('*', width));
            PrintCenteredLine("Спринт #2", width);
            PrintCenteredLine("Тема: Алгоритмы разветвляющейся структуры", width);
            PrintCenteredLine("Задание #7", width);
            PrintCenteredLine("Вариант #4", width);
            PrintCenteredLine("Выполнил: Петров Данил Романович | РППб-25-1", width);
            Console.WriteLine(new string('*', width));

            PrintCenteredLine("УСЛОВИЕ:", width);
            PrintCenteredLine("Написать программу на C#, которая запрашивает исходные данные", width);
            PrintCenteredLine("(вещественные значения) и вычисляет, находится ли точка", width);
            PrintCenteredLine("с координатами X,Y в заштрихованной области.", width);
            Console.WriteLine(new string('*', width));

            PrintCenteredLine("ИСХОДНЫЕ ДАННЫЕ:", width);
            Console.WriteLine(new string('*', width));


            Console.WriteLine("Введите X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите Y: ");
            double y = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine(new string('*', width));
            PrintCenteredLine("РЕЗУЛЬТАТ:", width);
            Console.WriteLine(new string('*', width));

            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}