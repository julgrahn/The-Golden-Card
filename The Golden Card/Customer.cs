namespace The_Golden_Card
{
    public class Customer
    {
        public string customerNumber { get; set; }
        public string customerName { get; set; }
        public string customerCity { get; set; }

        public Customer(string readCustomerNumber, string readCustomerName, string readCustomerCity)
        {
            customerNumber = readCustomerNumber;
            customerName = readCustomerName;
            customerCity = readCustomerCity;
        }

        public override string ToString()
        {
            return customerNumber + " " + customerName + " " + customerCity;
        }
    }
}
