using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class objBankCards
    {
        public string CardCode { get; set; }
        public string BankCode { get; set; }
        public string CardType { get; set; }
        public string Currency { get; set; }
        public double Commision { get; set; }
        public int Status { get; set; }
        public bool IsExists { get; set; }
    }
}
