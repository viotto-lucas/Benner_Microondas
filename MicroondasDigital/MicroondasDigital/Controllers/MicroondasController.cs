using Microsoft.AspNetCore.Mvc;

namespace MicroondasDigital.Controllers
{
    public class MicroondasController : Controller
    {
        private static bool emAquecimento = false;
        private static int tempoRestante = 0;
        private static int potenciaAtual = 10;

        public IActionResult Index()
        {
            ViewBag.TempoRestante = tempoRestante > 0 ? $"{tempoRestante} segundos restantes" : "Nenhum aquecimento em andamento";
            return View("/Views/Home/Index.cshtml");
        }

        [HttpPost]
        public IActionResult Aquecer(int tempo, int potencia = 10)
        {
            if (!emAquecimento)
            {
                emAquecimento = true;
                tempoRestante = tempo;
                potenciaAtual = potencia;
                ViewBag.Resultado = "Aquecimento iniciado.";
            }
            else
            {
                // Acréscimo de 30 segundos ao tempo restante
                tempoRestante += 30;
                ViewBag.Resultado = $"Aquecimento já em andamento. 30 segundos adicionados. Tempo restante: {tempoRestante} segundos.";
            }

            ViewBag.TempoRestante = $"{tempoRestante} segundos restantes";
            return View("/Views/Home/Index.cshtml");
        }

        public IActionResult InicioRapido()
        {
            if (!emAquecimento)
            {
                emAquecimento = true;
                tempoRestante = 30; // Início rápido com 30 segundos
                potenciaAtual = 10; // Potência padrão
                ViewBag.Resultado = "Aquecimento iniciado com Início Rápido.";
            }
            else
            {
                // Acréscimo de 30 segundos se já estiver em aquecimento
                tempoRestante += 30;
                ViewBag.Resultado = $"Aquecimento já em andamento. 30 segundos adicionados. Tempo restante: {tempoRestante} segundos.";
            }

            ViewBag.TempoRestante = $"{tempoRestante} segundos restantes";
            return View("/Views/Home/Index.cshtml");
        }

        [HttpPost]
        public IActionResult PausarOuCancelar()
        {
            if (emAquecimento)
            {
                emAquecimento = false;
                tempoRestante = 0;
                ViewBag.Resultado = "Aquecimento cancelado.";
            }
            else
            {
                ViewBag.Resultado = "Nenhum aquecimento em andamento.";
            }

            ViewBag.TempoRestante = tempoRestante > 0 ? $"{tempoRestante} segundos restantes" : "Nenhum aquecimento em andamento";
            return View("/Views/Home/Index.cshtml");
        }
    }
}
