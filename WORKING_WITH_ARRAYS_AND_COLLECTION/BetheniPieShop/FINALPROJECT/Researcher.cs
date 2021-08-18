using System;
using System.Collections.Generic;
using System.Text;

namespace FINALPROJECT
{
    public class Researcher : Employee
    {
        public Researcher(int empId, string first, string last, string em, DateTime bd, double rate) : base(empId, first, last, em, bd, rate)
        {
        }

        public void ResearchNewPieTeste(int researchHour) {

            numberofHourWorked += researchHour;
            Console.WriteLine($"Researcher {firstName} {lastName} is invented to teste the pie");
        }
    }


}
