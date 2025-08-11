using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApostaEmCorrida.API.Controllers
{
    public class CasaController : Controller
    {
        // GET: CasaController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CasaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CasaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CasaController/Create
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

        // GET: CasaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CasaController/Edit/5
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

        // GET: CasaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CasaController/Delete/5
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
