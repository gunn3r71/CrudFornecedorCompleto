﻿using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using CRUD.Business.Interfaces;

namespace CRUD.Business.Notifications
{
    public class Notificador : INotificador
    {
        public Notificador()
        {
            _notificacoes = new List<Notificacao>();
        }

        private List<Notificacao> _notificacoes;

        public bool TemNotificacoes()
        {
            return _notificacoes.Any();
        }

        public List<Notificacao> ObterNotificacoes()
        {
            return _notificacoes;
        }

        public void Handle(Notificacao notificacao)
        {
            _notificacoes.Add(notificacao);
        }
    }
}