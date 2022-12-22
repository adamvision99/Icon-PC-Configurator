using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using IconPC.Stock.ASPPL.Models;
using IconPC.Stock.BLL.Interfaces;
using DependencyResolver = IconPC.Stock.Dependencies.DependencyResolver;
using EntitySystemUnit = IconPC.Stock.Entities.SystemUnit;
using ModelSystemUnit = IconPC.Stock.ASPPL.Models.SystemUnit;
using EntityCPU = IconPC.Stock.Entities.CPU;
using ModelCPU = IconPC.Stock.ASPPL.Models.CPU;
using EntityMotherboard = IconPC.Stock.Entities.Motherboard;
using ModelMotherboard = IconPC.Stock.ASPPL.Models.Motherboard;
using EntityRAM = IconPC.Stock.Entities.RAM;
using ModelRAM = IconPC.Stock.ASPPL.Models.RAM;
using EntityVideoCard = IconPC.Stock.Entities.VideoCard;
using ModelVideoCard = IconPC.Stock.ASPPL.Models.VideoCard;
using EntityCooling = IconPC.Stock.Entities.Cooling;
using ModelCooling = IconPC.Stock.ASPPL.Models.Cooling;
using EntityDrive = IconPC.Stock.Entities.Drive;
using ModelDrive = IconPC.Stock.ASPPL.Models.Drive;
using EntityPowerUnit = IconPC.Stock.Entities.PowerUnit;
using ModelPowerUnit = IconPC.Stock.ASPPL.Models.PowerUnit;
using EntityCase = IconPC.Stock.Entities.Case;
using ModelCase = IconPC.Stock.ASPPL.Models.Case;
using IconPC.Stock.ASPPL.Mappers;

namespace IconPC.Stock.ASPPL.Controllers
{
    public class SystemUnitController : Controller
    {
        ISystemUnitService systemunitService = DependencyResolver.Instance.systemUnitService;
        IMapper<EntitySystemUnit, ModelSystemUnit> systemunitMapper = new SystemUnitMapper();
        ICPUService cpuService = DependencyResolver.Instance.cPUService;
        IMapper<EntityCPU, ModelCPU> cpuMapper = new CPUMapper();
        IMotherboardService motherboardService = DependencyResolver.Instance.motherboardService;
        IMapper<EntityMotherboard, ModelMotherboard> motherboardMapper = new MotherboardMapper();
        IRAMService ramService = DependencyResolver.Instance.rAMService;
        IMapper<EntityRAM, ModelRAM> ramMapper = new RAMMapper();
        IVideoCardService videocardService = DependencyResolver.Instance.videoCardService;
        IMapper<EntityVideoCard, ModelVideoCard> videocardMapper = new VideoCardMapper();
        ICoolingService coolingService = DependencyResolver.Instance.coolingService;
        IMapper<EntityCooling, ModelCooling> coolingMapper = new CoolingMapper();
        IDriveService driveService = DependencyResolver.Instance.driveService;
        IMapper<EntityDrive, ModelDrive> driveMapper = new DriveMapper();
        IPowerUnitService powerunitService = DependencyResolver.Instance.powerUnitService;
        IMapper<EntityPowerUnit, ModelPowerUnit> powerunitMapper = new PowerUnitMapper();
        ICaseService _caseService = DependencyResolver.Instance.caseService;
        IMapper<EntityCase, ModelCase> _caseMapper = new CaseMapper();
        // GET: SystemUnit
        public ActionResult Index()
        {
            var systemunits = systemunitService.GetAll();
            return View(systemunitMapper.Map(systemunits));
        }

        // GET: SystemUnit/Details/5
        public ActionResult Details(int id)
        {
            var systemunit = systemunitMapper.Map(systemunitService.Get(id));
            return View(systemunit);
        }

        // GET: SystemUnit/Create
        public ActionResult Create()
        {
            ViewBag.CPU = cpuMapper.Map(cpuService.GetAll());
            ViewBag.Motherboard = motherboardMapper.Map(motherboardService.GetAll());
            ViewBag.RAM = ramMapper.Map(ramService.GetAll());
            ViewBag.VideoCard = videocardMapper.Map(videocardService.GetAll());
            ViewBag.Cooling = coolingMapper.Map(coolingService.GetAll());
            ViewBag.Drive = driveMapper.Map(driveService.GetAll());
            ViewBag.PowerUnit = powerunitMapper.Map(powerunitService.GetAll());
            ViewBag.Case = _caseMapper.Map(_caseService.GetAll());
            return View();
        }

        // POST: SystemUnit/Create
        [HttpPost]
        public ActionResult Create(ModelSystemUnit systemunit)
        {
            try
            {
                var newsystemunit = systemunitService.Add(systemunitMapper.Map(systemunit));

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SystemUnit/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.CPU = cpuMapper.Map(cpuService.GetAll());
            ViewBag.Motherboard = motherboardMapper.Map(motherboardService.GetAll());
            ViewBag.RAM = ramMapper.Map(ramService.GetAll());
            ViewBag.VideoCard = videocardMapper.Map(videocardService.GetAll());
            ViewBag.Cooling = coolingMapper.Map(coolingService.GetAll());
            ViewBag.Drive = driveMapper.Map(driveService.GetAll());
            ViewBag.PowerUnit = powerunitMapper.Map(powerunitService.GetAll());
            ViewBag.Case = _caseMapper.Map(_caseService.GetAll());
            var systemunit = systemunitMapper.Map(systemunitService.Get(id));
            return View(systemunit);
        }

        // POST: SystemUnit/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ModelSystemUnit systemunit)
        {
            try
            {
                systemunitService.Edit(id, systemunitMapper.Map(systemunit));

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SystemUnit/Delete/5
        public ActionResult Delete(int id)
        {
            var systemunit = systemunitMapper.Map(systemunitService.Get(id));
            return View(systemunit);
        }

        // POST: SystemUnit/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, ModelSystemUnit systemunit)
        {
            try
            {
                systemunitService.Remove(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
