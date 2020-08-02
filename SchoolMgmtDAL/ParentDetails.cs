using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SchoolMgmt.SchoolMgmtDAL
{
    public class ParentDtails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ParentID { get; set; }
        
        [Required]
        public string FathersName { get; set; }
        public string MothersName { get; set; }
        
        [Required]
        public string  ParentAddress {get; set;}
        
        [Required]
        public int ParentContactNumer { get; set; }
        public string ParentOccupation { get; set; }
        
        [Required]
        public string AdharNumber { get; set; }
        
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