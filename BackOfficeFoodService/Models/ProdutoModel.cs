using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackOfficeFoodService.Models
{
    public class ProdutoModel
    {

        [Required(ErrorMessage = "Informe o nome do produto.")]
        [StringLength(100, ErrorMessage = "O nome não deve exceder {1} caractere.")]
        [Display(Name = "Nome do produto")]
        public string nome { get; set; }
        public string descricao { get; set; }
        public Decimal valor { get; set; }
    }
}
