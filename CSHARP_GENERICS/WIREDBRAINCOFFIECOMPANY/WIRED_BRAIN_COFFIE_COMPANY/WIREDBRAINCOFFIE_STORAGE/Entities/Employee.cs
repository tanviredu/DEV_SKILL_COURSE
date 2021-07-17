using System;
using System.Collections.Generic;
using System.Text;

namespace WIREDBRAINCOFFIE_STORAGE.Entities
{

    // this is Employee Type
    public class Employee:EntityBase
    {
        ///public int Id { get; set; }
        public string? FirstName { get; set; }

        public override string ToString()
        {
            return $"ID : {Id} Name : {FirstName}";
        }
    }
}
