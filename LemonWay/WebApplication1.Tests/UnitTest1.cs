using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Reflection;

namespace WebApplication1.Tests
{
    [TestClass]
    public class UnitTest1
    {
        localhost.LemonWay lemonWay = new localhost.LemonWay();

        /// <summary>
        /// Unit test for XmlToJson
        /// </summary>
        [TestMethod]
        public void TestXmlToJson()
        {
            string inputString;
            string expectedString;

            Assert.AreEqual(expectedString = "{ \"foo\": \"bar\" }",
                lemonWay.XmlToJson(inputString = "<foo>bar</foo>"),
                "With input : {0}, expected : {1}, but found : {2}",
                inputString, expectedString, lemonWay.XmlToJson(inputString));
            Assert.AreEqual(expectedString = "Bad Xml format",
                lemonWay.XmlToJson("<foo>hello</bar>"),
                "With input : {0}, expected : {1}, but found : {2}",
                inputString, expectedString, lemonWay.XmlToJson(inputString));
            Assert.AreEqual(expectedString = File.ReadAllText(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"JsonFiles\json1.json")),
            lemonWay.XmlToJson(inputString = "<TRANS><HPAY><ID>103</ID><STATUS>3</STATUS><EXTRA><IS3DS>0</IS3DS><AUTH>031183</AUTH></EXTRA><INT_MSG/><MLABEL>501767XXXXXX6700</MLABEL><MTOKEN>project01</MTOKEN></HPAY></TRANS>"),
                "With input : {0}, expected : {1}, but found : {2}",
                inputString, expectedString, lemonWay.XmlToJson(inputString));
        }

        /// <summary>
        /// Unit test for Fibonacci
        /// </summary>
        [TestMethod]
        public void TestFibonacci()
        {
            int inputValue;
            int expectedResult;

            Assert.AreEqual(expectedResult = -1, lemonWay.Fibonacci(inputValue = -1),
                "With input value : {0}, expected : {1}, but found : {2}",
                inputValue, expectedResult, lemonWay.Fibonacci(inputValue));
            Assert.AreEqual(expectedResult = 1, lemonWay.Fibonacci(inputValue = 1),
                "With input value : {0}, expected : {1}, but found : {2}",
                inputValue, expectedResult, lemonWay.Fibonacci(inputValue));
            Assert.AreEqual(expectedResult = 1, lemonWay.Fibonacci(inputValue = 2),
                "With input value : {0}, expected : {1}, but found : {2}",
                inputValue, expectedResult, lemonWay.Fibonacci(inputValue));
            Assert.AreEqual(expectedResult = 2, lemonWay.Fibonacci(inputValue = 3),
                "With input value : {0}, expected : {1}, but found : {2}",
                inputValue, expectedResult, lemonWay.Fibonacci(inputValue));
            Assert.AreEqual(expectedResult = 3, lemonWay.Fibonacci(inputValue = 4),
                "With input value : {0}, expected : {1}, but found : {2}",
                inputValue, expectedResult, lemonWay.Fibonacci(inputValue));
            Assert.AreEqual(expectedResult = 5, lemonWay.Fibonacci(inputValue = 5),
                "With input value : {0}, expected : {1}, but found : {2}",
                inputValue, expectedResult, lemonWay.Fibonacci(inputValue)); ;
            Assert.AreEqual(expectedResult = 8, lemonWay.Fibonacci(inputValue = 6),
                "With input value : {0}, expected : {1}, but found : {2}",
                inputValue, expectedResult, lemonWay.Fibonacci(inputValue)); ;
            Assert.AreEqual(expectedResult = -1, lemonWay.Fibonacci(inputValue = 101),
                "With input value : {0}, expected : {1}, but found : {2}",
                inputValue, expectedResult, lemonWay.Fibonacci(inputValue));
        }
    }
}
