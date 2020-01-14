using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelBindingSample.Models;

namespace ModelBindingSample.Controllers
{
    public class FormsController : Controller
    {
        [HttpGet] //This method will fire for get requests, Attribute
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost] //When you post data to the server, user clicks "submit and sends form data"
        public IActionResult Index(IFormCollection data) //requires to add a using
        {
            //Validate all form data

            // Map form data to C# object
            Student s = new Student();
            s.FullName = data["full-name"];
            s.DateOfBirth = Convert.ToDateTime(data["dob"]);
            s.FavoriteNumber = Convert.ToInt32(data["fav-number"]);

            //Add to database

            ViewData["Message"] =
                    "Student Added Successfully";

            return View();
        }
    }
}