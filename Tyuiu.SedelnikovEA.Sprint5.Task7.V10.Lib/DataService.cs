using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SedelnikovEA.Sprint5.Task7.V10.Lib
{
    public class DataService : ISprint5Task7V10
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V10.txt");

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            if (fileInfo.Exists)
            {
                File.Delete(pathSaveFile);
            }

            string content = File.ReadAllText(path);
            StringBuilder sb = new StringBuilder(content.Length);

            foreach (char c in content)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    sb.Append(char.ToLower(c));
                }
                else
                {
                    sb.Append(c);
                }
            }

            File.WriteAllText(pathSaveFile, sb.ToString());
            return pathSaveFile;
        }
    }
}
