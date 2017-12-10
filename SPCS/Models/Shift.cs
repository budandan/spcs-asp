using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SPCS.Models
{
    [Table("Shift")]
    public class Shift
    {
        [Key]
        public int ShiftID { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public String ShiftName { get; set; }
        public String Comments { get; set; }
        public int ClientID { get; set; }
        public String Day { get; set; }
        public String Repeat { get; set; }
    }
}