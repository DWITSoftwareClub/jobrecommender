using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WebApp.Models;
using WebApp.Services;

namespace WebApp.Controllers
{
    public class JobController : Controller
    {

        private readonly DataServices _data;

        
        public IActionResult Index() {

           
            return View(_data());
        }

      
    }
}
