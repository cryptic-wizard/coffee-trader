using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CoffeeTraderAPI.Data;
using CoffeeTraderAPI.Models;

namespace CoffeeTraderAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Add action logic here
            return View();
        }
    }
}