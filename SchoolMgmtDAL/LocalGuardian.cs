using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolMgmt.SchoolMgmtDAL
{
    public class LocalGuardian
    {
        [Key]
        public int LocalGuardianID { get; set; }
        public string LGName { get; set; }
        public string  LGAddress {get; set;}
        public int LGContactNumer { get; set; }
        public string LGOccupation { get; set; }
        public string RelationWithParent { get; set; }
        public string AdharNumber { get; set; }
        public int CreatedBy { get; set; }
        [Column(TypeName = "date")]
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        [Column(TypeName = "date")]
        public DateTime? UpdatedDate { get; set; }
    }
}