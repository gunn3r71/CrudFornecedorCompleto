using CRUD.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.APP.Controllers
{
    public class BaseController : Controller
    {
        public BaseController(INotificador notificador)
        {
            _notificador = notificador;
        }

        private readonly INotificador _notificador;

        protected bool OperacaoValida()
        {
            return !_notificador.TemNotificacoes();
        }
    }
}