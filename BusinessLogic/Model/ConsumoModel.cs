using System;
using System.Collections.Generic;
using System.Text;

namespace Aplication.Model
{
    public class ConsumoModel
    {
        public int codigo { get; set; }
        public string codMesa { get; set; }
        public string codProduto { get; set; }
        public DateTime horaPedido { get; set; }
    }
}
