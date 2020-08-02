using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolMgmt.SchoolMgmtDAL
{
    public class StudentDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int StudentID { get; set; }      
        [Required]
        public int StudentRollNumber { get; set; }        
        
        [MaxLength(100)]
        [Required]
        public string StudentName { get; set; }        
        
        [Required]
        [Column(TypeName = "date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode=true)]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth {get; set;}
        
        [MaxLength(100)]
        public string studentSex {get;set;}
        
        [MaxLength(500)]
        public string CurrentAddress {get; set;}
        
        [MaxLength(500)]
        [Required]
        public string PermanentAddress{get; set;}
        
        public int ContactNumber{get; set;}
        [MaxLength(50)]
        public string Nationality{get; set;}
        [Required]
        public AcademicClasses AcademicClass {get; set;}

        [Required]
        public ParentDtails Parent {get; set;}
        public LocalGuardian LocalGuardian {get; set;}
        
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