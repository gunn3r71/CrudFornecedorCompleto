using System;
using System.Threading.Tasks;
using CRUD.Business.Models;

namespace CRUD.Business.Interfaces
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        Task<Endereco> ObterEnderecoFornecedor(Guid fornecedorId);
    }
}