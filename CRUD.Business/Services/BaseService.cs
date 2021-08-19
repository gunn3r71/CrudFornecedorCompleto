using CRUD.Business.Models;
using FluentValidation;
using FluentValidation.Results;

namespace CRUD.Business.Services
{
    public abstract class BaseService
    {
        protected void Notify(ValidationResult validationResult) 
        {
            foreach (var error in validationResult.Errors)
            {
                Notify(error.ErrorMessage);
            }
        }

        protected void Notify(string message)
        {
            //Propagar erro até a camada de apresentação
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