using System.Collections.Generic;

namespace FurnitureClasses
{
    public class clsCustomerCollection
    {
        public List<clsCustomer> CustomerList { get; set; }
        public int Count { get; set; }
        public clsCustomer ThisCustomer { get; set; }
    }
}