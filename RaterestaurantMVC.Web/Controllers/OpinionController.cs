using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RaterestaurantMVC.Web.Controllers
{
    public class OpinionController : Controller
    {
        // GET: Opinion
        public ActionResult Index()
        {
            return View();
        }

        // GET: Opinion/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Opinion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Opinion/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Opinion/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Opinion/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Opinion/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Opinion/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
