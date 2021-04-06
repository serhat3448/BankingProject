using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICurrencyCodeService
    {
        CurrencyCode Get(int currencyCodeId);
        List<CurrencyCode> GetAll();
        void Add(CurrencyCode currencyCode);
        void Update(CurrencyCode currencyCode);
        void Delete(CurrencyCode currencyCode);
    }
}
