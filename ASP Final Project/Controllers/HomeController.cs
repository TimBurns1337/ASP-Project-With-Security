
using ASP_Final_Project.Data;
using ASP_Final_Project.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Net_project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [Authorize]
        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult Search(string gpc)
        {
            var gpcContext = _context.GamingPCs.Where(s => s.Name == gpc).ToList();            
            return View("SearchResult", gpcContext);
            //return View();
        }
        


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        /*
        [HttpPost]
        public RedirectToActionResult Search(SearchViewModel vm)
        {
           
                var search = new SearchData(TempData)
                {
                    SearchTerm = vm.SearchTerm                   
                };
                return RedirectToAction("Search");
            
            
        }

        [HttpGet]
        public ViewResult Search()
        {
            var search = new SearchData(TempData);

                
                   search.Where = b => b.Title.Contains(vm.SearchTerm);
                    vm.Header = $"Search results for book title '{vm.SearchTerm}'";
               
           
        }
        */
    }
}
