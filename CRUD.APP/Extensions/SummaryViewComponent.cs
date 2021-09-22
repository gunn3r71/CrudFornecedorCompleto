using System.Threading.Tasks;
using CRUD.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.APP.Extensions
{
    public class SummaryViewComponent : ViewComponent
    {
        public SummaryViewComponent(INotificador notificador)
        {
            _notificador = notificador;
        }

        private readonly INotificador _notificador;
        
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var notificacoes = await Task.FromResult(_notificador.ObterNotificacoes());

            notificacoes.ForEach(x => ViewData.ModelState.AddModelError(string.Empty, x.Mensagem));

            return View();
        }
    }
}