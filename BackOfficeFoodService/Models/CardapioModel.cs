using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackOfficeFoodService.Models
{
    public class CardapioModel
    {
        public string idUser { get; set; }
        [Required(ErrorMessage = "Informe o nome título do cardápio.")]
        [StringLength(100, ErrorMessage = "O nome não deve exceder {1} caractere.")]
        [Display(Name = "Título do cardápio")]
        public string titulo { get; set; }
        public IEnumerable<CardapioModel> ListCardapio { get; set; }
        public IEnumerable<ListaModel> ListMenu { get; set; }

    }
}
