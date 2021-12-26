using Microsoft.AspNetCore.Mvc;
using webProject.Model;
using System.Collections.Generic;
namespace webProject.Controllers
{
    public class TestController:Controller{
        public IActionResult Index(){
            IList<string> items=new List<string>();
            items.Add("Ayoub"); items.Add("Amine");  items.Add("Yassine");items.Add("Kamal");

            ViewData["email"]="ayoubmouallim@gmail.com";
            ViewBag.contact="Ayoub Mouallim";

            return View(items);
        }
        public IActionResult List(){
            IList<Student> students=new List<Student>();
            students.Add(new Student{Id=1,Name="Ayoub",Score=99});
            students.Add(new Student{Id=2,Name="Amine",Score=80});
            students.Add(new Student{Id=3,Name="Yassine",Score=68});
            return View(students);
        }
        public IActionResult A(){
            return View();
        }
        public IActionResult B(){
            return View("BB");
        }
    }
}