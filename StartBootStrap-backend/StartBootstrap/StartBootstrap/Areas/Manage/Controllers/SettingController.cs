using Microsoft.AspNetCore.Mvc;
using StartBootstrap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StartBootstrap.Areas.Manage.Controllers
{
    [Area("manage")]
    public class SettingController : Controller
    {
        private DataContext _context;
        public SettingController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Settings.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Setting setting)
        {
            _context.Settings.Add(setting);
            _context.SaveChanges();
            return RedirectToAction("index", "setting");
        }
        public IActionResult Edit(int id)
        {
            Setting setting = _context.Settings.FirstOrDefault(x => x.Id == id);
            if (setting==null)
            {
                return NotFound();
            }
            return View(setting);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Setting setting)
        {
            if(!ModelState.IsValid) { return View(); }
            Setting exsistsetting = _context.Settings.FirstOrDefault(x => x.Id == setting.Id);
            if(exsistsetting==null) { return NotFound(); }

            exsistsetting.Key = setting.Key;
            exsistsetting.Value = setting.Value;

            _context.SaveChanges();

            return RedirectToAction("index", "setting");
        }
        public IActionResult Delete(int id)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            Setting exsistsetting = _context.Settings.FirstOrDefault(x => x.Id == id);
            if (exsistsetting == null)
            {
                return NotFound();
            }
            _context.Settings.Remove(exsistsetting);
            _context.SaveChanges();
            return RedirectToAction("index", "setting");
        }
    }
}
