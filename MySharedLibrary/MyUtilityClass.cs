using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySharedLibrary
{
    public class MyUtilityClass
    {
        public static bool IsDataValid(string data)
        {
           
            return !string.IsNullOrEmpty(data);
        }

        public static void LogMessage(string message)
        {
         
            Console.WriteLine($"Log: {message}");
        }

    }
}
