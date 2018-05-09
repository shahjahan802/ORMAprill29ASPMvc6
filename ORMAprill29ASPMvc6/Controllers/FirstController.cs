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
            [HttpGet]
            public IActionResult StudentAllShow()
            {
            IList<Studinfo> s = ORM.Studinfo.ToList<Studinfo>();
            return View(s);
             }
        //[HttpGet]
        //    public IActionResult StudentDetail()
        //    {
        //    return View();
        //     }

        //[HttpPost]
        public IActionResult StudentDetail(int id)
            {
            Studinfo std = ORM.Studinfo.Where(abc => abc.Id == id).SingleOrDefault<Studinfo>();
            return View(std);
             }
       
        //[HttpPost]
           public IActionResult StudentDelete(Studinfo s)
        {
            ORM.Studinfo.Remove(s);
            ORM.SaveChanges();
            return RedirectToAction("StudentAllShow");
           
        }
        [HttpGet]
        public IActionResult StudentSearch()
        {
           
            return View();
        }
        [HttpPost]
        public IActionResult StudentSearch(string pmeter)
        {
            IList<Studinfo> std=ORM.Studinfo.Where(s => s.Name.Contains(pmeter)).ToList<Studinfo>();
            return View(std);
        }
       
    }
}