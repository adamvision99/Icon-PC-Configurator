using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using IconPC.Stock.ASPPL.Models;
using IconPC.Stock.BLL.Interfaces;
using DependencyResolver = IconPC.Stock.Dependencies.DependencyResolver;
using EntitySocket = IconPC.Stock.Entities.Socket;
using ModelSocket = IconPC.Stock.ASPPL.Models.Socket;
using IconPC.Stock.ASPPL.Mappers;

namespace IconPC.Stock.ASPPL.Controllers
{
    public class SocketController : Controller
    {
        ISocketService socketService = DependencyResolver.Instance.socketService;
        IMapper<EntitySocket, ModelSocket> socketMapper = new SocketMapper();
        // GET: Socket
        public ActionResult Index()
        {
            var sockets = socketService.GetAll();
            return View(socketMapper.Map(sockets));
        }

        // GET: Socket/Details/5
        public ActionResult Details(int id)
        {
            var socket = socketMapper.Map(socketService.Get(id));
            return View(socket);
        }

        // GET: Socket/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Socket/Create
        [HttpPost]
        public ActionResult Create(ModelSocket socket)
        {
            try
            {
                var newsocket = socketService.Add(socketMapper.Map(socket));

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Socket/Edit/5
        public ActionResult Edit(int id)
        {
            var socket = socketMapper.Map(socketService.Get(id));
            return View(socket);
        }

        // POST: Socket/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ModelSocket socket)
        {
            try
            {
                socketService.Edit(id, socketMapper.Map(socket));

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Socket/Delete/5
        public ActionResult Delete(int id)
        {
            var socket = socketMapper.Map(socketService.Get(id));
            return View(socket);
        }

        // POST: Socket/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, ModelSocket socket)
        {
            try
            {
                socketService.Remove(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
