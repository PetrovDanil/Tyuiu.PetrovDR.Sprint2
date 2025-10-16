using Tyuiu.PetrovDR.Sprint2.Task0.V7.Lib;

namespace Tyuiu.PetrovDR.Sprint2.Task0.V7
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

            int x = 103;
            int y = 475;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);

            PrintCenteredLine("Спринт #2 | Выполнил: Петров Д. Р. | РППб-25-1", width);
            Console.WriteLine(new string('*', width));
            PrintCenteredLine("Спринт #2", width);
            PrintCenteredLine("Тема: Алгоритмы разветвляющейся структуры", width);
            PrintCenteredLine("Задание #0", width);
            PrintCenteredLine("Вариант #7", width);
            PrintCenteredLine("Выполнил: Петров Данил Романович | РППб-25-1", width);
            Console.WriteLine(new string('*', width));

            PrintCenteredLine("УСЛОВИЕ:", width);
            PrintCenteredLine("Написать программу из операций сравнений и арифметических выражений,", width);
            PrintCenteredLine("которая вернет логическую последовательность(массив):", width);
            PrintCenteredLine("(True, False, True, True, True, False), при x = 103, y = 475", width);
            Console.WriteLine(new string('*', width));

            PrintCenteredLine("ИСХОДНЫЕ ДАННЫЕ:", width);
            Console.WriteLine(new string('*', width));

            PrintCenteredLine("X = " + x, width);
            PrintCenteredLine("Y = " + y, width);

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