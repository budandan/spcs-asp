using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SPCS.Models
{
    [Table("Client")]
    public class Client
    {
        [Key]
        public int ClientID { get; set; }
        public String FirstName { get; set; }
        public String Lastname { get; set; }
        public String Address1 { get; set; }
        public String Address2 { get; set; }
        public String City { get; set; }
        public String Zip { get; set; }
        public String Phone { get; set; }
        public String ImagePath { get; set; }
        public String GuardianFirstName { get; set; }
        public String GuardianLastName { get; set; }
        public String Description { get; set; }
    }
}