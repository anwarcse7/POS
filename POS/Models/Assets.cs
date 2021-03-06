﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace POS.Models
{
    public class Assets
    {
        [Key]
        public int AssetsId { get; set; }
        public string AssetsType { get; set; }
        [Required(ErrorMessage = "Enter Assets Name")]
        public string AssetsName { get; set; }
        public string Duration { get; set; }
        public string Description { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public decimal? Price { get; set; }

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