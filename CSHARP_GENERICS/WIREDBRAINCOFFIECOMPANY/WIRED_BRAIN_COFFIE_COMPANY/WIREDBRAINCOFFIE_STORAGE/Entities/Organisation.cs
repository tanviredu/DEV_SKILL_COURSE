using System;
using System.Collections.Generic;
using System.Text;

namespace WIREDBRAINCOFFIE_STORAGE.Entities
{

    // this is the organisation type
    // we are adding Entity based class
    // from where the Id come
    // so we can make a linq query
   public  class Organisation:EntityBase
    {
        ///public int Id { get; set; }
        public string Name { get; set; }
        
        public override string ToString()
        {
            return $"ID : {Id} Name : {Name}";
        }
    }
}
