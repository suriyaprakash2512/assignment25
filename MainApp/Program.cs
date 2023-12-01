using MySharedLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MySharedLibrary.MyUtilityClass utility = new MySharedLibrary.MyUtilityClass();

            UserManagement.UserManager userManager = new UserManagement.UserManager();
            userManager.AddUser("sam");

            FileProcessing.FileProcessor fileProcessor = new FileProcessing.FileProcessor();
            fileProcessor.ProcessFile("example.txt");

            bool isValidData = MyUtilityClass.IsDataValid("Valid data");
            MyUtilityClass.LogMessage("Logging a message");

            Console.WriteLine($"Is data valid? {isValidData}");

            Console.ReadKey();






        }
    }
}
