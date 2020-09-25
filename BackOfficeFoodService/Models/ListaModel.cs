using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackOfficeFoodService.Models
{
    public class ListaModel
    {
        public int codigoCardapio { get; set; }
        [Required(ErrorMessage = "Informe o titulo.")]
        [StringLength(100, ErrorMessage = "O nome não deve exceder {1} caractere.")]
        [Display(Name = "Titulo")]
        public string titulo { get; set; }
        public string descricao { get; set; }
        public string codProduto { get; set; }
        public List<int> ListCodProduto { get; set; }
    }
}
