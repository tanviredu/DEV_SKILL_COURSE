using System;

namespace FINALPROJECT
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager mary = new Manager(700, "merry", "islam", "merry@gmail.com", new DateTime(1993, 12, 23), 30);
            mary.PerformWork();
            mary.PerformWork();
            mary.PerformWork();
            mary.PerformWork();
            mary.PerformWork();
            mary.RecieveWage();
            mary.AttendManagementMeeting();
            mary.DisplayEmployeeDetails();

            Researcher gorge = new Researcher(100, "gorge", "max", "gorge@gmail.com", new DateTime(1993, 12, 24), 100);
            gorge.GiveBonus();
            gorge.ResearchNewPieTeste(10);
            gorge.DisplayEmployeeDetails();

        }
    }
}
