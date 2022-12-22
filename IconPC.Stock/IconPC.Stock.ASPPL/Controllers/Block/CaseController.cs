using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using IconPC.Stock.ASPPL.Models;
using IconPC.Stock.BLL.Interfaces;
using DependencyResolver = IconPC.Stock.Dependencies.DependencyResolver;
using EntityCase = IconPC.Stock.Entities.Case;
using ModelCase = IconPC.Stock.ASPPL.Models.Case;
using IconPC.Stock.ASPPL.Mappers;

namespace IconPC.Stock.ASPPL.Controllers
{
    public class CaseController : Controller
    {
        ICaseService _caseService = DependencyResolver.Instance.caseService;
        IMapper<EntityCase, ModelCase> _caseMapper = new CaseMapper();
        // GET: Case
        public ActionResult Index()
        {
            var _cases = _caseService.GetAll();
            return View(_caseMapper.Map(_cases));
        }

        // GET: Case/Details/5
        public ActionResult Details(int id)
        {
            var _case = _caseMapper.Map(_caseService.Get(id));
            return View(_case);
        }

        // GET: Case/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Case/Create
        [HttpPost]
        public ActionResult Create(ModelCase _case)
        {
            try
            {
                var new_case = _caseService.Add(_caseMapper.Map(_case));

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Case/Edit/5
        public ActionResult Edit(int id)
        {
            var _case = _caseMapper.Map(_caseService.Get(id));
            return View(_case);
        }

        // POST: Case/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ModelCase _case)
        {
            try
            {
                _caseService.Edit(id, _caseMapper.Map(_case));

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Case/Delete/5
        public ActionResult Delete(int id)
        {
            var _case = _caseMapper.Map(_caseService.Get(id));
            return View(_case);
        }

        // POST: Case/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, ModelCase _case)
        {
            try
            {
                _caseService.Remove(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
