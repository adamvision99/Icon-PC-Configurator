using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using IconPC.Stock.ASPPL.Models;
using IconPC.Stock.BLL.Interfaces;
using DependencyResolver = IconPC.Stock.Dependencies.DependencyResolver;
using EntityCPU = IconPC.Stock.Entities.CPU;
using ModelCPU = IconPC.Stock.ASPPL.Models.CPU;
using EntitySocket = IconPC.Stock.Entities.Socket;
using ModelSocket = IconPC.Stock.ASPPL.Models.Socket;
using IconPC.Stock.ASPPL.Mappers;

namespace IconPC.Stock.ASPPL.Controllers
{
    public class CPUController : Controller
    {
        ICPUService cpuService = DependencyResolver.Instance.cPUService;
        IMapper<EntityCPU, ModelCPU> cpuMapper = new CPUMapper();
        ISocketService socketService = DependencyResolver.Instance.socketService;
        IMapper<EntitySocket, ModelSocket> socketMapper = new SocketMapper();
        // GET: CPU
        public ActionResult Index()
        {
            var cpus = cpuService.GetAll();
            return View(cpuMapper.Map(cpus));
        }

        // GET: CPU/Details/5
        public ActionResult Details(int id)
        {
            var cpu = cpuMapper.Map(cpuService.Get(id));
            return View(cpu);
        }

        // GET: CPU/Create
        public ActionResult Create()
        {
            ViewBag.Sockets = socketMapper.Map(socketService.GetAll());
            return View();
        }

        // POST: CPU/Create
        [HttpPost]
        public ActionResult Create(ModelCPU cpu)
        {
            try
            {
                var newcpu = cpuService.Add(cpuMapper.Map(cpu));

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CPU/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.Sockets = socketMapper.Map(socketService.GetAll());
            var cpu = cpuMapper.Map(cpuService.Get(id));
            return View(cpu);
        }

        // POST: CPU/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ModelCPU cpu)
        {
            try
            {
                cpuService.Edit(id, cpuMapper.Map(cpu));

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CPU/Delete/5
        public ActionResult Delete(int id)
        {
            var cpu = cpuMapper.Map(cpuService.Get(id));
            return View(cpu);
        }

        // POST: CPU/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, ModelCPU cpu)
        {
            try
            {
                cpuService.Remove(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
