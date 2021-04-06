using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Account
    {
        public int AccountId { get; set; }
        public int CurrencyCodeId { get; set; }
        public decimal Balance { get; set; }
       
    }
}
