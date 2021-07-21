using AutoMapper;
using CRUD.APP.ViewModels;
using CRUD.Business.Models;

namespace CRUD.App.MapperConfiguration
{
    public class EntityMapper : Profile
    {
        public EntityMapper()
        {
            CreateMap<ProdutoViewModel, Produto>().ReverseMap();
            CreateMap<FornecedorViewModel, Fornecedor>().ReverseMap();
            CreateMap<EnderecoViewModel, Endereco>().ReverseMap();
        }
    }
}