using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dominio
{
    public class ListaItemProduto
    {
        [Key]
        public int codigoLista { get; set; }
        public string codMenuSeq { get; set; }
        public int codigoCardapio { get; set; }
        public string titulo { get; set; }
        public string descricao { get; set; }
        public int codProduto { get; set; }
        public string delete { get; set; }

    }

}
