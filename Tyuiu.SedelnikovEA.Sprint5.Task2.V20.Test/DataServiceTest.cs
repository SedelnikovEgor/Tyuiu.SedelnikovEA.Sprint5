using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.SedelnikovEA.Sprint5.Task2.V20.Lib;

namespace Tyuiu.SedelnikovEA.Sprint5.Task2.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            int[,] matrix = new int[3, 3]
            {
                {  5, -5, -1 },
                { -4,  2, -4 },
                { -7,  1,  4 }
            };

            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(matrix);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
