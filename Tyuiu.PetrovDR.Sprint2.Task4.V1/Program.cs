using Tyuiu.PetrovDR.Sprint2.Task4.V1.Lib;


namespace Tyuiu.PetrovDR.Sprint2.Task4.V1
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
            PrintCenteredLine("Задание #4", width);
            PrintCenteredLine("Вариант #1", width);
            PrintCenteredLine("Выполнил: Петров Данил Романович | РППб-25-1", width);
            Console.WriteLine(new string('*', width));

            PrintCenteredLine("УСЛОВИЕ:", width);
            PrintCenteredLine("Написать программу, которая вычисляет требуемое значение с использованием", width);
            PrintCenteredLine("тернарного оператора, где пользователь вводит значение переменных х, у", width);
            PrintCenteredLine("с клавиатуры, если х < y, то z = (x + 3) / y, иначе (x + 1) / (x - 2)", width);
            Console.WriteLine(new string('*', width));

            PrintCenteredLine("ИСХОДНЫЕ ДАННЫЕ:", width);
            Console.WriteLine(new string('*', width));


            Console.WriteLine("Введите значeние X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значeние Y: ");
            double y = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine(new string('*', width));
            PrintCenteredLine("РЕЗУЛЬТАТ:", width);
            Console.WriteLine(new string('*', width));

            Console.WriteLine("z = " + ds.Calculate(x, y));

            Console.ReadKey();
        }
    }
}