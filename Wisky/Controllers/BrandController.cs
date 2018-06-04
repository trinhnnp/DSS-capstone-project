﻿using SkyWeb.DatVM.Mvc.Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Wisky.Models.LoginMenu;
using AutoMapper;
using DSS.Data.Models.Entities.Services;

namespace DSS.Controllers
{
    [Authorize]
    public class BrandController : Controller
    {
        IBrandService brandService = DependencyUtils.Resolve<IBrandService>();
        IMapper mapper = DependencyUtils.Resolve<IMapper>();

        //GET: Brand/Index
        public ActionResult Index()
        {
            var brands = this.brandService.Get().ToList();
            var brandVMs = new List<Models.BrandDetailVM>();

            foreach (var item in brands)
            {
                var b = new Models.BrandDetailVM
                {
                    Name = item.BrandName,
                    Description = item.Description,
                    Id = item.BrandID,
                };
                brandVMs.Add(b);
            }
            ViewBag.brandList = brandVMs;
            return View();
        }

        // GET: Brand/Form/:id
        public ActionResult Form(int? id)
        {
            Models.BrandDetailVM model = null;
            
            if (id!=null)
            {
                var brand = this.brandService.Get(id);
                if (brand != null)
                {
                    model = new Models.BrandDetailVM
                    {
                        Name = brand.BrandName,
                        Description = brand.Description,
                        Id = brand.BrandID,
                    };
                }
            }
            return View(model);
        }

        // POST: Brand/Add
        [HttpPost]
        public async System.Threading.Tasks.Task<ActionResult> Add(Models.BrandDetailVM model)
        {
            if (ModelState.IsValid)
            {
                var brand = new Data.Models.Entities.Brand
                {
                    BrandName = model.Name,
                    Description = model.Description,
                };
                await this.brandService.CreateAsync(brand);
                return this.RedirectToAction("Index");
            }
            return View("Form", model);
        }

        // POST: Brand/Update
        [HttpPost]
        public async System.Threading.Tasks.Task<ActionResult> Update(Models.BrandDetailVM model)
        {
            if (ModelState.IsValid)
            {
                var brand = this.brandService.Get(model.Id);
                if (brand != null)
                {
                    brand.BrandName = model.Name;
                    brand.Description = model.Description;
                }
                await this.brandService.UpdateAsync(brand);
                return this.RedirectToAction("Index");
            }
            return View("Form", model);
        }

        // GET: Brand/Delete/:id
        public ActionResult Delete(int id)
        {
            var brand = this.brandService.Get(id);
            if (brand != null)
            {
                this.brandService.Delete(brand);
            }
            return this.RedirectToAction("Index");
        }

    }
}