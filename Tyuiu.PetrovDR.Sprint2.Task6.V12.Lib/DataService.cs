using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PetrovDR.Sprint2.Task6.V12.Lib
{
    public class DataService : ISprint2Task6V12
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            {
                int daysm = m switch
                {
                    1 => 31,
                    2 => 29,
                    3 => 31,
                    4 => 30,
                    5 => 31,
                    6 => 30,
                    7 => 31,
                    8 => 31,
                    9 => 30,
                    10 => 31,
                    11 => 30,
                    12 => 31,
                    _ => throw new ArgumentOutOfRangeException("Некорректный номер месяца")
                };


            if (n > 1)
                {
                    n -= 1;

                }
                else
                {
                    m = m == 1 ? 12 : m - 1;
                    g = m == 12 ? g - 1 : g;

                    int pmd = m switch
                    {
                        1 => 31,
                        2 => 29,
                        3 => 31,
                        4 => 30,
                        5 => 31,
                        6 => 30,
                        7 => 31,
                        8 => 31,
                        9 => 30,
                        10 => 31,
                        11 => 30,
                        12 => 31,
                        _ => throw new ArgumentOutOfRangeException("Некорректный номер месяца")
                    };

                    n = pmd;
                }
                return $"{n:00}.{m:00}.{g}";
            }
        }
    }
}