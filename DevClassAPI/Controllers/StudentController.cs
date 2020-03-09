using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevClassLibrary;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevClassAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet("GetStudents")]
        public List<Devuser> GetStudents()
        {

            //string token = HttpContext.Request.Headers["token"];
            //if (!token.Equals("12345"))
            //{
            //    return null;
            //}
            //string token = HttpContext.Request.Headers["token"];
            //Console.WriteLine(token);
            List<Devuser> devusers = new List<Devuser>();
            Devuser dev = new Devuser{
                OID = "0001",
                DOB = new DateTime(1992,1,22),
                Name = "Abc Def",
                Gender= "Male"
            };
            devusers.Add(dev);
            dev = new Devuser
            {
                OID = "0002",
                DOB = new DateTime(1994, 1, 22),
                Name = "Abc Degfd",
                Gender = "Male"
            };
            devusers.Add(dev);
            dev = new Devuser
            {
                OID = "0003",
                DOB = new DateTime(1992, 5, 22),
                Name = "Ac Def",
                Gender = "Female"
            };
            devusers.Add(dev);
            dev = new Devuser
            {
                OID = "0004",
                DOB = new DateTime(1995, 1, 22),
                Name = "Xsa as",
                Gender = "Male"
            };
            devusers.Add(dev);
            dev = new Devuser
            {
                OID = "0005",
                DOB = new DateTime(1992, 1, 21),
                Name = "Mao As",
                Gender = "Female"
            };
            devusers.Add(dev);
            dev = new Devuser
            {
                OID = "0006",
                DOB = new DateTime(1992, 2, 12),
                Name = "Posd dsf",
                Gender = "Male"
            };
            devusers.Add(dev);
            return devusers; 
        }
    }
}