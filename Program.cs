using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace ManagAcc
{
	public class Bank
	{
		public static void Main()
		{
			string username1 = "fahd";
			
			username1 = Console.ReadLine();
			string username2 = "faizan";
            username2=Console.ReadLine();
			string username3 = "fila";
            username3 = Console.ReadLine();
		
			BankAccount newAccount = new BankAccount(username1, 2000);
			BankAccount newAccount = new BankAccount(username2, 3000);
			BankAccount newAccount = new BankAccount(username3, 4000);

		}
	}

	public class BankAccount : Bank
	{
		List<double> DepositList = new List<double>();
		//object[] DepositArr = new object[6];
		public string username { get; set; }

		public double Balance { get; set; }

		public BankAccount(string username, double Balance)
		{
			this.username = username;
			this.Balance = Balance;

			Console.WriteLine("Username: {0} , Balance: {1}", username, Balance);
			NextMenu();
		}

		public void NextMenu()
		{
			double balance = Balance;
			Console.WriteLine("Enter 1 for Withdrawl, 2 for Deposit, 3 for Logout, 4 for Deposit History");
			string StringMenu = Console.ReadLine();
			int NextChoice = Convert.ToInt32(StringMenu);
			switch (NextChoice)
			{
				case 1:
					Withdraw();
					break;
				case 2:
					Deposit();
					break;
				case 3:
					Logout();
					break;
				case 4:
					DepositHistory();
					break;
			}
		}

		public double Withdraw()
		{
			Console.WriteLine("Available Balance: {0}", Balance);
			Console.WriteLine("How much would you like to withdraw?: ");
			double WithdrawAmt = Convert.ToDouble(Console.ReadLine());
			Balance = Balance -= WithdrawAmt;
			Console.WriteLine(Balance);
			NextMenu();
			return WithdrawAmt;
		}

		public double Deposit()
		{
			Console.WriteLine("Available Balance: {0}", Balance);
			Console.WriteLine("How much would you like to deposit?: ");
			double DepositAmt = Convert.ToDouble(Console.ReadLine());


			DepositList.Add(DepositAmt);

			Balance = Balance + DepositAmt;
			Console.WriteLine(Balance);
			NextMenu();
			return DepositAmt;
		}

		public void Logout()
		{
			Console.WriteLine("Goodbye: " + username);
		}

		public void DepositHistory()
		{
			foreach (double i in DepositList)
			{
				Console.WriteLine("Deposit History: " + i);
			}
		}

	}
 
}*/
