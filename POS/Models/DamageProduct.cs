using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace POS.Models
{
    public class DamageProduct
    {
        [Key]
        public Int64 DamageProductId { get; set; }

        public double? Quantity { get; set; }

        public decimal? DamageCost { get; set; }

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
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}