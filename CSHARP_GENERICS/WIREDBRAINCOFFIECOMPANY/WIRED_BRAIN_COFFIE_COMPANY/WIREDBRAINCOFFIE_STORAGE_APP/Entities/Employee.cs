using System;
using System.Collections.Generic;
using System.Text;

namespace WIREDBRAINCOFFIE_STORAGE_APP.Entities
{
    public class Employee:EntityBase
    {
        //public int Id { get; set; }
        public string? FirstName { get; set; }


        //override the default ToString Method
        public override string ToString()
        {
            return $"ID : {Id} , FirstName {FirstName}";
        }

    }



}
