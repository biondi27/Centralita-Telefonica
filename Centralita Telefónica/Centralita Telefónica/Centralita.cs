using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita_Telefónica
{
    public class Centralita : Llamada
    {
        public int Total_de_Llamadas { get; set; }
        public virtual int CostoTotal()
        {
            Random random = new Random();
            int tax = random.Next(1, 5);
            switch (random.Next(1, 5))
            {
                case 1:
                    tax = 10;
                    break;
                case 2:
                    tax = 20;
                    break;
                case 3:
                    tax = 25;
                    break;
                case 4:
                    tax = 30;
                    break;
            }
            return Total_de_Llamadas * tax;
        }
    }
    public class Franja1 : Centralita
    {
        public override int Costo() => Duración * 20;
    }
    public class Franja2 : Centralita
    {
        public override int Costo() => Duración * 25;
    }
    public class Franja3 : Centralita
    {
        public override int Costo() => Duración * 30;
    }
}
