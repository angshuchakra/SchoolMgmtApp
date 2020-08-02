using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolMgmt.SchoolMgmtDAL
{
    public class AcademicClasses
    {
        [Key]
        [Required]
        public int AcademicClassID { get; set; }
        public string ClassName { get; set; }
        public string ClassStream { get; set; }
        public string ClassSubjectCombination { get; set; }
        
        [Required]
        public int CreatedBy { get; set; }
        
        [Required]
        [Column(TypeName = "date")]
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        [Column(TypeName = "date")]
        public DateTime? UpdatedDate { get; set; }
    }
}