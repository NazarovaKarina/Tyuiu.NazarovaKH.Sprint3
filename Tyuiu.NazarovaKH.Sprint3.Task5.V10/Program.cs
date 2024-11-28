using Tyuiu.NazarovaKH.Sprint3.Task5.V10.Lib;

namespace Tyuiu.NazarovaKH.Sprint3.Task5.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = Convert.ToInt32(Console.ReadLine());
            int startValue1 = Convert.ToInt32(Console.ReadLine());
            int stopValue1 = Convert.ToInt32(Console.ReadLine());
            int startValue2 = Convert.ToInt32(Console.ReadLine());
            int stopValue2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));
            Console.ReadKey();
        }
    }
}
