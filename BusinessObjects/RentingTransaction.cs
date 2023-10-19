﻿using System;
using System.Collections.Generic;

namespace BusinessObjects
{
    public partial class RentingTransaction
    {
        public RentingTransaction()
        {
            RentingDetails = new HashSet<RentingDetail>();
        }

        public int RentingTransationId { get; set; }
        public DateTime? RentingDate { get; set; }
        public decimal? TotalPrice { get; set; }
        public int CustomerId { get; set; }
        public byte? RentingStatus { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<RentingDetail> RentingDetails { get; set; }
    }
}
