using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using yrjournal.Data;
using yrjournal.Models;

namespace yrjournal.Controllers
{
    [Authorize]
    public class JournalController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _dbContext;

        public JournalController(ILogger<HomeController> logger,ApplicationDbContext dbContext)
        {
            _logger = logger;
            _dbContext=dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult JournalDetails(JournalModel model)
        {
            if(Request.Form.Files.Count>0){
                model.File=_convertIFormFileToBase64(Request.Form.Files[0]);
            }
            model.Id=Guid.NewGuid().ToString();
            model.UserId =_dbContext.Users.FirstOrDefault(x=>x.Email==User.Identity.Name).Id;
            _dbContext.Journal.Add(model);
            _dbContext.SaveChanges();
            return View(model);
        }
        [HttpGet("/Journal/JournalDetailsById/{id}")]
        public IActionResult JournalDetailsById(string id)
        {
            var journal=_dbContext.Journal.FirstOrDefault(x=>x.Id==id);
            return View("JournalDetails",journal);
        }

        public IActionResult Report()
        {
            var userId=_dbContext.Users.FirstOrDefault(x=>x.Email==User.Identity.Name).Id;
            var journals=_dbContext.Journal.Where(x=>x.UserId==userId).ToList();
            return View(journals);
        }

        public IActionResult AllJournals()
        {
            var journals = _dbContext.Journal.ToList();
            foreach(var item in journals){
                item.UserEmail=_dbContext.Users.FirstOrDefault(x=>x.Id==item.UserId).Email;
            }
            return View(journals);
        }


        private string _convertIFormFileToBase64(IFormFile file)
        {
                if (file.Length > 0)
                {
                    using (var ms = new MemoryStream())
                    {
                        file.CopyTo(ms);
                        var fileBytes = ms.ToArray();
                        string s = Convert.ToBase64String(fileBytes);
                        return s;
                    // act on the Base64 data
                    }
                }
                return "";
        }
    }
}
