using Tyuiu.PetrovDR.Sprint2.Task3.V8.Lib;

namespace Tyuiu.PetrovDR.Sprint2.Task3.V8
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
            PrintCenteredLine("Задание #3", width);
            PrintCenteredLine("Вариант #8", width);
            PrintCenteredLine("Выполнил: Петров Данил Романович | РППб-25-1", width);
            Console.WriteLine(new string('*', width));

            PrintCenteredLine("УСЛОВИЕ:", width);
            PrintCenteredLine("Написать программу, которая вычисляет требуемое значение функции Y", width);
            PrintCenteredLine("с использованием вложенных оператор if-else, где пользователь", width);
            PrintCenteredLine("вводит значение переменной X с клавиатуры. Округлить полученное", width);
            PrintCenteredLine("значение до трех знаков после запятой", width);
            Console.WriteLine(new string('*', width));

            PrintCenteredLine("ИСХОДНЫЕ ДАННЫЕ:", width);
            Console.WriteLine(new string('*', width));


            Console.WriteLine("Введите значeние X: ");
            double x = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine(new string('*', width));
            PrintCenteredLine("РЕЗУЛЬТАТ:", width);
            Console.WriteLine(new string('*', width));

            Console.WriteLine("Значение функции равно " + ds.Calculate(x));

            Console.ReadKey();
        }
    }
}