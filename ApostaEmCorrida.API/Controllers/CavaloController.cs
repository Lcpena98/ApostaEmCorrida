using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApostaEmCorrida.Services;
using ApostaEmCorrida.Services.Interfaces;
using ApostaEmCorrida.Domain;

namespace ApostaEmCorrida.API.Controllers
{
    public class CavaloController : Controller
    {
        private readonly ICavaloService _cavaloService;

        public CavaloController(ICavaloService cavaloService)
        {
            _cavaloService = cavaloService;
        }

        public void CadastrarCavalo(string nome, double altura, double peso, int numero)
        {
            _cavaloService.CadastrarCavalo(nome, altura, peso, numero);
        }

        public int CadastrarNumero()
        {
            int numero = _cavaloService.CadastrarNumero();
            return _cavaloService.CadastrarNumero();
        }
        public void AtualizarDesempenho(List<Cavalo> cavalos, Cavalo primeiroLugar, Cavalo segundoLugar, Cavalo terceiroLugar)
        {
            _cavaloService.AtualizarDesempenho(cavalos, primeiroLugar, segundoLugar, terceiroLugar);
        }

        // GET: CavaloController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CavaloController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CavaloController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CavaloController/Create
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

        // GET: CavaloController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CavaloController/Edit/5
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

        // GET: CavaloController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CavaloController/Delete/5
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
