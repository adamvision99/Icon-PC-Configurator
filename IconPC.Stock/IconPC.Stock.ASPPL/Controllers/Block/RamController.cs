using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using IconPC.Stock.ASPPL.Models;
using IconPC.Stock.BLL.Interfaces;
using DependencyResolver = IconPC.Stock.Dependencies.DependencyResolver;
using EntityRAM = IconPC.Stock.Entities.RAM;
using ModelRAM = IconPC.Stock.ASPPL.Models.RAM;
using EntityRAMtype = IconPC.Stock.Entities.RAMtype;
using ModelRAMtype = IconPC.Stock.ASPPL.Models.RAMtype;
using IconPC.Stock.ASPPL.Mappers;

namespace IconPC.Stock.ASPPL.Controllers
{
    public class RAMController : Controller
    {
        IRAMService ramService = DependencyResolver.Instance.rAMService;
        IMapper<EntityRAM, ModelRAM> ramMapper = new RAMMapper();
        IRAMtypeService ramtypeService = DependencyResolver.Instance.rAMtypeService;
        IMapper<EntityRAMtype, ModelRAMtype> ramtypeMapper = new RAMtypeMapper();
        // GET: RAM
        public ActionResult Index()
        {
            var rams = ramService.GetAll();
            return View(ramMapper.Map(rams));
        }

        // GET: RAM/Details/5
        public ActionResult Details(int id)
        {
            var ram = ramMapper.Map(ramService.Get(id));
            return View(ram);
        }

        // GET: RAM/Create
        public ActionResult Create()
        {
            ViewBag.RAMtypes = ramtypeMapper.Map(ramtypeService.GetAll());
            return View();
        }

        // POST: RAM/Create
        [HttpPost]
        public ActionResult Create(ModelRAM ram)
        {
            try
            {
                var newram = ramService.Add(ramMapper.Map(ram));

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: RAM/Edit/5
        public ActionResult Edit(int id)
        {
            var ram = ramMapper.Map(ramService.Get(id));
            ViewBag.RAMtypes = ramtypeMapper.Map(ramtypeService.GetAll());
            return View(ram);
        }

        // POST: RAM/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ModelRAM ram)
        {
            try
            {
                ramService.Edit(id, ramMapper.Map(ram));

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: RAM/Delete/5
        public ActionResult Delete(int id)
        {
            var ram = ramMapper.Map(ramService.Get(id));
            return View(ram);
        }

        // POST: RAM/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, ModelRAM ram)
        {
            try
            {
                ramService.Remove(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
