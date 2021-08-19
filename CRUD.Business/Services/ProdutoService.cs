using System;
using System.Threading.Tasks;
using CRUD.Business.Interfaces;
using CRUD.Business.Models;

namespace CRUD.Business.Services
{
    public class ProdutoService : BaseService, IProdutoService
    {
        public async Task Adicionar(Produto produto)
        {
            throw new NotImplementedException();
        }

        public async Task Atualizar(Produto produto)
        {
            throw new NotImplementedException();
        }

        public async Task Remover(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}