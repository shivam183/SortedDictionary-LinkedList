using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shivam_Sood_Sec003_Ex_01
{
    class Account
    {
        public int AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public decimal Balance { get; set; }
        public string BankerName { get; set; }

        public Account(int accountNumber,string customerName,decimal balance,string bankerName)
        {
            AccountNumber = accountNumber;
            CustomerName = customerName;
            Balance = balance;
            BankerName = bankerName;
        }

        public Account()
        {

        }

        public override string ToString()
        {
            return $"Account Number: {AccountNumber},\nCustomerName: {CustomerName},\nBalance: {Balance:C},\nBanker Name: {BankerName}";
        }
    }
}
