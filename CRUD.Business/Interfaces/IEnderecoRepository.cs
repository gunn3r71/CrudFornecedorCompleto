using CRUD.Business.Models;
using System;
using System.Threading.Tasks;

namespace CRUD.Business.Interfaces
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        Task<Endereco> ObterEnderecoFornecedor(Guid fornecedorId);
    }
}