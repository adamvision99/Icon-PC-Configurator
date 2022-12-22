using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using IconPC.Stock.ASPPL.Models;
using IconPC.Stock.BLL.Interfaces;
using DependencyResolver = IconPC.Stock.Dependencies.DependencyResolver;
using EntityPowerUnit = IconPC.Stock.Entities.PowerUnit;
using ModelPowerUnit = IconPC.Stock.ASPPL.Models.PowerUnit;
using IconPC.Stock.ASPPL.Mappers;

namespace IconPC.Stock.ASPPL.Controllers
{
    public class PowerUnitController : Controller
    {
        IPowerUnitService powerunitService = DependencyResolver.Instance.powerUnitService;
        IMapper<EntityPowerUnit, ModelPowerUnit> powerunitMapper = new PowerUnitMapper();
        // GET: PowerUnit
        public ActionResult Index()
        {
            var powerunits = powerunitService.GetAll();
            return View(powerunitMapper.Map(powerunits));
        }

        // GET: PowerUnit/Details/5
        public ActionResult Details(int id)
        {
            var powerunit = powerunitMapper.Map(powerunitService.Get(id));
            return View(powerunit);
        }

        // GET: PowerUnit/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PowerUnit/Create
        [HttpPost]
        public ActionResult Create(ModelPowerUnit powerunit)
        {
            try
            {
                var newpowerunit = powerunitService.Add(powerunitMapper.Map(powerunit));

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: PowerUnit/Edit/5
        public ActionResult Edit(int id)
        {
            var powerunit = powerunitMapper.Map(powerunitService.Get(id));
            return View(powerunit);
        }

        // POST: PowerUnit/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ModelPowerUnit powerunit)
        {
            try
            {
                powerunitService.Edit(id, powerunitMapper.Map(powerunit));

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: PowerUnit/Delete/5
        public ActionResult Delete(int id)
        {
            var powerunit = powerunitMapper.Map(powerunitService.Get(id));
            return View(powerunit);
        }

        // POST: PowerUnit/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, ModelPowerUnit powerunit)
        {
            try
            {
                powerunitService.Remove(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
