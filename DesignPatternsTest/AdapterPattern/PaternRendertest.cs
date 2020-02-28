using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Adapter_Pattern;
using System.Linq;

namespace DesignPatternsTest.AdapterPattern
{
    /// <summary>
    /// Summary description for PaternRendertest
    /// </summary>
    [TestClass]
    public class PaternRendertest
    {
        public PaternRendertest()
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
        public void GetRowsWhenPassListOfPatterns()
        {
            //
            // TODO: Add test logic here
            //
            //ARRANGE
            PatternRenderAdapter patternRenderAdapter = new PatternRenderAdapter();
            RenderPattern renderPattern = new RenderPattern(patternRenderAdapter);

            List<Pattern> patterns = new List<Pattern>();
            patterns.Add(new Pattern() { Id = 2, Name = "Adapter" });
            patterns.Add(new Pattern() { Id = 3, Name = "Bridge" });

            //ACT 
            string patternsRenderd = renderPattern.RenderPatterns(patterns);

            Console.WriteLine(patternsRenderd);
            //ASSERT
            int lineCount = patternsRenderd.Count(c => c == '\n');
            Assert.AreEqual(patterns.Count + 2, lineCount);



        }
    }
}
