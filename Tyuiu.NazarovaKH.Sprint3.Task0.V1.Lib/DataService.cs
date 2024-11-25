using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.NazarovaKH.Sprint3.Task0.V1.Lib
{
    public class DataService : ISprint3Task0V0
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                sumSeries = sumSeries + ((Math.Pow(value, 2) * i) + 1);
            }
            return Math.Round(sumSeries, 3);
        }
    }
}
