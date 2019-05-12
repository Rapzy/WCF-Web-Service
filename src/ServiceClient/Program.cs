using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceClient.ServiceReference1;

namespace ServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step 1: Create an instance of the WCF proxy.
            WordCounterClient client = new WordCounterClient();

            // Step 2: Call the service operations.
            // Call the Add service operation.
            Console.Write("Enter string: ");
            string value1 = Console.ReadLine();
            int result = client.CountWords(value1);
            Console.WriteLine("Number of words: {0}", result);

            // Step 3: Close the client to gracefully close the connection and clean up resources.
            Console.WriteLine("\nPress <Enter> to terminate the client.");
            Console.ReadLine();
            client.Close();
        }
    }
}
