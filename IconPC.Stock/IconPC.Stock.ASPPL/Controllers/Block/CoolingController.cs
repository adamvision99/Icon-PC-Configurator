using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using IconPC.Stock.ASPPL.Models;
using IconPC.Stock.BLL.Interfaces;
using DependencyResolver = IconPC.Stock.Dependencies.DependencyResolver;
using EntityCooling = IconPC.Stock.Entities.Cooling;
using ModelCooling = IconPC.Stock.ASPPL.Models.Cooling;
using IconPC.Stock.ASPPL.Mappers;

namespace IconPC.Stock.ASPPL.Controllers
{
    public class CoolingController : Controller
    {
        ICoolingService coolingService = DependencyResolver.Instance.coolingService;
        IMapper<EntityCooling, ModelCooling> coolingMapper = new CoolingMapper();
        // GET: Cooling
        public ActionResult Index()
        {
            var coolings = coolingService.GetAll();
            return View(coolingMapper.Map(coolings));
        }

        // GET: Cooling/Details/5
        public ActionResult Details(int id)
        {
            var cooling = coolingMapper.Map(coolingService.Get(id));
            return View(cooling);
        }

        // GET: Cooling/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cooling/Create
        [HttpPost]
        public ActionResult Create(ModelCooling cooling)
        {
            try
            {
                var newcooling = coolingService.Add(coolingMapper.Map(cooling));

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cooling/Edit/5
        public ActionResult Edit(int id)
        {
            var cooling = coolingMapper.Map(coolingService.Get(id));
            return View(cooling);
        }

        // POST: Cooling/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ModelCooling cooling)
        {
            try
            {
                coolingService.Edit(id, coolingMapper.Map(cooling));

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cooling/Delete/5
        public ActionResult Delete(int id)
        {
            var cooling = coolingMapper.Map(coolingService.Get(id));
            return View(cooling);
        }

        // POST: Cooling/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, ModelCooling cooling)
        {
            try
            {
                coolingService.Remove(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
