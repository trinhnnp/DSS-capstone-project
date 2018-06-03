using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Wisky.Controllers
{
    public class BrandController : Controller
    {
        // GET: Brand
        public ActionResult Index()
        {
            return View();
        }

        // GET: Brand/Form
        public ActionResult Form(string id)
        {
            return View();
        }

        // POST: Brand/Add
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async System.Threading.Tasks.Task<ActionResult> Add()
        {

            return this.RedirectToAction("Index", "Brand");
        }
    }
}