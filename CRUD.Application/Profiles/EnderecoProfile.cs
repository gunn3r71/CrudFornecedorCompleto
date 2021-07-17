using AutoMapper;
using CRUD.Application.ViewModels;
using CRUD.Business.Models;

namespace CRUD.Application.Profiles
{
    public class EnderecoProfile : Profile
    {
        public EnderecoProfile()
        {
            CreateMap<Endereco, EnderecoViewModel>().ReverseMap();
        }
    }
}