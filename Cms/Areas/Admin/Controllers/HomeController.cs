using Core.Domain;
using Core.Interfaces;
using Infrastructure.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cms.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPageGroupRepository _pageGroup;
        public HomeController(PageGroupRepository PageGroup)
        {
            _pageGroup = PageGroup;
        }
        // GET: HomeController
        public ActionResult Index()
        {
            return View(_pageGroup.GetPageGroups());
        }

        // GET: HomeController/Details/5
        public ActionResult Details(int id)
        {
            return View(_pageGroup.GetPageGroupeById(id));
        }

        // GET: HomeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PageGroup pageGroup)
        {
            _pageGroup.InsertPageGroup(pageGroup);
            return RedirectToAction("Index");
        }

        // GET: HomeController/Edit/5
        public ActionResult Edit(int id)
        {
            PageGroup pageGroup = _pageGroup.GetPageGroupeById(id);
            return View(pageGroup);
        }

        // POST: HomeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PageGroup page, IFormCollection collection)
        {
                _pageGroup.UpdatePageGroup(page);
                return RedirectToAction(nameof(Index));
        }

        // GET: HomeController/Delete/5
        public ActionResult Delete(int id)
        {
            _pageGroup.GetPageGroupeById(id);
            return View();
        }

        // POST: HomeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
                _pageGroup.DeletePageGroup(id);
                return RedirectToAction(nameof(Index));
        }
    }
}
