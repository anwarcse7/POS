using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace POS.Models
{
    public class EmployeeSalary
    {
        [Key]
        public Int64 EmployeeSalaryId { get; set; }

        public DateTime SalaryMonth { get; set; }

        public decimal? TotalPayment { get; set; }

        public int? EmployeeId { get; set; }

        //Common Property
        public Guid? CreatedUser { get; set; }
        [DataType(DataType.Date)]
        public DateTime? CreateDate { get; set; }
        public Guid? EditedUser { get; set; }
        [DataType(DataType.Date)]
        public DateTime? EditedDate { get; set; }
        public string UserIp { get; set; }

        //ForeignKey
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }
    }
}