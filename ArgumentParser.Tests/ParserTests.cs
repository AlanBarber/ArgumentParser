using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArgumentParser;

namespace ArgumentParser.Tests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class ParserTests
    {
        public ParserTests()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMethod()
        {
            string[] test = new string[2];

            test[0] = "hi";
            test[1] = "by";

            string[] test2 = new string[test.Length];

            for (int i = 0; i < test.Length; i++)
            {
                test2[i] = test[i];
            }

            
            test[0] = "XX";

            test[1] = "YY";

        }

        [TestMethod]
        public void Test1()
        {
            string[] args = new string[4];

            List<Option> options = new List<Option>();
            options.Add(new Option() {Details = "", LongCode = "", Name = "", ShortCode = ""});
            
            Parser parser = new Parser();

            List<Argument> arguments = parser.Parse(args);

            Dictionary<string,Argument> a;

            if()


            Assert.IsTrue(true);
        }
    }
}
