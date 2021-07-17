using System;
using WIREDBRAINCOFFIE_STORAGE_APP.Entities;
using WIREDBRAINCOFFIE_STORAGE_APP.Repository;

namespace WIREDBRAINCOFFIE_STORAGE_APP
{
    class Program
    {
        static void Main(string[] args)
        {
            //var employeeRepository = new EmployeeRepository();
            //employeeRepository.Add(new Employee { FirstName = "Tanvir" });
            //employeeRepository.Add(new Employee { FirstName = "Rahman" });
            // employeeRepository.Add(new Employee { FirstName = "Ornob" });
            //employeeRepository.Add(new Employee { FirstName = "julia" });
            //employeeRepository.Save();



            var genericRepository = new GenericRepository<Employee>();
            EmployeeRepository(genericRepository);

            var genericOrga = new GenericRepository<Organisation>();
            OrganisationRepository(genericOrga);

        }


        private static void OrganisationRepository(GenericRepository<Organisation> genericOrga)
        {
            genericOrga.Add(new Organisation { Name = "global mantics" });
            genericOrga.Add(new Organisation { Name = "coffie shop v" });
            genericOrga.Add(new Organisation { Name = "global coffie master" });
            genericOrga.Add(new Organisation { Name = "global latte" });
            genericOrga.Save();
        }

        private static void EmployeeRepository(GenericRepository<Employee> genericRepository)
        {
            genericRepository.Add(new Employee { FirstName = "Tanvir" });
            genericRepository.Add(new Employee { FirstName = "Rahman" });
            genericRepository.Add(new Employee { FirstName = "Ornob " });
            genericRepository.Add(new Employee { FirstName = "Julia" });
            genericRepository.Save();
        }
    }
}
