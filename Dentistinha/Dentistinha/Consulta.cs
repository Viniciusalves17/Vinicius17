using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentistinha
{
    class Consulta
    {
        public int ID_Consulta { get; set; }
        public int ID_Dentista { get; set; }
        public int ID_Paciente { get; set; }
        public String Motivo { get; set; }
        public String Diagnostico { get; set; }
        public String Receita { get; set; }
        public String Retorno { get; set; }
        public DateTime DTConsulta { get; set; }
        public DateTime DTRetorno { get; set; }
      
    }
}
