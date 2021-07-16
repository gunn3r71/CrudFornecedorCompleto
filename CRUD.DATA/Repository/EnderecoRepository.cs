using System;
using System.Threading.Tasks;
using CRUD.Business.Interfaces;
using CRUD.Business.Models;
using CRUD.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<Endereco> ObterEnderecoFornecedor(Guid fornecedorId)
        {
            return await _context.Enderecos.AsNoTracking().FirstOrDefaultAsync(e => e.FornecedorId == fornecedorId);
        }
    }
}