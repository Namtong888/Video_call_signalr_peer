using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebRTC_Video.Controllers
{
    public class JoinVideoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
