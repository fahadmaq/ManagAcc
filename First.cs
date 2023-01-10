using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagAcc
{
    struct First
    {
        private void intro()
        {
            Console.Write("MyBank");
            Console.WriteLine($"\nEnter 1 Admin");
            Console.WriteLine($"\nEnter 2 User");
            //Console.WriteLine($"\nEnter 3 for Account Balance");


            string commandInput = Console.ReadLine();
            if (string.IsNullOrEmpty(commandInput))
            {
                Console.WriteLine("Invallid Option \n Please Choose a valid option");
               // continue;
            }
            int command = Convert.ToInt32(Console.ReadLine());
            /*switch (command)
            {
                case 0:
                    Admi = true;
                    break;

                case 1:

                    GetUsercommand();
                    //default:
                    break;*/
            }
        public void showintro()
        {
            intro();

        }
        internal void Load()
        {
            Console.WriteLine("Processsing");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("*");
                System.Threading.Thread.Sleep(5000);
            }
        }
    }
}
