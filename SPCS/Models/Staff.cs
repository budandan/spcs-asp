using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SPCS.Models
{
    [Table("Staff")]
    public class Staff
    {
        [Key]
        public int StaffID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Address1 { get; set; }
        public String Address2 { get; set; }
        public String City { get; set; }
        public String Zip { get; set; }
        public String Phone { get; set; }
        public String ImagePath { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public String Role { get; set; }
    }
}