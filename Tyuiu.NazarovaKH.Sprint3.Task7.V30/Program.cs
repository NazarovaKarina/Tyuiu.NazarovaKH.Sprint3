using Tyuiu.NazarovaKH.Sprint3.Task7.V30.Lib;

namespace Tyuiu.NazarovaKH.Sprint3.Task7.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("          5x + 2,5");
            Console.WriteLine(" F(x) = ------------ + 2x + 2");
            Console.WriteLine("         sin(x) + 2");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] valueArray;
            valueArray = new double[len];

            valueArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+---------------------------------------+-------------------------------------");
            Console.WriteLine("*|                  X                   |                  f(X)              |");
            Console.WriteLine("+---------------------------------------+-------------------------------------");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("|{0,5:d}                                  | {1, 6:f2}                             |", startValue, valueArray[i]);
                startValue++;
            }
            Console.WriteLine("+---------------------------------------+------------------------------------+");
            Console.ReadKey();
        }
    }
}
