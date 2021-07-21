using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.APP.ViewModels
{
    public class EnderecoViewModel
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "O campo {0} é requerido!")]
        [StringLength(100, ErrorMessage = "O campo {0} deve ter no minímo {2} e no máximo {1} caractéres!", MinimumLength = 2)]
        public string Logradouro { get; set; }
        [Required(ErrorMessage = "O campo {0} é requerido!")]
        [Range(minimum: 1, maximum: 100000, ErrorMessage = "O {0} deve estar entre {2} e {1}!")]
        public int Numero { get; set; }

        public string Complemento { get; set; }
        [Required(ErrorMessage = "O campo {0} é requerido!")]
        [StringLength(8, ErrorMessage = "O campo {0} deve ter {1} caractéres!", MinimumLength = 8)]
        public string Cep { get; set; }
        [Required(ErrorMessage = "O campo {0} é requerido!")]
        [StringLength(100, ErrorMessage = "O campo {0} deve ter no minímo {2} e no máximo {1} caractéres!", MinimumLength = 2)]
        public string Bairro { get; set; }
        [Required(ErrorMessage = "O campo {0} é requerido!")]
        [StringLength(100, ErrorMessage = "O campo {0} deve ter no minímo {2} e no máximo {1} caractéres!", MinimumLength = 2)]
        public string Cidade { get; set; }
        [Required(ErrorMessage = "O campo {0} é requerido!")]
        [StringLength(100, ErrorMessage = "O campo {0} deve ter no minímo {2} e no máximo {1} caractéres!", MinimumLength = 2)]
        public string Estado { get; set; }

        [HiddenInput]
        public Guid FornecedorId { get; set; }
    }
}