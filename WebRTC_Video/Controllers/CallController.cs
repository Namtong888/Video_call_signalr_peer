using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebRTC_Video.Controllers
{
    [Route("[controller]")]
    public class CallController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("{id}")]
        public IActionResult VideoCall(string id)
        {
            string a = id;
            var Room = (a, "null");
            return View(Room);
        }
    }
}
