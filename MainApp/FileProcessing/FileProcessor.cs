using MySharedLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp.FileProcessing
{
    public class FileProcessor
    {
        public void ProcessFile(string filePath)
        {
            if (MyUtilityClass.IsDataValid(filePath))
            {
                MyUtilityClass.LogMessage($"Processing file: {filePath}");
                
            }
            else
            {
                MyUtilityClass.LogMessage($"Invalid file path: {filePath}");
            }
        }

    }
}
