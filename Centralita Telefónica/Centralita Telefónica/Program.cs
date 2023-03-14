namespace Centralita_Telefónica
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> opciones = new List<string>();
            opciones.Add("1: Llamada Local");
            opciones.Add("2: Llamada al Exterior");
            opciones.Add("3: Imprimir Informe");

            Console.WriteLine("Elige el número de la opción que desea ejecutar: ");
            Console.WriteLine('\n');
            foreach (string opcion in opciones)
            {
                Console.WriteLine(opcion);
            }
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine('\n');

            if (key.KeyChar.ToString() == "1")
            {
                Llamada llamada = new Llamada();
                Console.WriteLine("Escriba de dónde está haciendo la llamada: ");
                llamada.Fuente = Console.ReadLine();
                Console.WriteLine("Escriba hacia donde está llamando: ");
                llamada.Destino = Console.ReadLine();
                Console.WriteLine("Escriba la duración estimada en segundos: ");
                llamada.Duración = Convert.ToInt32(Console.ReadLine());
                int Costollamada = llamada.Costo();
                Console.WriteLine("Entendido. El costo de su llamada será: " + Costollamada + " centavos.");
            }

            if (key.KeyChar.ToString() == "2")
            {
                Centralita llamadaext = new Centralita();
                Console.WriteLine("Escriba hacia donde está llamando (Franja 1, Franja 2 o Franja 3): ");
                llamadaext.Destino = Console.ReadLine();

                if (llamadaext.Destino == "Franja 1")
                {
                    Franja1 call = new Franja1();
                    call.Destino = llamadaext.Destino;
                    Console.WriteLine("Escriba de dónde está haciendo la llamada (Franja 1, Franja 2 o Franja 3): ");
                    call.Fuente = Console.ReadLine();
                    Console.WriteLine("Escriba la duración estimada en segundos: ");
                    call.Duración = Convert.ToInt32(Console.ReadLine());
                    int Costollamada = call.Costo();
                    Console.WriteLine("Esta llamada costará " + Costollamada + " centavos.");
                }

                if (llamadaext.Destino == "Franja 2")
                {
                    Franja2 call = new Franja2();
                    call.Destino = llamadaext.Destino;
                    Console.WriteLine("Escriba de dónde está haciendo la llamada (Franja 1, Franja 2 o Franja 3): ");
                    call.Fuente = Console.ReadLine();
                    Console.WriteLine("Escriba la duración estimada en segundos: ");
                    call.Duración = Convert.ToInt32(Console.ReadLine());
                    int Costollamada = call.Costo();
                    Console.WriteLine("Esta llamada costará " + Costollamada + " centavos.");
                }

                if (llamadaext.Destino == "Franja 3")
                {
                    Franja3 call = new Franja3();
                    call.Destino = llamadaext.Destino;
                    Console.WriteLine("Escriba de dónde está haciendo la llamada (Franja 1, Franja 2 o Franja 3): ");
                    call.Fuente = Console.ReadLine();
                    Console.WriteLine("Escriba la duración estimada en segundos: ");
                    call.Duración = Convert.ToInt32(Console.ReadLine());
                    int Costollamada = call.Costo();
                    Console.WriteLine("Esta llamada costará " + Costollamada + " centavos.");
                }
            }

            if (key.KeyChar.ToString() == "3")
            {
                Centralita centralita = new Centralita();
                Random random = new Random();
                centralita.Total_de_Llamadas = random.Next(1, 11);
                int Costo_de_Llamadas = centralita.CostoTotal();
                Console.WriteLine("Se han realizado " + centralita.Total_de_Llamadas + " llamadas por esta central.");
                Console.WriteLine("Se han recaudado " + Costo_de_Llamadas + " centavos por esas llamadas.");
            }
        }
    }
}