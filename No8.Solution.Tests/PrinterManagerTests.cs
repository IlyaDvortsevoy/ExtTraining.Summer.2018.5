using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace No8.Solution.Tests
{
    [TestFixture]
    public class PrinterManagerTests
    {
        [Test]
        public void Add_method_works_properly()
        {
            var logger = new FileLogger("Log.txt");
            var manager = new PrinterManager(logger);
            var printer = new NetworkPrinter() { Name = "Canon", Model = "LBP6000" };

            manager.Add(printer);

            Assert.AreEqual(printer, manager.Printers[0]);
        }

        [Test]
        public void Print_method_works_properly()
        {
            var logger = new FileLogger("Log.txt");
            var manager = new PrinterManager(logger);
            var printer = new NetworkPrinter() { Name = "Canon", Model = "LBP6000" };

            manager.Add(printer);
            string expected = "12345";
            string path = @"C:\Users\Илья\Desktop\12.txt";

            string result = manager.Print(printer, path);

            Assert.AreEqual(expected, result);
        }
    }
}