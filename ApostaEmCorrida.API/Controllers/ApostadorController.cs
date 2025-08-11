using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApostaEmCorrida.API.Controllers
{
    public class ApostadorController : Controller
    {
        // GET: ApostadorController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ApostadorController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ApostadorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ApostadorController/Create
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

        // GET: ApostadorController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ApostadorController/Edit/5
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

        // GET: ApostadorController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ApostadorController/Delete/5
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
