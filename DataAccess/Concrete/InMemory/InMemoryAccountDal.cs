using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryAccountDal : IAccountDal
    {
        List<Account> _accounts;
        public InMemoryAccountDal()
        {
            _accounts = new List<Account> {
                new Account{AccountId=1111,CurrencyCodeId=1,Balance=500},
                new Account{AccountId=2222,CurrencyCodeId=2,Balance=1000}              
            };
        }
        public void Add(Account account)
        {
            _accounts.Add(account);
        }

        public void Delete(Account account)
        {
            _accounts.Remove(_accounts.SingleOrDefault(a => a.AccountId == account.AccountId));
        }

        public Account Get(int accountId)
        {
            return _accounts.SingleOrDefault(a => a.AccountId == accountId);
        }

        public List<Account> GetAll()
        {
            return _accounts;
        }

        public void Update(Account account)
        {
            Account accountToDelete = _accounts.SingleOrDefault(a => a.AccountId == account.AccountId);
            accountToDelete.Balance = account.Balance;
            account.CurrencyCodeId = account.CurrencyCodeId;
        }
    }
}
