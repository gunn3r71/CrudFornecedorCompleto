﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CRUD.APP.Extensions;
using Microsoft.AspNetCore.Http;

namespace CRUD.APP.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "O campo {0} é requerido!")]
        [StringLength(100, ErrorMessage = "O campo {0} deve ter no minímo {2} e no máximo {1} caractéres!", MinimumLength = 4)]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo {0} é requerido!")]
        [Display(Name = "Descrição")]
        [StringLength(100, ErrorMessage = "O campo {0} deve ter no minímo {2} e no máximo {1} caractéres!", MinimumLength = 4)]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo {0} é requerido!")]
        [Display(Name = "Fornecedor")]
        public Guid FornecedorId { get; set; }

        [Display(Name = "Imagem")]
        public IFormFile ImagemUpload { get; set; }
        public string Imagem { get; set; }

        [Moeda]
        [Required(ErrorMessage = "O campo {0} é requerido!")]
        public decimal Valor { get; set; }
        [Display(Name = "Ativo?")]
        [Required(ErrorMessage = "O campo {0} é requerido!")]
        public bool Ativo { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        public FornecedorViewModel Fornecedor { get; set; }

        public IEnumerable<FornecedorViewModel> Fornecedores { get; set; }
    }
}