using Tyuiu.SedelnikovEA.Sprint5.Task1.V11.Lib;

namespace Tyuiu.SedelnikovEA.Sprint5.Task1.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            int startValue = -5;
            int stopValue = 5;

            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    X     |   f(x)   |");
            Console.WriteLine("+----------+----------+");

            string[] lines = File.ReadAllLines(res);
            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine("|{0,5:d}     |  {1, 6}  |", startValue + i, lines[i]);
            }

            Console.WriteLine("+----------+----------+");
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
