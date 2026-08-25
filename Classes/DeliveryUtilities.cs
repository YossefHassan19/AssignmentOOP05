using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP05.Classes
{
    internal static class DeliveryUtilities
    {
        public static void PrintSeparator()
        {
            Console.WriteLine("===========================");
        }
        public static void PrintSystemTitle()
        {
            PrintSeparator();
            Console.WriteLine("Creating Shipments...");
            PrintSeparator();
        }
    }
}
