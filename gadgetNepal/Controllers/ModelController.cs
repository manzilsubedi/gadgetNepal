using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gadgetNepal.AppDbContext;
using gadgetNepal.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace gadgetNepal.Controllers
{
    public class ModelController : Controller
    {
        private readonly GadgetDbContext _db;
        
        [BindProperty]
        public ModelViewModel ModelVM { get; set; }

        public ModelController(GadgetDbContext db)
        {
            _db = db;
            ModelVM = new ModelViewModel()
            {
                Makes = _db.Makes.ToList(),
                Model = new Models.Model()
            };
        }
        public IActionResult Index()
        {
            var model = _db.Models.Include(m => m.Make);
            return View(model);
        }


        //httpget
        public IActionResult Create()
        {
            return View(ModelVM);
        }

        [HttpPost, ActionName("Create")]
        public IActionResult CreatePost()
        {
            if (!ModelState.IsValid)
            {
                return View(ModelVM);
            }
            _db.Models.Add(ModelVM.Model);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}