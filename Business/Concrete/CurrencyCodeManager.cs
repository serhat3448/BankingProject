using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CurrencyCodeManager : ICurrencyCodeService
    {
        ICurrencyCodeDal _currencyCodeDal;
        public CurrencyCodeManager(ICurrencyCodeDal currencyCodeDal)
        {
            _currencyCodeDal = currencyCodeDal;
        }
        public void Add(CurrencyCode currencyCode)
        {
            _currencyCodeDal.Add(currencyCode);
        }

        public void Delete(CurrencyCode currencyCode)
        {
            _currencyCodeDal.Delete(currencyCode);
        }

        public CurrencyCode Get(int currencyCodeId)
        {
            return _currencyCodeDal.Get(currencyCodeId);
        }

        public List<CurrencyCode> GetAll()
        {
            return _currencyCodeDal.GetAll();
        }

        public void Update(CurrencyCode currencyCode)
        {
            _currencyCodeDal.Update(currencyCode);
        }
    }
}
