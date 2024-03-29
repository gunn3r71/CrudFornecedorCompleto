﻿using System;
using System.Threading.Tasks;
using CRUD.Business.Models;

namespace CRUD.Business.Interfaces
{
    public interface IProdutoService : IDisposable
    {
        Task Adicionar(Produto produto);
        Task Atualizar(Produto produto);
        Task Remover(Guid id);
    }
}