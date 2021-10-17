using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CRUD.APP.ViewModels;
using Microsoft.AspNetCore.Http;

namespace CRUD.APP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Route("erro/{code:int:length(3,3)}")]
        public IActionResult Error(int code)
        {
            var modelError = new ErrorViewModel();
            modelError.ErrorCode = code;

            switch (code)
            {
                case StatusCodes.Status500InternalServerError:
                    modelError.Titulo = "Algo deu errado!";
                    modelError.Mensagem = "Ocorreu um erro! tente novamente mais tarde.";
                    break;
                case StatusCodes.Status404NotFound:
                    modelError.Titulo = "Ops, página não encontrada!";
                    modelError.Mensagem = "A página que você está procurando não existe.";
                    break;
                case StatusCodes.Status403Forbidden:
                    modelError.Titulo = "Acesso negado!";
                    modelError.Mensagem = "^Você não tem acesso à essa página.";
                    break;
                default:
                    break;
            }

            return View(modelError);
        }
    }
}
