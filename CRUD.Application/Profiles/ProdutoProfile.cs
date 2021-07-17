using AutoMapper;
using CRUD.Application.ViewModels;
using CRUD.Business.Models;

namespace CRUD.Application.Profiles
{
    public class ProdutoProfile : Profile
    {
        public ProdutoProfile()
        { 
            CreateMap<Produto, ProdutoViewModel>().ReverseMap();
        }

    }
}