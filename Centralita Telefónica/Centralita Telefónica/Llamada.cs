using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita_Telefónica
{
    public class Llamada
    {
        public string Fuente { get ; set; }
        public string Destino { get; set; }
        public virtual int Duración { get; set; }
        public virtual int Costo()
        {
            return Duración * 15;
        }
    }
}