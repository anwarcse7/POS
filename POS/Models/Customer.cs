using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Glimpse.Core.ClientScript;

namespace POS.Models
{
    public class Customer
    {
        [Key]
        public Int64 CustomerId { get; set; }

        public string FullName { get; set; }

        public string Mobile { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string Address { get; set; }

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