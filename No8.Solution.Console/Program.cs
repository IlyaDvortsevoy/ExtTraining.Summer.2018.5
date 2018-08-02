using System;

namespace No8.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new FileLogger("Log.txt");
            var manager = new PrinterManager(logger);

            bool repeat = false;
            System.Console.WriteLine("Welcome to printer manager.");
            DisplayMenu();
            string input = System.Console.ReadLine();
            switch (input)
            {
                //case "1":
                //    do
                //    {
                //        string name;
                //        string Model;

                //        System.Console.WriteLine("Please enter the printer name:");
                //        name = System.Console.ReadKey().ToString();
                //        System.Console.Clear();

                //        System.Console.WriteLine("Please enter the printer Model:");
                //        Model = System.Console.ReadKey().ToString();
                //        System.Console.Clear();            

            }
        }

        public static void DisplayMenu()
        {
            System.Console.WriteLine("Please choose one of the following:");
            System.Console.WriteLine("1. Add a new printer.");
            System.Console.WriteLine("2. Display list of printers.");
            System.Console.WriteLine("3. Print the document.");
            System.Console.WriteLine("4. Exit");
        }
    }
}