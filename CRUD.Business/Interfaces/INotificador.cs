using System.Collections.Generic;
using CRUD.Business.Notifications;

namespace CRUD.Business.Interfaces
{
    public interface INotificador
    {
        bool TemNotificacoes();
        List<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);
    }
}