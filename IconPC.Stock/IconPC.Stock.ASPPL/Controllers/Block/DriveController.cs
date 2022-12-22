using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using IconPC.Stock.ASPPL.Models;
using IconPC.Stock.BLL.Interfaces;
using DependencyResolver = IconPC.Stock.Dependencies.DependencyResolver;
using EntityDrive = IconPC.Stock.Entities.Drive;
using ModelDrive = IconPC.Stock.ASPPL.Models.Drive;
using IconPC.Stock.ASPPL.Mappers;

namespace IconPC.Stock.ASPPL.Controllers
{
    public class DriveController : Controller
    {
        IDriveService driveService = DependencyResolver.Instance.driveService;
        IMapper<EntityDrive, ModelDrive> driveMapper = new DriveMapper();
        // GET: Drive
        public ActionResult Index()
        {
            var drives = driveService.GetAll();
            return View(driveMapper.Map(drives));
        }

        // GET: Drive/Details/5
        public ActionResult Details(int id)
        {
            var drive = driveMapper.Map(driveService.Get(id));
            return View(drive);
        }

        // GET: Drive/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Drive/Create
        [HttpPost]
        public ActionResult Create(ModelDrive drive)
        {
            try
            {
                var newdrive = driveService.Add(driveMapper.Map(drive));

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Drive/Edit/5
        public ActionResult Edit(int id)
        {
            var drive = driveMapper.Map(driveService.Get(id));
            return View(drive);
        }

        // POST: Drive/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ModelDrive drive)
        {
            try
            {
                driveService.Edit(id, driveMapper.Map(drive));

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Drive/Delete/5
        public ActionResult Delete(int id)
        {
            var drive = driveMapper.Map(driveService.Get(id));
            return View(drive);
        }

        // POST: Drive/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, ModelDrive drive)
        {
            try
            {
                driveService.Remove(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
