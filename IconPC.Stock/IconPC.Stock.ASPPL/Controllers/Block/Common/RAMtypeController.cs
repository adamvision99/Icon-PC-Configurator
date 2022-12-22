using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using IconPC.Stock.ASPPL.Models;
using IconPC.Stock.BLL.Interfaces;
using DependencyResolver = IconPC.Stock.Dependencies.DependencyResolver;
using EntityRAMtype = IconPC.Stock.Entities.RAMtype;
using ModelRAMtype = IconPC.Stock.ASPPL.Models.RAMtype;
using IconPC.Stock.ASPPL.Mappers;

namespace IconPC.Stock.ASPPL.Controllers
{
    public class RAMtypeController : Controller
    {
        IRAMtypeService ramtypeService = DependencyResolver.Instance.rAMtypeService;
        IMapper<EntityRAMtype, ModelRAMtype> ramtypeMapper = new RAMtypeMapper();
        // GET: RAMtype
        public ActionResult Index()
        {
            var ramtypes = ramtypeService.GetAll();
            return View(ramtypeMapper.Map(ramtypes));
        }

        // GET: RAMtype/Details/5
        public ActionResult Details(int id)
        {
            var ramtype = ramtypeMapper.Map(ramtypeService.Get(id));
            return View(ramtype);
        }

        // GET: RAMtype/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RAMtype/Create
        [HttpPost]
        public ActionResult Create(ModelRAMtype ramtype)
        {
            try
            {
                var newramtype = ramtypeService.Add(ramtypeMapper.Map(ramtype));

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: RAMtype/Edit/5
        public ActionResult Edit(int id)
        {
            var ramtype = ramtypeMapper.Map(ramtypeService.Get(id));
            return View(ramtype);
        }

        // POST: RAMtype/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ModelRAMtype ramtype)
        {
            try
            {
                ramtypeService.Edit(id, ramtypeMapper.Map(ramtype));

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: RAMtype/Delete/5
        public ActionResult Delete(int id)
        {
            var ramtype = ramtypeMapper.Map(ramtypeService.Get(id));
            return View(ramtype);
        }

        // POST: RAMtype/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, ModelRAMtype ramtype)
        {
            try
            {
                ramtypeService.Remove(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
