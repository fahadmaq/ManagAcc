using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagAcc
{
    class Accounts
    {
        private int acc_no;

        public int user_acno

        {
            get { return acc_no; }
            set { user_acno = value; }
        }

        /*private string Admin;
        public string username
        {
            get { return Admin; }
            set { username = Admin; }
        }*/
        public double Balance { get; set; }

        protected string name;
        internal int depoit;
        protected internal char type;
        //private int balance;

        private void create_account()
        {
            Console.WriteLine("\n Enter The acc NO");
            acc_no = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n Enter Acc Name");
            name = Console.ReadLine();

            Console.WriteLine("\n Enter ACC type (C/S)");
            type = char.Parse(Console.ReadLine());

            Console.WriteLine("\n Enter Intial amount to Depo");
        }
        //double Balance = balance;
        public void createaccount()
        {
            create_account();
        }

        protected void Show_account()
        {
            Console.WriteLine("\n Account No:", acc_no);
            Console.WriteLine("\n Account Holder Name", name);
            Console.WriteLine("\nType of Acc", type);
            Console.WriteLine("\n Balance Amount", depoit);
        }
        public void showaccount()
        {
            Show_account();
        }

        internal void Modify_account()
        {
            Console.WriteLine("\n Enter AccNo to Moddify");
            Console.WriteLine("\n Enter AccName To Modify");
            name = Console.ReadLine();
            Console.WriteLine("\n Enter AccType to Modify ");
            type = char.Parse(Console.ReadLine());
            Console.WriteLine("\n ENter deposit amount to modify");
            depoit = int.Parse(Console.ReadLine());

        }
        public void modifyacc()
        {
            Modify_account();
        }

        public void accdepo()
        {
            int a;
            Console.WriteLine("Enter amount to be Depoited");
            a = int.Parse(Console.ReadLine());
            depoit += a;
        }
        public void Withdraw()
        {
            int z;
            Console.WriteLine("Enter amnt to Withdraw");
            z = int.Parse(Console.ReadLine());
            depoit -= z;
        }
        public void BalanceAcc()
        {

        }
        public void AccInfo()
        {
            Console.WriteLine($"Accno {0},accName{1}, ACcTtype{2}, Accbala{3}", acc_no, name, type, balance);
        }

        public int retacno()
        {
            return acc_no;
        }
        public string retname()
        {
            return name;

        }
        public char rettype()
        {
            return type;
        }

    }

}
