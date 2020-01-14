using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModelBindingSample.Models;

namespace ModelBindingSample.Controllers
{
    public class ModelBindingController : Controller
    {
        [HttpGet] //Default, not required
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Student s) //Have to set up a using to use Student using ModelBindingSample.Model
        {
            // Ensures model is in valid state
            if (ModelState.IsValid)
            {
                //StudentDB.add(s); (((example for the assignment)))
                return RedirectToAction("Index", "Home");
            }
            else // Validation problems
            {
                // You CAN pass the model back to the view
                // but this is now done automatically
                // by just returning the view
                return View(s);
            }
        }
    }
}