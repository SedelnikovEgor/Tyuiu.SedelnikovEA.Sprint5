using System;
using System.IO;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SedelnikovEA.Sprint5.Task6.V15.Lib
{
    public class DataService : ISprint5Task6V15
    {
        public int LoadFromDataFile(string path)
        {
            string content = File.ReadAllText(path);
            int count = Regex.Matches(content, @"[а-яА-ЯёЁ]+").Count;
            return count;
        }
    }
}
