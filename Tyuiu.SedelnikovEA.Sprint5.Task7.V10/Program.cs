using Tyuiu.SedelnikovEA.Sprint5.Task7.V10.Lib;

namespace Tyuiu.SedelnikovEA.Sprint5.Task7.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = Path.Combine(@"C:\DataSprint5", "InPutDataFileTask7V10.txt");
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string pathSaveFile = ds.LoadDataAndSave(path);
            Console.WriteLine("Находится в файле: " + pathSaveFile);
            Console.WriteLine("Содержимое файла: " + File.ReadAllText(pathSaveFile));
            Console.ReadKey();
        }
    }
}
