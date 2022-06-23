using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication2.Models;
using Microsoft.AspNetCore.Http;


namespace WebApplication2.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpGet]
        public IActionResult EmployeeDetails()
        {            
            List<Employee> emp = new List<Employee>();
            //{
            //    new Employee{Id = 1, Name="Ram",Company="Dell",Designation="Developer"},
            //    new Employee{Id = 2, Name="Sham",Company="TCS",Designation="Sales"},
            //    new Employee{Id = 3, Name="Om",Company="Dell",Designation="Manager"},
            //    new Employee{Id = 4, Name="Sid",Company="TCS",Designation="Senior Manager"},
            //};

            //ViewBag.EmployeeList=emp;

            return View();
        }
        [HttpPost]

        public IActionResult EmployeeDetails(IFormCollection fc1)
        {
            ViewBag.name = fc1["name"];
            ViewBag.company = fc1["company"];
            ViewBag.designation = fc1["designation"];
            ViewBag.salary = fc1["salary"];

            return View("Details1");

        }
        
    }
    
}
