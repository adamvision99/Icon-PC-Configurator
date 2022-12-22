using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using IconPC.Stock.ASPPL.Models;
using IconPC.Stock.BLL.Interfaces;
using DependencyResolver = IconPC.Stock.Dependencies.DependencyResolver;
using EntityChipset = IconPC.Stock.Entities.Chipset;
using ModelChipset = IconPC.Stock.ASPPL.Models.Chipset;
using IconPC.Stock.ASPPL.Mappers;

namespace IconPC.Stock.ASPPL.Controllers
{
    public class ChipsetController : Controller
    {
        IChipsetService chipsetService = DependencyResolver.Instance.ChipsetService;
        IMapper<EntityChipset, ModelChipset> chipsetMapper = new ChipsetMapper();
        // GET: Chipset
        public ActionResult Index()
        {
            var chipsets = chipsetService.GetAll();
            return View(chipsetMapper.Map(chipsets));
        }

        // GET: Chipset/Details/5
        public ActionResult Details(int id)
        {
            var chipset = chipsetMapper.Map(chipsetService.Get(id));
            return View(chipset);
        }

        // GET: Chipset/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Chipset/Create
        [HttpPost]
        public ActionResult Create(ModelChipset chipset)
        {
            try
            {
                var newchipset = chipsetService.Add(chipsetMapper.Map(chipset));

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Chipset/Edit/5
        public ActionResult Edit(int id)
        {
            var chipset = chipsetMapper.Map(chipsetService.Get(id));
            return View(chipset);
        }

        // POST: Chipset/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ModelChipset chipset)
        {
            try
            {
                chipsetService.Edit(id, chipsetMapper.Map(chipset));

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Chipset/Delete/5
        public ActionResult Delete(int id)
        {
            var chipset = chipsetMapper.Map(chipsetService.Get(id));
            return View(chipset);
        }

        // POST: Chipset/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, ModelChipset chipset)
        {
            try
            {
                chipsetService.Remove(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
