using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace POS.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Eid { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public string Mobile2 { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Nid { get; set; }
        public string BirthRegistrationId { get; set; }
        public string MeritalStatus { get; set; }
        public string FathersName { get; set; }
        public string MothersName { get; set; }
        public string SpouseName { get; set; }
        public string PresentAddress { get; set; }
        public string PermanentAddress { get; set; }
        public DateTime JoininDate { get; set; }
        public string ReferancePerson { get; set; }
        public string RefPersonContact { get; set; }
        public byte[] Image { get; set; }
        public decimal? BasicSalary { get; set; }
        public string Status { get; set; }
        //Common Property
        public Guid? CreatedUser { get; set; }
        [DataType(DataType.Date)]
        public DateTime? CreateDate { get; set; }
        public Guid? EditedUser { get; set; }
        [DataType(DataType.Date)]
        public DateTime? EditedDate { get; set; }
        public string UserIp { get; set; }

        //ForeignKey
        [ForeignKey("Designation")]
        public int DesignationId { get; set; }
        public virtual Designation Designation { get; set; }
    }
}