using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IAccountDal
    {
        Account Get(int accountId);
        List<Account> GetAll();
        void Add(Account account);
        void Update(Account account);
        void Delete(Account account);
    }
}
