using BootcampHomework1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BootcampHomework1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(FormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                var statusOfPost = new StatusViewModel
                {
                    Data = null,
                    Error = "Hatali giris denemesi",
                    Success = false
                };

                ViewData["message"] = String.Format("<div class='alert alert-danger'>" + "Data : {0}<br/> Success: {1}<br/> Error: {2}<br/> </div>", statusOfPost.Data="null", statusOfPost.Success, statusOfPost.Error);
                return View();
            }
            var statusOfPostCorrect = new StatusViewModel
            {
                Data = "Giris basarili, tebrikler",
                Error = null,
                Success = true
            };
            ViewData["message"] = String.Format("<div class='alert alert-success'>" + "Data : {0}<br/> Success: {1}<br/> Error: {2}<br/> </div>", statusOfPostCorrect.Data , statusOfPostCorrect.Success, statusOfPostCorrect.Error="null"); ;
            return View(model);
        }

    }
}
