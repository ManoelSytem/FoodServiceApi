using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dominio
{
    public class Conta
    {
        [Key]
        public int codigo { get; set; }
        public string codMesa { get; set; }
        public decimal total { get; set; }
        public string formaPagamento { get; set; }
        public DateTime dataAbertura { get; set; }
        public DateTime dataFechamento { get; set; }
       
    }
}
