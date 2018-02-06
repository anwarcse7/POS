using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace POS.Models
{
    public class Stock
    {
        [Key]
        public Int64 StockId { get; set; }

        public int? ProductId { get; set; }

        public double? StockIn { get; set; }

        public double? StockOut { get; set; }

        public decimal? BuyPrice { get; set; }

        public decimal? CarryingCost { get; set; }

        public decimal? OthersCost { get; set; }

        public decimal? TotalCostPrice { get; set; }

        public decimal? SalesPrice { get; set; }

        public int? SalesInvoiceId { get; set; }

        public int? PurchaseInvoiceId { get; set; }

        public DateTime? Mfg { get; set; }

        public DateTime? Exp { get; set; }

        //Buy or Sales
        public string Type { get; set; }

        public decimal? Vat { get; set; }

        public decimal? Tax { get; set; }

        //Common Property
        public Guid? CreatedUser { get; set; }
        [DataType(DataType.Date)]
        public DateTime? CreateDate { get; set; }
        public Guid? EditedUser { get; set; }
        [DataType(DataType.Date)]
        public DateTime? EditedDate { get; set; }
        public string UserIp { get; set; }

        //Foreign Key
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }

        [ForeignKey("PurchaseInvoiceId")]
        public virtual PurchaseInvoice PurchaseInvoice { get; set; }

        [ForeignKey("SalesInvoiceId")]
        public virtual SalesInvoice SalesInvoice { get; set; }
    }
}