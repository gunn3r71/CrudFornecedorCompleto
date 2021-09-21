using System;
using System.Threading.Tasks;
using CRUD.Business.Models;

namespace CRUD.Business.Interfaces
{
    public interface IFornecedorService : IDisposable
    {
        Task Adicionar(Fornecedor fornecedor);
        Task Atualizar(Fornecedor fornecedor);
        Task Remover(Guid id);

        Task AtualizarEndereco(Endereco endereco);
    }
}