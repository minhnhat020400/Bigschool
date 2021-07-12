using Bigschool.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Bigschool.Controllers
{
    [Authorize]
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _Dbcontext;
        public AttendancesController()
        {
            _Dbcontext = new ApplicationDbContext();
        }
        [HttpPost]
        public IHttpActionResult Attend([FromBody] int courseId)
        {
            var attendance = new Attendance 
            {
                CourseId = courseId,
                AttendeeId = User.Identity.GetUserId()
            };
            _Dbcontext.attendances.Add(attendance);
            _Dbcontext.SaveChanges();
            return Ok();
        }
    }
}
