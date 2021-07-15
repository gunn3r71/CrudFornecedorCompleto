using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using App.Models.Enums;

namespace App.Models
{
    public class Fornecedor : Entity
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public TipoFornecedor TipoFornecedor { get; set; }
        public Endereco Endereco { get; set; }
        public bool Ativo { get; set; }

        public IEnumerable<Produto> Produtos { get; set; }
    }
}