using Core;
using Core.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cms.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PageController : Controller
    {
        
        private readonly IPageRepository _Page;
        public PageController(IPageRepository Page)
        {
            _Page = Page;
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
            return View();
        }

        [Route("/Admin/Page/Create")]
        // POST: PageController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Page page)
        {
            _Page.InsertPage(page);
            return RedirectToAction(nameof(Index));

        }

        [Route("/Admin/Page/Edit")]
        // GET: PageController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_Page.GetPageById(id));
        }

        [Route("/Admin/Page/Edit")]
        // POST: PageController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Page page)
        {
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
