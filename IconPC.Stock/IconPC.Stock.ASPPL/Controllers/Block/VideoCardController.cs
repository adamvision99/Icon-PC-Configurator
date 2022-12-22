using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using IconPC.Stock.ASPPL.Models;
using IconPC.Stock.BLL.Interfaces;
using DependencyResolver = IconPC.Stock.Dependencies.DependencyResolver;
using EntityVideoCard = IconPC.Stock.Entities.VideoCard;
using ModelVideoCard = IconPC.Stock.ASPPL.Models.VideoCard;
using IconPC.Stock.ASPPL.Mappers;

namespace IconPC.Stock.ASPPL.Controllers
{
    public class VideoCardController : Controller
    {
        IVideoCardService videocardService = DependencyResolver.Instance.videoCardService;
        IMapper<EntityVideoCard, ModelVideoCard> videocardMapper = new VideoCardMapper();
        // GET: VideoCard
        public ActionResult Index()
        {
            var videocards = videocardService.GetAll();
            return View(videocardMapper.Map(videocards));
        }

        // GET: VideoCard/Details/5
        public ActionResult Details(int id)
        {
            var videocard = videocardMapper.Map(videocardService.Get(id));
            return View(videocard);
        }

        // GET: VideoCard/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VideoCard/Create
        [HttpPost]
        public ActionResult Create(ModelVideoCard videocard)
        {
            try
            {
                var newvideocard = videocardService.Add(videocardMapper.Map(videocard));

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: VideoCard/Edit/5
        public ActionResult Edit(int id)
        {
            var videocard = videocardMapper.Map(videocardService.Get(id));
            return View(videocard);
        }

        // POST: VideoCard/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ModelVideoCard videocard)
        {
            try
            {
                videocardService.Edit(id, videocardMapper.Map(videocard));

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: VideoCard/Delete/5
        public ActionResult Delete(int id)
        {
            var videocard = videocardMapper.Map(videocardService.Get(id));
            return View(videocard);
        }

        // POST: VideoCard/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, ModelVideoCard videocard)
        {
            try
            {
                videocardService.Remove(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
