using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCurrencyCodeDal : ICurrencyCodeDal
    {
        List<CurrencyCode> _currencyCodes;
        public InMemoryCurrencyCodeDal()
        {
            _currencyCodes = new List<CurrencyCode> { 
                
                new CurrencyCode{CurrencyCodeId=1, CodeName="TRY", Code='€'},
                new CurrencyCode{CurrencyCodeId=2, CodeName="EUR", Code='₺'}
            };
        }

        public void Add(CurrencyCode currencyCode)
        {
            _currencyCodes.Add(currencyCode);
        }

        public void Delete(CurrencyCode currencyCode)
        {
            _currencyCodes.Remove(_currencyCodes.SingleOrDefault(c => c.CurrencyCodeId == currencyCode.CurrencyCodeId));
        }

        public CurrencyCode Get(int currencyCodeId)
        {
            return _currencyCodes.SingleOrDefault(c => c.CurrencyCodeId == currencyCodeId);
        }

        public List<CurrencyCode> GetAll()
        {
            return _currencyCodes;
        }

        public void Update(CurrencyCode currencyCode)
        {
            CurrencyCode currencyCodeToUpdate = _currencyCodes.SingleOrDefault(c => c.CurrencyCodeId == currencyCode.CurrencyCodeId);
            currencyCodeToUpdate.CodeName = currencyCode.CodeName;
            currencyCodeToUpdate.Code = currencyCode.Code;
        }
    }
}
