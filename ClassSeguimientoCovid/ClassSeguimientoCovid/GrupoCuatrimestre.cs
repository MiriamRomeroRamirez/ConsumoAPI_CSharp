using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSeguimientoCovid
{
    public class GrupoCuatrimestre
    {
        public int Id_GruCuat { get; set; }
        public int F_ProgEd { get; set; }
        public short F_Grupo { get; set; }
        public short F_Cuatri { get; set; }
        public string Turno { get; set; }
        public string Modalidad { get; set; }
        public string Extra { get; set; }
    }
}
