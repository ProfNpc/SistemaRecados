using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaRecados.Models
{
    public class Recado
    {
        public long? RecadoID { get; set; }
        public string Mensagem { get; set; }
        public string Autor { get; set; }
        public DateTime Horario { get; set; }
    }
}
