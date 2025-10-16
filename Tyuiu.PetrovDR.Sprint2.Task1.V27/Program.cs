using Tyuiu.PetrovDR.Sprint2.Task1.V27.Lib;

namespace Tyuiu.PetrovDR.Sprint2.Task1.V27
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

            int a = 654;
            int b = 325;
            int c = 154;
            int d = 333;

            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            PrintCenteredLine("Спринт #2 | Выполнил: Петров Д. Р. | РППб-25-1", width);
            Console.WriteLine(new string('*', width));
            PrintCenteredLine("Спринт #2", width);
            PrintCenteredLine("Тема: Алгоритмы разветвляющейся структуры", width);
            PrintCenteredLine("Задание #1", width);
            PrintCenteredLine("Вариант #27", width);
            PrintCenteredLine("Выполнил: Петров Данил Романович | РППб-25-1", width);
            Console.WriteLine(new string('*', width));

            PrintCenteredLine("УСЛОВИЕ:", width);
            PrintCenteredLine("Написать программу из операций сравнений и логических операций,", width);
            PrintCenteredLine("а также арифметических выражений, которая вернет", width);
            PrintCenteredLine("логическую последовательность(массив):", width);
            PrintCenteredLine("(False, False, True, False, True, False),", width);
            PrintCenteredLine("при a = 654, b = 325, c = 154, d = 333", width);
            Console.WriteLine(new string('*', width));

            PrintCenteredLine("ИСХОДНЫЕ ДАННЫЕ:", width);
            Console.WriteLine(new string('*', width));

            PrintCenteredLine("A = " + a, width);
            PrintCenteredLine("B = " + b, width);
            PrintCenteredLine("C = " + c, width);
            PrintCenteredLine("D = " + d, width);

            Console.WriteLine(new string('*', width));
            PrintCenteredLine("РЕЗУЛЬТАТ:", width);
            Console.WriteLine(new string('*', width));

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadKey();
        }
    }
}