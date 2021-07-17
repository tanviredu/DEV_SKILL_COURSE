using System;
using WIREDBRAINCOFFIE_STORAGE.Data;
using WIREDBRAINCOFFIE_STORAGE.Entities;
using WIREDBRAINCOFFIE_STORAGE.Repositories;

namespace WIREDBRAINCOFFIE_STORAGE
{
    public class Program
    {
        static void Main(string[] args)
        {
            var genericRepository = new SQLRepository<Employee>(new StorageAppDBContext());
            AddEmployees(genericRepository);
            GetEmployeeById(genericRepository);

            var genericrepositoryOrga = new ListRepository<Organisation>();
            AddOrganisation(genericrepositoryOrga);
        }

        private static void GetEmployeeById(ISQLRepository<Employee> genericRepository)
        {
            var employee = genericRepository.GetByID(2);
            Console.WriteLine(employee.FirstName);
        }

        private static void AddEmployees(ISQLRepository<Employee> genericRepository)
        {
            genericRepository.Add(new Employee { Id = 1, FirstName = "Tanvir" });
            genericRepository.Add(new Employee { Id = 2, FirstName = "Rahman" });
            genericRepository.Add(new Employee { Id = 3, FirstName = "Ornob" });
            genericRepository.Add(new Employee { Id = 4, FirstName = "Julia" });
            //genericRepository.Remove(new Employee{ Id = 4, FirstName = "Julia" });
            genericRepository.Save();
        }

        private static void AddOrganisation(ListRepository<Organisation> genericrepositoryOrga)
        {
            genericrepositoryOrga.Add(new Organisation { Id = 1, Name = "Tanvirs Coffiee" });
            genericrepositoryOrga.Add(new Organisation { Id = 2, Name = "Wired Coffie" });
            genericrepositoryOrga.Add(new Organisation { Id = 3, Name = "Hr Coffie" });
            genericrepositoryOrga.Add(new Organisation { Id = 4, Name = "Latte" });
            genericrepositoryOrga.Save();
        }
    }
}
