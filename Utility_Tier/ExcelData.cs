using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Suite.Utility_Tier
{
    class ExcelData
    {
        string accountName;
        string bankName;
        string IBAN;
        string bIC;
        string sortCode;
        string accountNumber;
        string bankBranch;
        public string AccountName { get => accountName; set => accountName = value; }
        public string BankName { get => bankName; set => bankName = value; }
        public string IBAN1 { get => IBAN; set => IBAN = value; }
        public string BIC { get => bIC; set => bIC = value; }
        public string AccountNumber { get => accountNumber; set => accountNumber = value; }
        public string BankBranch { get => bankBranch; set => bankBranch = value; }
        public string SortCode { get => sortCode; set => sortCode = value; }

    }
}
