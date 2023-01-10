using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagAcc
{
    internal static class CodingController
        
    {
        internal static void GetUsercommand()
        {
            bool closeApp= false;
            while (closeApp==false)
            {
                Console.WriteLine($"\nMAIN MENU");
                Console.WriteLine($"\nWhat do you wish to do Select from the Following");
                Console.WriteLine($"\nType 0 for closing the app");
                Console.WriteLine($"\nEnter 1 Admin");
                Console.WriteLine($"\nEnter 2 User");
                //Console.WriteLine($"\nEnter 3 for Account Balance");


                string commandInput = Console.ReadLine();
                if (string.IsNullOrEmpty(commandInput))
                {
                    Console.WriteLine("Invallid Option \n Please Choose a valid option");
                    continue;
                }
                int command = Convert.ToInt32(Console.ReadLine());
                switch (command)
                {
                    case 0:
                      closeApp = true;
                      break;

                    case 1:
                        
                     GetUsercommand();
                    //default:
                        break;

                    default:
                        Console.WriteLine("Invalid Comman");
                        break;

                }

            }
        }
    }
}
