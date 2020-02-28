using DesignPatterns.Adapter_Pattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.OleDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DesignPatternsTest.AdapterPattern
{
    [TestClass]
    public class DataRenderTest
    {
        [TestMethod]
        public void RenderOneRowGivenStubDataAdapter()
        {
            var render = new DataRender(new StubDbAdapter());

                var writer = new StringWriter();

            render.Render(writer);

            string result = writer.ToString();

            Console.WriteLine(result);

            int lineCount = result.Count(c => c == '\n');
            Assert.AreEqual(3, lineCount);
        }
    }
}
