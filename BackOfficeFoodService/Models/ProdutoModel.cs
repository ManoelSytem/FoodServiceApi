using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackOfficeFoodService.Models
{
    public class ProdutoModel
    {
        public string nome { get; set; }
        public string descricao { get; set; }
        public Decimal valor { get; set; }
    }
}
