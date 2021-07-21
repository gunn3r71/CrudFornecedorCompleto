using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CRUD.APP.ViewModels
{
    public class FornecedorViewModel
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "O campo {0} é requerido!")]
        [StringLength(100, ErrorMessage = "O campo {0} deve ter no minímo {2} e no máximo {1} caractéres!", MinimumLength = 2)]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo {0} é requerido!")]
        [StringLength(14, ErrorMessage = "O campo {0} deve ter no minímo {2} e no máximo {1} caractéres!", MinimumLength = 11)]
        public string Documento { get; set; }
        [Display(Name = "Tipo de fornecedor")]
        [Range(minimum: 1, maximum: 2)]
        public int TipoFornecedor { get; set; }
        public EnderecoViewModel Endereco { get; set; }
        [Display(Name = "Ativo?")]
        public bool Ativo { get; set; }

        public IEnumerable<ProdutoViewModel> Produtos { get; set; }
    }
}