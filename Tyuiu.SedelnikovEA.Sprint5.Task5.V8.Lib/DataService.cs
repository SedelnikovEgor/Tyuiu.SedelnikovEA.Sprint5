using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SedelnikovEA.Sprint5.Task5.V8.Lib
{
    public class DataService : ISprint5Task5V8
    {
        public double LoadFromDataFile(string path)
        {
            string content = File.ReadAllText(path);
            string[] tokens = content.Split(new[] { ' ', '\r', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            double minReal = double.MaxValue;
            bool foundReal = false;

            foreach (string token in tokens)
            {
                if (token.Contains(".") || token.Contains(","))
                {
                    string normalized = token.Replace(',', '.');
                    if (double.TryParse(normalized, NumberStyles.Any, CultureInfo.InvariantCulture, out double val))
                    {
                        if (val < minReal)
                        {
                            minReal = val;
                            foundReal = true;
                        }
                    }
                }
            }

            if (!foundReal)
            {
                foreach (string token in tokens)
                {
                    string normalized = token.Replace(',', '.');
                    if (double.TryParse(normalized, NumberStyles.Any, CultureInfo.InvariantCulture, out double val))
                    {
                        if (val < minReal)
                        {
                            minReal = val;
                        }
                    }
                }
            }

            return Math.Round(minReal, 3);
        }
    }
}
