using AutoMapper;
using CRUD.Application.ViewModels;
using CRUD.Business.Models;

namespace CRUD.Application.Profiles
{
    public class FornecedorProfile : Profile
    {
        public FornecedorProfile()
        {
            CreateMap<Fornecedor, FornecedorViewModel>().ReverseMap();
        }
    }
}