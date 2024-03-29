﻿using CRUD.Business.Interfaces;
using CRUD.Business.Models;
using CRUD.Business.Notifications;
using FluentValidation;
using FluentValidation.Results;

namespace CRUD.Business.Services
{
    public abstract class BaseService
    {
        protected BaseService(INotificador notificador)
        {
            _notificador = notificador;
        }

        private readonly INotificador _notificador;

        protected void Notify(ValidationResult validationResult) 
        {
            foreach (var error in validationResult.Errors)
            {
                Notify(error.ErrorMessage);
            }
        }

        protected void Notify(string message)
        {
            _notificador.Handle(new Notificacao(message));
        }

        protected bool ExecutarValidacao<TV,TE>(TV validacao, TE entidade) where TV : AbstractValidator<TE> where TE : Entity
        {
            var validator = validacao.Validate(entidade);

            if (validator.IsValid) return true;

            Notify(validator);

            return false;
        }
    }
}