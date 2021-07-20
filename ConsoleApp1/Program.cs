using System;
using System.Net;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.Write("\nPlease enter a URI (for example, https://www.Youtube.com): ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string url = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Enter Your File Name");
            string filename = Console.ReadLine();
            string Address = url + filename;

            WebClient myWebClient = new WebClient();
            // Download home page data.
            Thread.Sleep(100);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Downloading ...... " + url);
            // Download the Web resource and save it into a data buffer.
            myWebClient.DownloadFile(Address, filename);

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Download successful ... ☺");
            Console.ReadKey();

        }
    }
}
