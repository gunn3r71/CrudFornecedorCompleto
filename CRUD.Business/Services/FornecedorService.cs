using System;
using System.Threading.Tasks;
using CRUD.Business.Interfaces;
using CRUD.Business.Models;
using CRUD.Business.Validations;

namespace CRUD.Business.Services
{
    public class FornecedorService : BaseService, IFornecedorService
    {
        private readonly IFornecedorRepository _fornecedorRepository;
        private readonly IEnderecoRepository _enderecoRepository;

        public FornecedorService(IFornecedorRepository fornecedorRepository, IEnderecoRepository enderecoRepository)
        {
            _fornecedorRepository = fornecedorRepository;
            _enderecoRepository = enderecoRepository;
        }

        public async Task Adicionar(Fornecedor fornecedor)
        {
            if (!ExecutarValidacao(new FornecedorValidation(), fornecedor)) return;

            return;
        }

        public async Task Atualizar(Fornecedor fornecedor)
        {
            throw new NotImplementedException();
        }

        public async Task Remover(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task AtualizarEndereco(Endereco endereco)
        {
            throw new NotImplementedException();
        }
    }
}