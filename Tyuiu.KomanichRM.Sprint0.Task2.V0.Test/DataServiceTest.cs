using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KomanichRM.Sprint0.Task2.V0.Lib;
namespace Tyuiu.KomanichRM.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Роман";
            var res = DataService.GetMessage(name);
            // Task2
            Assert.AreEqual("Привет..., Роман", res);
        }
    }
}
