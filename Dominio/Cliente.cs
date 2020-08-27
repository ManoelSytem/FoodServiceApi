using System;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Cliente
    {
        [Key]
        public int IdUser { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public string endereco { get; set; }
        public string contato { get; set; }
        public string email { get; set; }
        public byte status { get; set; }
        public DateTime dataEntrada { get; set; }
        public DateTime dataUpdate { get; set; }
        public string logo { get; set; }

    }

}
