using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebRTC_Video.Controllers
{
    public class CreateVideoController : Controller
    {
        public IActionResult Index()
        {
            Random num = new Random();
            int a = num.Next(1000, 9999);
            int b = 100;
            var c = (a, b);
            return View(c);
        }
    }
}
