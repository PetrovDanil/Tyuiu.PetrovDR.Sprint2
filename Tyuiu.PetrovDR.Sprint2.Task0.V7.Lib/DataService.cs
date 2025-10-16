using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PetrovDR.Sprint2.Task0.V7.Lib
{
    public class DataService : ISprint2Task0V7
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x + 372 == y;
            res[1] = x + 372 != y;
            res[2] = x < y;
            res[3] = x + 500 > y;
            res[4] = x <= y;
            res[5] = x >= y;

            return res;
        }
    }
}
