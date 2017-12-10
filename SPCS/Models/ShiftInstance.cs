using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SPCS.Models
{
    [Table("ShiftInstance")]
    public class ShiftInstance
    {
        [Key]
        public int ShiftInstanceID { get; set; }
        public int AssignedStaffID { get; set; }
        public DateTime Date { get; set; }
        public bool WasCovered { get; set; }
        public bool IsAvailableForCover { get; set; }
        public bool HasPotentialStaffForCover { get; set; }
        public int? NewAssignedStaffID { get; set; }
        public bool ChoresDone { get; set; }
        public bool MedicineGiven { get; set; }
        public String Comments { get; set; }
        public bool? CommentsRead { get; set; }
        public int ShiftID { get; set; }
    }
}