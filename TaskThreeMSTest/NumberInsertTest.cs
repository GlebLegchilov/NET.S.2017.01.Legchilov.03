using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static TaskThree.NumberInsertion;

namespace TaskThreeMSTest
{
    [TestClass]
    public class NumberInsertTest
    {
        public TestContext TestContext { get; set; }

        [DataSource(
            "Microsoft.VisualStudio.TestTools.DataSource.XML",
            "|DataDirectory|\\Data.xml",
            "TestCase",
            DataAccessMethod.Sequential)]
        [DeploymentItem("TaskThreeMSTest\\Data.xml")]
        [TestMethod]
        public void TestMethod()
        {
            
            int actual = TaskThree.NumberInsertion.InsertionMaster(Int32.Parse(TestContext.DataRow["FirstNumber"].ToString()), Int32.Parse(TestContext.DataRow["SecondNumber"].ToString()), Int32.Parse(TestContext.DataRow["FirstIndex"].ToString()), Int32.Parse(TestContext.DataRow["SecondIndex"].ToString()));
            var expected = Convert.ToString(TestContext.DataRow["ExpectedResult"]);

            Assert.AreEqual(expected, actual.ToString());
        }
    }
}
