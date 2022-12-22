using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using IconPC.Stock.ASPPL.Models;
using IconPC.Stock.BLL.Interfaces;
using DependencyResolver = IconPC.Stock.Dependencies.DependencyResolver;
using EntityMotherboard = IconPC.Stock.Entities.Motherboard;
using ModelMotherboard = IconPC.Stock.ASPPL.Models.Motherboard;
using EntitySocket = IconPC.Stock.Entities.Socket;
using ModelSocket = IconPC.Stock.ASPPL.Models.Socket;
using EntityChipset = IconPC.Stock.Entities.Chipset;
using ModelChipset = IconPC.Stock.ASPPL.Models.Chipset;
using EntityRAMtype = IconPC.Stock.Entities.RAMtype;
using ModelRAMtype = IconPC.Stock.ASPPL.Models.RAMtype;
using IconPC.Stock.ASPPL.Mappers;

namespace IconPC.Stock.ASPPL.Controllers
{
    public class MotherboardController : Controller
    {
        IMotherboardService motherboardService = DependencyResolver.Instance.motherboardService;
        IMapper<EntityMotherboard, ModelMotherboard> motherboardMapper = new MotherboardMapper();
        ISocketService socketService = DependencyResolver.Instance.socketService;
        IMapper<EntitySocket, ModelSocket> socketMapper = new SocketMapper();
        IChipsetService chipsetService = DependencyResolver.Instance.ChipsetService;
        IMapper<EntityChipset, ModelChipset> chipsetMapper = new ChipsetMapper();
        IRAMtypeService ramtypeService = DependencyResolver.Instance.rAMtypeService;
        IMapper<EntityRAMtype, ModelRAMtype> ramtypeMapper = new RAMtypeMapper();

        // GET: Motherboard
        public ActionResult Index()
        {
            var motherboards = motherboardService.GetAll();
            return View(motherboardMapper.Map(motherboards));
        }

        // GET: Motherboard/Details/5
        public ActionResult Details(int id)
        {
            var motherboard = motherboardMapper.Map(motherboardService.Get(id));
            return View(motherboard);
        }

        // GET: Motherboard/Create
        public ActionResult Create()
        {
            ViewBag.Sockets = socketMapper.Map(socketService.GetAll());
            ViewBag.Chipsets = chipsetMapper.Map(chipsetService.GetAll());
            ViewBag.RAMtypes = ramtypeMapper.Map(ramtypeService.GetAll());

            return View();
        }

        // POST: Motherboard/Create
        [HttpPost]
        public ActionResult Create(ModelMotherboard motherboard)
        {
            try
            {
                var newmotherboard = motherboardService.Add(motherboardMapper.Map(motherboard));

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Motherboard/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.Sockets = socketMapper.Map(socketService.GetAll());
            ViewBag.Chipsets = chipsetMapper.Map(chipsetService.GetAll());
            ViewBag.RAMtypes = ramtypeMapper.Map(ramtypeService.GetAll());
            var motherboard = motherboardMapper.Map(motherboardService.Get(id));
            return View(motherboard);
        }

        // POST: Motherboard/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ModelMotherboard motherboard)
        {
            try
            {
                motherboardService.Edit(id, motherboardMapper.Map(motherboard));

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Motherboard/Delete/5
        public ActionResult Delete(int id)
        {
            var motherboard = motherboardMapper.Map(motherboardService.Get(id));
            return View(motherboard);
        }

        // POST: Motherboard/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, ModelMotherboard motherboard)
        {
            try
            {
                motherboardService.Remove(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
