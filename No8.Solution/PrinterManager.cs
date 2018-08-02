using System;
using System.Collections.Generic;
using System.IO;

namespace No8.Solution
{
    public delegate void PrinterDelegate(string arg);

    // Выводы в консоль исключены из объявления типа
    // в целях устранения зависимости от конкретного UI
    public class PrinterManager
    {
        public event PrinterDelegate BeforePrint;
        public event PrinterDelegate OnPrinted;
        private readonly ILog _logger;

        public PrinterManager(ILog logger)
        {
            _logger = logger;
            BeforePrint = new PrinterDelegate(_logger.Log);
            OnPrinted = new PrinterDelegate(_logger.Log);
            Printers = new List<IPrinter>();
        }

        public List<IPrinter> Printers { get; set; }

        public void Add(IPrinter printer)
        {
            if (!Printers.Contains(printer))
            {
                Printers.Add(printer);
                _logger.Log("Printer added");
            }
        }

        public string Print(IPrinter printer, string path)
        {
            if (!Printers.Contains(printer))
            {
                _logger.Log("Printer not found");
                return null;
            }
            else if (string.IsNullOrEmpty(path)
                || !File.Exists(path))
            {
                _logger.Log("Invalid path");
                return null;
            }

            BeforePrint($"Printing started at {DateTime.Now}");
            string result = printer.Print(path);
            OnPrinted($"Printing ended on {DateTime.Now}");

            return result;
        }
    }
}