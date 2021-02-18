using System;
using NLog;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLogDemo
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger(); 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); 
             logger.Error("This is an error message");  
                    Console.Read();  

        }
    }
}
