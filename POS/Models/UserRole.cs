﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace POS.Models
{
    public class UserRole
    {
        [Key]
        public int UserRoleId { get; set; }

        [StringLength(20)]
        [Required]
        public string UserRoleName { get; set; }

        public bool Status { get; set; }

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