﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class objTransferNote
    {
        public string LocationCode { get; set; }
        public string TransferNumber { get; set; }
        public string FromSubLocation { get; set; }
        public DateTime TransferDate { get; set; }
        public double TransferValue { get; set; }
        public string User { get; set; }
        public DataTable dtTransferNote { get; set; }
        public bool IsExists { get; set; }
    }
}
