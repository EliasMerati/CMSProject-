using Core;
using Core.Domain;
using Core.Interfaces;
using Infrastructure.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cms.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly IPageGroupRepository _PageGroup;
        public HomeController(IPageGroupRepository PageGroup)
        {
            _PageGroup = PageGroup;
        }
        [Route("/Admin/Index")]
        // GET: HomeController
        public ActionResult Index()
        {
            return View(_PageGroup.GetPageGroups());
        }
        [Route("/Admin/Details")]
        // GET: HomeController/Details/5
        public ActionResult Details(int id)
        {
            PageGroup pagegroup = _PageGroup.GetPageGroupeById(id);
            return View(pagegroup);
        }

        [Route("/Admin/Create")]
        // GET: HomeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("/Admin/Create")]
        public ActionResult Create(PageGroup pagegroup)
        {
            _PageGroup.InsertPageGroup(pagegroup);
            return RedirectToAction(nameof(Index));
        }
        [Route("/Admin/Edit")]
        // GET: HomeController/Edit/5
        public ActionResult Edit(int id)
        {
            PageGroup pagegroup = _PageGroup.GetPageGroupeById(id);
            return View(pagegroup);
        }

        // POST: HomeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("/Admin/Edit")]
        public ActionResult Edit(PageGroup pagegroup)
        {
            if (!ModelState.IsValid)
                return View(pagegroup);

            _PageGroup.UpdatePageGroup(pagegroup);
            return RedirectToAction(nameof(Index));
        }
        [Route("/Admin/Delete")]
        // GET: HomeController/Delete/5
        public ActionResult Delete(int id)
        {
            PageGroup pagegroup = _PageGroup.GetPageGroupeById(id);
            return View(pagegroup);
        }

        // POST: HomeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("/Admin/Delete")]
        public ActionResult Delete(PageGroup pagegroup)
        {
            _PageGroup.DeletePageGroup(pagegroup);

            return RedirectToAction(nameof(Index));

        }
    }
}
