using System;
using System.Collections.Generic;
using System.Text;
using WIREDBRAINCOFFIE_STORAGE_APP.Entities;

namespace WIREDBRAINCOFFIE_STORAGE_APP.Repository
{
   public class EmployeeRepository
    {
        private List<Employee> _employess;

        public EmployeeRepository()
        {
            _employess = new List<Employee>();
        }

        public void Add(Employee employee) {

            _employess.Add(employee);
        }


        public void Save() {

            foreach (var employee in _employess)
            {
                Console.WriteLine(employee);
            
            }
        
        }

    }
}
