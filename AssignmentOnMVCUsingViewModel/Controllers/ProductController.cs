using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AssignmentOnMVCUsingViewModel.Models;

namespace AssignmentOnMVCUsingViewModel.Controllers
{
    public class ProductController : Controller
    {
        public static List<Product> p = new List<Product>
            {
                new Product{Pid=001,Pname="Puma",Pprice=200,Pstock=5000 },
                new Product{Pid=002,Pname="Nike",Pprice=100,Pstock=2000 },
                new Product{Pid=003,Pname="Reebok",Pprice=500,Pstock=1000 }
            };
        public  IActionResult Index()
        {
          
            return View(p);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product x)
        {
            p.Add(x);
            return RedirectToAction("Index");
           }
        }
    }

