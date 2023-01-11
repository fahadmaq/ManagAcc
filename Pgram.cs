using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagAcc
{
    class Pgram: EnuPgm
    {
        static void Main(string[] args)
        {
            First show = new First();
            int op = 6;
            int userid;
            show.Load();
            EnuPgm bank = new EnuPgm();
            UserCRUD userCRUD = new UserCRUD();
            do
            {
                Console.WriteLine("Login");
                User user = new User();
                Console.WriteLine("Enter UserName");
                user.UserName = Console.ReadLine();
                Console.WriteLine("Enter Password");
                user.Password = Console.ReadLine();


                int result = userCRUD.ValidateUser(user, out userid);
                if (result == 1)
                {
                    Console.WriteLine("1. Add User");
                    Console.WriteLine("2. Modify User");
                    Console.WriteLine("3. Delete User");
                    Console.WriteLine("4. Activate User");
                    Console.WriteLine("5. Deactive User");
                    Console.WriteLine("6. Exit");
                    Console.WriteLine("Enter your option");
                    op = Convert.ToInt32(Console.ReadLine());
                    switch (op)
                    {
                        case 1:
                            User u = new User();
                            Console.WriteLine("Enter UserName");
                            u.UserName = Console.ReadLine();
                            u.Password = Console.ReadLine();
                            userCRUD.AddUser(u);
                            op = 6;
                            break;
                        case 6:
                            Console.Clear();

                            break;
                        default:
                            Console.WriteLine("Wrong");
                            break;
                    }
                }
                else if (result == 0)
                {
                    Console.WriteLine("1. Check Balance");
                    Console.WriteLine("2. Add Payee");
                    Console.WriteLine("3. Rmove Payee");
                    Console.WriteLine("4. Transfer Amount");
                    Console.WriteLine("6. Exit");
                    Console.WriteLine("Enter your option");
                    op = Convert.ToInt32(Console.ReadLine());
                    switch (op)
                    {
                        case 1:

                            break;
                        case 6:
                            Console.Clear();

                            break;
                        default:
                            Console.WriteLine("Wrong");
                            break;
                    }
                }
                else if (result == 2)
                {
                    op = 6;
                    Console.WriteLine("User name or password is wrong");
                }
            }
            while (op == 6);
        }


    }
}
