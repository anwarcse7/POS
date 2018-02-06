using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace POS.Models
{
    public class SalesInvoice
    {
        public int SalesInvoiceId { get; set; }
        public string SalesInvoiceNo { get; set; }
        public DateTime SalesDate { get; set; }
        public decimal? TotalSaleValue { get; set; }

        //Common Property
        public Guid? CreatedUser { get; set; }
        [DataType(DataType.Date)]
        public DateTime? CreateDate { get; set; }
        public Guid? EditedUser { get; set; }
        [DataType(DataType.Date)]
        public DateTime? EditedDate { get; set; }
        public string UserIp { get; set; }
    }
}