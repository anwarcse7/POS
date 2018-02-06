using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace POS.Models
{
    public class Manufacturer
    {
        [Key]
        public int ManufacturerId { get; set; }

        public string ManufacturerName { get; set; }

        public string ManufacturerCode { get; set; }

        public string ContactPerson { get; set; }

        public string ContactNo { get; set; }

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