using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ORMAprill29ASPMvc6.Models;

namespace ORMAprill29ASPMvc6.Controllers
{
    public class FirstController : Controller
    {
        Student29AprilContext ORM;
        public FirstController(Student29AprilContext _ORM)
        {
            ORM = _ORM;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Student()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Student( Studinfo s)
        {
            ORM.Studinfo.Add(s);
            ORM.SaveChanges();

            return View();
        }

        [HttpGet]
        public IActionResult Principleinfo()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Principleinfo(Principle p)
        {
            ORM.Principle.Add(p);
            ORM.SaveChanges();

            ViewBag.massage = "This is field have been Successful ";

            return View();
        }
    }
}