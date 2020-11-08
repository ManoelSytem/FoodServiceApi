using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dominio
{
    public class Mesa
    {
         [Key]
         public int codigo { get; set; }
         public  int numero { get; set; }
         public string status { get; set; }
         public string seqAbreMesa { get; set; }
    }
}
