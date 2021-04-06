using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        public static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new InMemoryCustomerDal());
            AccountManager accountManager = new AccountManager(new InMemoryAccountDal());
            CurrencyCodeManager currencyCodeManager = new CurrencyCodeManager(new InMemoryCurrencyCodeDal());

            ////*****************************************************

            //KullaniciListele(customerManager);

            ////*****************************************************

            //KullaniciBul(customerManager);

            ////*****************************************************

            //KullaniciListele(customerManager);

            ////*****************************************************

            //KullaniciEkle(customerManager);

            ////*****************************************************

            //KullaniciListele(customerManager);

            ////*****************************************************

            //KullaniciSil(customerManager);

            ////*****************************************************

            //KullaniciListele(customerManager);

            ////*****************************************************

            //KullaniciGuncelle(customerManager);

            ////*****************************************************

            //KullaniciListele(customerManager);

            ////*****************************************************

            //KullaniciDetayiBul(customerManager);

            //*****************************************************
            //*****************************************************
            //*****************************************************


            //AccountListele(accountManager);

            ////*****************************************************

            //AccountBul(accountManager);

            ////*****************************************************

            //AccountListele(accountManager);

            ////*****************************************************

            //AccountOlustur(accountManager);

            ////*****************************************************

            //AccountListele(accountManager);

            ////*****************************************************

            //AccountSil(accountManager);

            ////*****************************************************

            //AccountListele(accountManager);

            ////*****************************************************

            //AccountGuncelle(accountManager);

            ////*****************************************************

            //AccountListele(accountManager);

            ////*****************************************************

            //DetayliAccountBul(accountManager);

            //*****************************************************
            //*****************************************************
            //*****************************************************


            //CurrencyCodeListele(currencyCodeManager);

            ////*****************************************************

            //CurrencyCodeBul(currencyCodeManager);

            ////*****************************************************

            //CurrencyCodeListele(currencyCodeManager);

            ////*****************************************************

            //CurrencyCodeOlustur(currencyCodeManager);

            ////*****************************************************

            //CurrencyCodeListele(currencyCodeManager);

            ////*****************************************************

            //CurrencyCodeSil(currencyCodeManager);

            ////*****************************************************

            //CurrencyCodeListele(currencyCodeManager);

            ////*****************************************************

            //CurrencyCodeGuncelle(currencyCodeManager);

            ////*****************************************************

            //CurrencyCodeListele(currencyCodeManager);

            ////*****************************************************

            //DetayliCurrencyCodeBul(currencyCodeManager);




        }
        private static void CurrencyCodeOlustur(CurrencyCodeManager currencyCodeManager)
        {
            Console.WriteLine("CurrencyCode Oluşturma");
            CurrencyCode currencyCode = new CurrencyCode();

            int currencyCodeId;
            Console.WriteLine("CurrencyCode Id giriniz");
            currencyCodeId = Convert.ToInt32(Console.ReadLine());
            currencyCode.CurrencyCodeId = currencyCodeId;

            string codeName;
            Console.WriteLine("CurrencyCode codeName giriniz");
            codeName = Console.ReadLine();
            currencyCode.CodeName = codeName;

            char code;
            Console.WriteLine("Code giriniz.");
            code = Convert.ToChar(Console.ReadLine());
            currencyCode.Code = code;

            currencyCodeManager.Add(currencyCode);
            Console.WriteLine("");
        }
        private static void CurrencyCodeSil(CurrencyCodeManager currencyCodeManager)
        {
            Console.WriteLine("CurrencyCode Silme");
            Console.WriteLine("Silmek istediğiniz CurrencyCode Id'sini giriniz.");
            int currencyCodeId = Convert.ToInt32(Console.ReadLine());
            CurrencyCode currencyCode = currencyCodeManager.Get(currencyCodeId);
            currencyCodeManager.Delete(currencyCode);
            Console.WriteLine("");
        }
        private static void CurrencyCodeGuncelle(CurrencyCodeManager currencyCodeManager)
        {
            Console.WriteLine("CurrencyCode Güncelleme");
            Console.WriteLine("Güncellemek istediğiniz CurrencyCode Id'sini giriniz.");
            int currencyCodeId = Convert.ToInt32(Console.ReadLine());
            CurrencyCode currencyCode = currencyCodeManager.Get(currencyCodeId);
            int newCurrencyCodeId;
            Console.WriteLine("CurrencyCode Id giriniz");
            newCurrencyCodeId = Convert.ToInt32(Console.ReadLine());
            currencyCode.CurrencyCodeId = newCurrencyCodeId;

            string currencyCodeName;
            Console.WriteLine("CurrencyCode Name giriniz.");
            currencyCodeName = Console.ReadLine();
            currencyCode.CodeName = currencyCodeName;

            char code;
            Console.WriteLine("Code giriniz.");
            code = Convert.ToChar(Console.ReadLine());
            currencyCode.Code = code;
        }
        private static void CurrencyCodeListele(CurrencyCodeManager currencyCodeManager)
        {
            Console.WriteLine("CurrencyCode Listesi");
            foreach (CurrencyCode eachCurrencyCode in currencyCodeManager.GetAll())
            {
                Console.WriteLine(eachCurrencyCode.CodeName);
            }
            Console.WriteLine("");
        }
        private static void CurrencyCodeBul(CurrencyCodeManager currencyCodeManager)
        {
            Console.WriteLine("CurrencyCode Bulma");
            Console.WriteLine("CurrencyCode Id'si giriniz.");
            int currencyCodeId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(currencyCodeManager.Get(currencyCodeId).CodeName);
            Console.WriteLine("");
        }
        private static void DetayliCurrencyCodeBul(CurrencyCodeManager currencyCodeManager)
        {
            Console.WriteLine("Detaylı CurrencyCode Bulma");
            Console.WriteLine("CurrencyCode Id'si giriniz.");
            int currencyCodeId = Convert.ToInt32(Console.ReadLine());
            CurrencyCode currencyCode = currencyCodeManager.Get(currencyCodeId);
            Console.WriteLine(currencyCode.CurrencyCodeId + "\n"
                + currencyCode.CodeName + "\n"
                + currencyCode.Code);
            Console.WriteLine("");
        }









        private static void AccountOlustur(AccountManager accountManager)
        {
            Console.WriteLine("Account Oluşturma");
            Account account = new Account();

            int accountId;
            Console.WriteLine("Account Id giriniz");
            accountId = Convert.ToInt32(Console.ReadLine());
            account.AccountId = accountId;

            int currencyCodeId;
            Console.WriteLine("Account currencyCodeId giriniz");
            currencyCodeId = Convert.ToInt32(Console.ReadLine());
            account.CurrencyCodeId = currencyCodeId;

            decimal balance;
            Console.WriteLine("Balance'ı giriniz.");
            balance = Convert.ToDecimal(Console.ReadLine());
            account.Balance = balance;

            accountManager.Add(account);
            Console.WriteLine("");
        }
        private static void AccountSil(AccountManager accountManager)
        {
            Console.WriteLine("Account Silme");
            Console.WriteLine("Silmek istediğiniz account Id'sini giriniz.");
            int accountId = Convert.ToInt32(Console.ReadLine());
            Account account = accountManager.Get(accountId);
            accountManager.Delete(account);
            Console.WriteLine("");
        }
        private static void AccountGuncelle(AccountManager accountManager)
        {
            Console.WriteLine("Account Güncelleme");
            Console.WriteLine("Güncellemek istediğiniz account Id'sini giriniz.");
            int accountId = Convert.ToInt32(Console.ReadLine());
            Account account = accountManager.Get(accountId);
            int newAccountId;
            Console.WriteLine("Account Id giriniz");
            newAccountId = Convert.ToInt32(Console.ReadLine());
            account.AccountId = newAccountId;

            int currencyCodeId;
            Console.WriteLine("CurrencyCode Id giriniz.");
            currencyCodeId = Convert.ToInt32(Console.ReadLine());
            account.CurrencyCodeId = currencyCodeId;

            decimal balance;
            Console.WriteLine("Balance giriniz.");
            balance = Convert.ToDecimal(Console.ReadLine());
            account.Balance = balance;
        }
        private static void AccountListele(AccountManager accountManager)
        {
            Console.WriteLine("Account Listesi");
            foreach (Account eachAccount in accountManager.GetAll())
            {
                Console.WriteLine(eachAccount.AccountId);
            }
            Console.WriteLine("");
        }
        private static void AccountBul(AccountManager accountManager)
        {
            Console.WriteLine("Account Bulma");
            Console.WriteLine("Account Id'si giriniz.");
            int accountId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(accountManager.Get(accountId).AccountId);
            Console.WriteLine("");
        }
        private static void DetayliAccountBul(AccountManager accountManager)
        {
            Console.WriteLine("Detaylı Account Bulma");
            Console.WriteLine("Account Id'si giriniz.");
            int accountId = Convert.ToInt32(Console.ReadLine());
            Account account = accountManager.Get(accountId);
            Console.WriteLine(account.AccountId + "\n"
                + account.CurrencyCodeId + "\n"
                + account.Balance);
            Console.WriteLine("");
        }









        private static void KullaniciEkle(CustomerManager customerManager)
        {
            Console.WriteLine("Kullanıcı Ekleme");
            Customer customer = new Customer();

            int customerId;
            Console.WriteLine("Customer Id giriniz");
            customerId = Convert.ToInt32(Console.ReadLine());
            customer.CustomerId = customerId;

            int accountId;
            Console.WriteLine("Customer accountId giriniz");
            accountId = Convert.ToInt32(Console.ReadLine());
            customer.AccountId = accountId;

            string name;
            Console.WriteLine("Customer name giriniz");
            name = Console.ReadLine();
            customer.CustomerName = name;

            string surname;
            Console.WriteLine("Customer surname giriniz");
            surname = Console.ReadLine();
            customer.CustomerSurname = surname;

            string adress;
            Console.WriteLine("Customer adress giriniz");
            adress = Console.ReadLine();
            customer.CustomerAdress = adress;

            string telephone;
            Console.WriteLine("Customer telephoneNumber giriniz");
            telephone = Console.ReadLine();
            customer.TelephoneNumber = telephone;

            customerManager.Add(customer);
            Console.WriteLine("");

        }
        private static void KullaniciSil(CustomerManager customerManager)
        {
            Console.WriteLine("Kullanıcı Silme");
            Console.WriteLine("Silmek istediğiniz kullanıcının Id'sini giriniz.");
            int kullaniciId = Convert.ToInt32(Console.ReadLine());
            Customer customer = customerManager.Get(kullaniciId);
            customerManager.Delete(customer);
            Console.WriteLine("");
        }
        private static void KullaniciGuncelle(CustomerManager customerManager)
        {
            Console.WriteLine("Kullanıcı Güncelleme");
            Console.WriteLine("Güncellemek istediğiniz kullanıcının Id'sini giriniz.");
            int kullaniciId = Convert.ToInt32(Console.ReadLine());
            Customer customer = customerManager.Get(kullaniciId);
            int newCustomerId;
            Console.WriteLine("Customer Id giriniz");
            newCustomerId = Convert.ToInt32(Console.ReadLine());
            customer.CustomerId = newCustomerId;

            //int accountId;
            //Console.WriteLine("Customer accountId giriniz");
            //accountId = Convert.ToInt32(Console.ReadLine());
            //customer.AccountId = accountId;

            string name;
            Console.WriteLine("Customer name giriniz");
            name = Console.ReadLine();
            customer.CustomerName = name;

            string surname;
            Console.WriteLine("Customer surname giriniz");
            surname = Console.ReadLine();
            customer.CustomerSurname = surname;

            //string adress;
            //Console.WriteLine("Customer adress giriniz");
            //adress = Console.ReadLine();
            //customer.CustomerAdress = adress;

            string telephone;
            Console.WriteLine("Customer telephoneNumber giriniz");
            telephone = Console.ReadLine();
            customer.TelephoneNumber = telephone;

            customerManager.Update(customer);
            Console.WriteLine("");
        }
        private static void KullaniciListele(CustomerManager customerManager)
        {
            Console.WriteLine("Kullanıcı Listesi");
            foreach (Customer eachCustomer in customerManager.GetAll())
            {
                Console.WriteLine(eachCustomer.CustomerName);
            }
            Console.WriteLine("");
        }
        private static void KullaniciBul(CustomerManager customerManager)
        {
            Console.WriteLine("Kullanıcı Bulma");
            Console.WriteLine("Kullanici Id'si giriniz.");
            int kullaniciId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(customerManager.Get(kullaniciId).CustomerName);
            Console.WriteLine("");
        }
        private static void KullaniciDetayiBul(CustomerManager customerManager)
        {
            Console.WriteLine("Detaylı Kullanıcı Bulma");
            Console.WriteLine("Kullanici Id'si giriniz.");
            int kullaniciId = Convert.ToInt32(Console.ReadLine());
            Customer customer = customerManager.Get(kullaniciId);
            Console.WriteLine(customer.AccountId + "\n"
                + customer.CustomerName + "\n"
                + customer.CustomerSurname + "\n"
                + customer.CustomerAdress + "\n"
                + customer.TelephoneNumber + "\n");
            Console.WriteLine("");
        }




    }
}
