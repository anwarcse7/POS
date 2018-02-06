using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace POS.Models
{
    public class Shop
    {
        [Key]
        public int CompanyId { get; set; }

        [Required]
        [StringLength(100)]
        public string CompanyName { get; set; }

        [StringLength(10)]
        public string CompanyCode { get; set; }

        public byte[] CompanyLogo { get; set; }

        public string Phone { get; set; }

        public string Mobile { get; set; }

        public string Telephone { get; set; }

        public string Email { get; set; }

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