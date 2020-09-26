using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using SchoolMgmt.SchoolMgmtDAL;

namespace SchoolMgmt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController:Controller
    {
        private SchoolMgmtDB schoolDBContext;
        public StudentController (SchoolMgmtDB schoolContext)
        {
            schoolDBContext = schoolContext;
        }

        [HttpPost]
        public IActionResult Create(StudentDetail studentDetail)  
        {  
            try
            {
                var checkRecordExists = schoolDBContext.StudentDetails.Where(
                    sdetails => sdetails.StudentName == studentDetail.StudentName && 
                    sdetails.StudentRollNumber == studentDetail.StudentRollNumber &&
                    sdetails.DateOfBirth == studentDetail.DateOfBirth).FirstOrDefault();
                if(checkRecordExists !=null)
                {
                    if(checkRecordExists.StudentID >0)
                    {
                        return BadRequest();
                    }
                }
                schoolDBContext.StudentDetails.Add(studentDetail);  
                var saveResult = schoolDBContext.SaveChanges();  
                if(saveResult<1){
                    return BadRequest();
                }
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }  
        [HttpGet]
        [EnableCors("SchoolManagementPolicy")]
        public string Get(int studentId)
        {
            var studentDetails = schoolDBContext.StudentDetails.Find(studentId);
            var returner = Newtonsoft.Json.JsonConvert.SerializeObject(studentDetails);
            return returner;    
        }
    } 
}