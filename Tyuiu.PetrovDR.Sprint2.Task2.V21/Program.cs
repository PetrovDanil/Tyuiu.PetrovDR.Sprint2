using Tyuiu.PetrovDR.Sprint2.Task2.V21.Lib;

namespace Tyuiu.PetrovDR.Sprint2.Task2.V21
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
            PrintCenteredLine("Задание #2", width);
            PrintCenteredLine("Вариант #21", width);
            PrintCenteredLine("Выполнил: Петров Данил Романович | РППб-25-1", width);
            Console.WriteLine(new string('*', width));

            PrintCenteredLine("УСЛОВИЕ:", width);
            PrintCenteredLine("Написать программу на, которая запрашивает целые значения с клавиатуры и", width);
            PrintCenteredLine("вычисляет находится ли точка с координатами X,Y в заштрихованной области", width);
            Console.WriteLine(new string('*', width));

            PrintCenteredLine("ИСХОДНЫЕ ДАННЫЕ:", width);
            Console.WriteLine(new string('*', width));


            Console.WriteLine("Введите значeние X: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значeние Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

           bool res = ds.CheckDotInShadedArea(x, y);


            Console.WriteLine(new string('*', width));
            PrintCenteredLine("РЕЗУЛЬТАТ:", width);
            Console.WriteLine(new string('*', width));

            if (res)
            {
                Console.WriteLine("Точка находится в заштрихованной области");
            }
            else
            {
                Console.WriteLine("Точка не находится в заштрихованной области");
            }

                Console.ReadKey();
        }
    }
}