namespace WIREDBRAINCOFFIE_STORAGE_APP.Entities
{
    public class Organisation:EntityBase
    { 
        //public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"ID : {Id} , Organisation {Name}";
        }


    }



}
