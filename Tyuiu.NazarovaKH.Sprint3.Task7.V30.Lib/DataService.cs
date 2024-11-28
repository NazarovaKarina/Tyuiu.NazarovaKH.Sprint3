using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.NazarovaKH.Sprint3.Task7.V30.Lib
{
    public class DataService : ISprint3Task7V30
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = x + 1;
                if (denominator == 0)
                {
                    y = 0;
                }
                else
                {
                    y = ((5 * x + 2.5) / (Math.Sin(x) + 2)) + 2 * x + 2;
                }
                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}
