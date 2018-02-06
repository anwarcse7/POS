using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace POS.Models
{
    public class ShopBranch
    {
        [Key]
        public int ShopBranchId { get; set; }

        public string ShopCode { get; set; }

        public string ShopName { get; set; }

        public string Mobile { get; set; }

        public string Mobile2 { get; set; }

        public string Email { get; set; }

        public string Location { get; set; }

        public string Address { get; set; }

        //Common Property
        public Guid? CreatedUser { get; set; }
        [DataType(DataType.Date)]
        public DateTime? CreateDate { get; set; }
        public Guid? EditedUser { get; set; }
        [DataType(DataType.Date)]
        public DateTime? EditedDate { get; set; }
    }
}