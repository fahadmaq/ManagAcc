using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagAcc.pract
{
    public class Program
    {
        static void Main(string[] args)
        {
            StudenDetails Stud = new StudenDetails();
            Console.WriteLine("ENter Roll CAll, name, Std");
            Studen s1 = new Studen();
            s1.rollcall = Convert.ToInt32(Console.ReadLine());
            s1.name = Console.ReadLine();
            s1.std = Convert.ToInt32(Console.ReadLine());
            Stud.AddStuden(s1);

            //StudenDetails Stud = new StudenDetails();
            Console.WriteLine("ENter Roll CAll, name, Std");
            Studen s2 = new Studen();
            s2.rollcall = Convert.ToInt32(Console.ReadLine());
            s2.name = Console.ReadLine();
            s2.std = Convert.ToInt32(Console.ReadLine());
            Stud.AddStuden(s2);

            List<Studen> Studlist = Stud.List();
            foreach (Studen item in Studlist)
            {
                Console.WriteLine($"{item.rollcall},{item.name},{item.std}");

            }
            Console.WriteLine("Enter RollCall to remove");

            int rollcall = Convert.ToInt32(Console.ReadLine());
            Stud.RemoveStuden(rollcall);


            Studlist = Stud.List();

            foreach (Studen item in Studlist)
            {
                Console.WriteLine($"{item.rollcall},{item.name},{item.std}");

            }
            Console.WriteLine("Enter Roll call to  modify");
            Studen s = new Studen();
            s.rollcall = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter std");
            s.std = Convert.ToInt32(Console.ReadLine());
            s.name = Console.ReadLine();

        }

    }
}
