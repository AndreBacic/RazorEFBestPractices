namespace EFDataAccess.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; } // USA is assumed
        public string ZipCode { get; set; }
    }
}