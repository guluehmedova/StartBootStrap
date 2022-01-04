using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StartBootstrap.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace StartBootstrap.Controllers
{
    public class HomeController : Controller
    {
        private DataContext _context;
        public HomeController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Portfolios.ToList());
        }
        public IActionResult GetPortfolio(int id)
        {
            Portfolio portfolio = _context.Portfolios.FirstOrDefault(x => x.Id == id);
            return PartialView ("_PortfolioPartialViewModal", portfolio);
        }
    }
}
