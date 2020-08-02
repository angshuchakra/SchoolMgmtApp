using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace SchoolMgmt.SchoolMgmtDAL
{
    public class SchoolMgmtDB : DbContext 
    {
        public SchoolMgmtDB(DbContextOptions<SchoolMgmtDB> options)
        :base(options)
        {

        }
        public DbSet<StudentDetail> StudentDetails {get; set;} 
        public DbSet<ParentDtails> ParentDetails { get; set; }
        public DbSet<LocalGuardian> LocalGuardians{get; set;}
        public DbSet<AcademicClasses> AcademicClasses{get; set;}        
    }

}