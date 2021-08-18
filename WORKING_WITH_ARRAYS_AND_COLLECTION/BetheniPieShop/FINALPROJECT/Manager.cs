using System;
using System.Collections.Generic;
using System.Text;

namespace FINALPROJECT
{
    public class Manager : Employee
    {
        // you need to fill the base constructor properties too
        // because yu will use their method also
        public Manager(int id,string first,string last,string em,DateTime bd,double rate):base(id,first,last,em,bd,rate)
        {


        }
        public void AttendManagementMeeting()
        {
            numberofHourWorked += 10;
            Console.WriteLine($"Manager {firstName} {lastName} is now attending a long meeting");

        }

        public override void GiveBonus()
        {
            if (numberofHourWorked > 5)
            {
                Console.WriteLine($"Manager {firstName} {lastName} recieved a management bonus of 500");
            }
            else
            {
                Console.WriteLine($"Manager {firstName} {lastName} recieved a management bonus of 250");
            }
        }
    }
}
