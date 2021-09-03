using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;

namespace MSBuild4
{
    [TestClass]
    public class UnitTest1
    {
        private const string Expected = "Hello World! from Sanath";
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                HelloWorld.Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
    }
}