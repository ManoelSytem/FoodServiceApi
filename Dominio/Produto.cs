using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dominio
{
    public class Produto
    { 
        [Key]
        public int codigo { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public float valor { get; set; }

    }
}
