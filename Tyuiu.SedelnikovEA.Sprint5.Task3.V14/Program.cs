using Tyuiu.SedelnikovEA.Sprint5.Task3.V14.Lib;

namespace Tyuiu.SedelnikovEA.Sprint5.Task3.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;

            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("x = " + x);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(x);

            using (BinaryReader reader = new BinaryReader(File.Open(res, FileMode.Open)))
            {
                double resultValue = reader.ReadDouble();
                Console.WriteLine("y = " + resultValue);
            }

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
