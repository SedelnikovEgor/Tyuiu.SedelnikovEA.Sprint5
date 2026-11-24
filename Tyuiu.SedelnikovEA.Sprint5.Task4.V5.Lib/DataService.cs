using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SedelnikovEA.Sprint5.Task4.V5.Lib
{
    public class DataService : ISprint5Task4V5
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path).Trim().Replace(',', '.');
            double x = double.Parse(strX, CultureInfo.InvariantCulture);

            double y = Math.Round((4.26 * x) / Math.Sin(x), 3);
            return y;
        }
    }
}
