using System;
using System.Net;
using System.Net.Http;
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
                schoolDBContext.StudentDetails.Add(studentDetail);  
                var saveResult = schoolDBContext.SaveChanges();  
                if(saveResult<1){
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                
            }
            return Ok();
        }  
        [HttpGet]
        public StudentDetail Get(int studentId)
        {
            var studentDetails = schoolDBContext.StudentDetails.Find(studentId);
        
            return studentDetails;
        }
    } 
}