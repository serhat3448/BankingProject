using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public int AccountId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerAdress { get; set; }
        public string TelephoneNumber { get; set; }

    }
}
