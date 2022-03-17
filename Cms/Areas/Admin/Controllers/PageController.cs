using Core;
using Core.Domain;
using Core.Interfaces;
using Infrastructure;
using Infrastructure.Conventor;
using Infrastructure.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Web;
using System.IO;

namespace Cms.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PageController : Controller
    {

        private readonly IPageRepository _Page;
        private readonly IPageGroupRepository _Pagegroup;
        public PageController(IPageRepository Page, IPageGroupRepository Pagegroup)
        {
            _Page = Page;
            _Pagegroup = Pagegroup;
        }

        [Route("/Admin/Page/Index")]
        // GET: PageController
        public ActionResult Index()
        {
            return View(_Page.GetPages());
        }

        [Route("/Admin/Page/Detail")]
        // GET: PageController/Details/5
        public ActionResult Details(int id)
        {
            return View(_Page.GetPageById(id));
        }

        [Route("/Admin/Page/Create")]
        // GET: PageController/Create
        public ActionResult Create()
        {
            ViewData["Groups"] = _Pagegroup.GetPageGroups();
            return View();

        }

        [Route("/Admin/Page/Create")]
        // POST: PageController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Page page, IFormFile ImgUp)
        {
            if (!ModelState.IsValid)
                return View();


            if (ImgUp != null)
            {
                page.ImageName = Generator.CodeGenerator() + GetPath.ReturnPath(ImgUp.FileName);

                using (var fileStream = new FileStream(Path.Combine(Directory.GetCurrentDirectory() + "/PageImages/" + page.ImageName), FileMode.Create))
                {
                    ImgUp.CopyTo(fileStream);
                }
            }
            page.CreateDate = DateTime.Now.ToShamsi();
            page.Visit = 0;
            _Page.InsertPage(page);
            return RedirectToAction(nameof(Index));

        }

        [Route("/Admin/Page/Edit")]
        // GET: PageController/Edit/5
        public ActionResult Edit(int id)
        {
            ViewData["Groups"] = _Pagegroup.GetPageGroups();
            return View(_Page.GetPageById(id));
        }

        [Route("/Admin/Page/Edit")]
        // POST: PageController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Page page, IFormFile ImgUp)
        {
            if (ImgUp != null)
            {
                if (page.ImageName != null)
                {
                    System.IO.File.Delete(Directory.GetCurrentDirectory() + "/PageImages/" + page.ImageName);
                }

                page.ImageName = Generator.CodeGenerator() + GetPath.ReturnPath(ImgUp.FileName);
                using (var fileStream = new FileStream(Path.Combine(Directory.GetCurrentDirectory() + "/PageImages/" + page.ImageName), FileMode.Create))
                {
                    ImgUp.CopyTo(fileStream);
                }
            }

            _Page.UpdatePage(page);
            return RedirectToAction(nameof(Index));

        }

        [Route("/Admin/Page/Delete")]
        // GET: PageController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_Page.GetPageById(id));
        }

        [Route("/Admin/Page/Delete")]
        // POST: PageController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Page page)
        {
            _Page.DeletePage(page);
            return RedirectToAction(nameof(Index));

        }
    }
}
