using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.SedelnikovEA.Sprint5.Task6.V15.Lib;

namespace Tyuiu.SedelnikovEA.Sprint5.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask6V15.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
