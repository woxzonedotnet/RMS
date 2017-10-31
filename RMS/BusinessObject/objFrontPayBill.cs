using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class objFrontPayBill
    {
        public double TotalAmount { get; set; }
        public double TotalBalance { get; set; }

        //Cash
        public double CashAmount { get; set; }

        //Cheque
        public string ChequeBank { get; set; }
        public string ChequeNumber { get; set; }
        public DateTime ChequeDate { get; set; }
        public double ChequeAmount { get; set; }

        //Card
        public string CardBank { get; set; }
        public string CardType { get; set; }
        public string CardNumber { get; set; }
        public double CardAmount { get; set; }
    }
}
