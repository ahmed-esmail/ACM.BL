namespace ACM.BL
{
    public class Address
    {
        public Address()
        {
            
        }
        
        public Address(int addressId)
        {
            AddressId = addressId;
        }
        
        public int AddressId { get; set; }        
        public string AddressType { get; set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int PostalCode { get; set; }
        public string Country { get; set; }

        /// <summary>
        /// validate Address Data
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            return PostalCode != null;
        }
    }
}