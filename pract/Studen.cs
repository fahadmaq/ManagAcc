using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagAcc.pract
{
    public  class Studen
    {
        public int rollcall { get; set; }
        public string name { get; set; }
        public int std { get; set; }


    }
    public class StudenDetails
    {
        private List<Studen> StudenList = null;
        public StudenDetails()
        {
            StudenList = new List<Studen>();
            
        }
        public void UpdateStuden(Studen Stud)
        {
            foreach (Studen item in StudenList)
            {
                if(item.rollcall==Stud.rollcall)
                {
                    item.name = Stud.name;
                    item.std = Stud.std;
                    break;

                }
            }
        }
        public void AddStuden(Studen Stud)
        {
            StudenList.Add(Stud);
        }
        public void RemoveStuden(int rollcall)
        {
            foreach (Studen item in StudenList)
            {
                if (item.rollcall==rollcall)
                {
                    StudenList.Remove(item);
                    break;
                }
            }
            

            
        }
        public List<Studen>List()
        {
            return StudenList;

        }
    }
}
