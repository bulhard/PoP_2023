namespace _06_OOP.Humans
{
    public class Address
    {
        public string Street { get; set; }

        public string City { get; set; }

        public string ZipCode { get; set; }

        public string FullAddress
        {
            get
            {
                return $"{City} {Street}";
            }
        }
    }
}