using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using StartBootstrap.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace StartBootstrap.Areas.Manage.Controllers
{
    [Area("manage")]
    public class PortfolioController : Controller
    {
        private DataContext _context;
        private IWebHostEnvironment _env;
        public PortfolioController(DataContext context,IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index(int page=1)
        {
            ViewBag.TotalPage = (int)Math.Ceiling(Convert.ToDouble(_context.Portfolios.Count()) / 8);
            ViewBag.SelectedPage = page;
            return View(_context.Portfolios.Skip((page-1)*8).Take(8).ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Portfolio portfolio)
        {
            if (portfolio.ImageFile == null)
            { ModelState.AddModelError("ImageFile", "Image is required"); }
            if(portfolio.ImageFile.Length > 2097152)
            { ModelState.AddModelError("ImageFile", "Max size is 2MB"); }
            if(portfolio.ImageFile.ContentType != "image/jpeg" && portfolio.ImageFile.ContentType!="image/png")
            { ModelState.AddModelError("ImageFile","Content type is not true"); }

            string filename = portfolio.ImageFile.FileName.Length <= 64 ? portfolio.ImageFile.FileName : portfolio.ImageFile.FileName.Substring(portfolio.ImageFile.FileName.Length - 64, 64);
            filename = Guid.NewGuid().ToString() + filename;
            string path = Path.Combine(_env.WebRootPath, "uploads/portfolios", filename);

            using (FileStream stream= new FileStream(path,FileMode.Create))
            {
                portfolio.ImageFile.CopyTo(stream);
            }

            if(!ModelState.IsValid) { return View(); }

            portfolio.Image = filename;
            _context.Portfolios.Add(portfolio);
            _context.SaveChanges();

            return RedirectToAction("index", "portfolio");
        }
        public IActionResult Edit(int id)
        {
            Portfolio portfolio = _context.Portfolios.FirstOrDefault(x => x.Id == id);
            if (portfolio==null)
            {
                return NotFound();
            }
            return View(portfolio);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Portfolio portfolio)
        {
            if(!ModelState.IsValid) { return View(); }
            Portfolio exsistportfolio = _context.Portfolios.FirstOrDefault(x => x.Id == portfolio.Id);
            if(exsistportfolio==null) { return NotFound(); }

            string oldpath = Path.Combine(_env.WebRootPath, "uploads/portfolios", exsistportfolio.Image);
            if (System.IO.File.Exists(oldpath))
            {
                System.IO.File.Delete(oldpath);
            }

            if (portfolio.ImageFile != null)
            {
                if (portfolio.ImageFile.Length > 2097152)
                { ModelState.AddModelError("ImageFile", "Max size is 2MB"); }
                if (portfolio.ImageFile.ContentType != "image/jpeg" && portfolio.ImageFile.ContentType != "image/png")
                { ModelState.AddModelError("ImageFile", "Content type is not true"); }

                string filename = portfolio.ImageFile.FileName.Length <= 64 ? portfolio.ImageFile.FileName : portfolio.ImageFile.FileName.Substring(portfolio.ImageFile.FileName.Length - 64, 64);
                filename = Guid.NewGuid().ToString() + filename;
                string path = Path.Combine(_env.WebRootPath, "uploads/portfolios", filename);

                using (FileStream stream= new FileStream(path,FileMode.Create))
                {
                    portfolio.ImageFile.CopyTo(stream);
                }

                exsistportfolio.Image = filename;
            }

            exsistportfolio.Title = portfolio.Title;
            exsistportfolio.Desc = portfolio.Desc;

            _context.SaveChanges();

            return RedirectToAction("index", "portfolio");

        }
        public IActionResult Delete(int id)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            Portfolio excistportfolio = _context.Portfolios.FirstOrDefault(x => x.Id == id);
            if(excistportfolio == null) { return NotFound(); }
            _context.Portfolios.Remove(excistportfolio);
            _context.SaveChanges();
            return RedirectToAction("index", "portfolio");
        }
    }
}
