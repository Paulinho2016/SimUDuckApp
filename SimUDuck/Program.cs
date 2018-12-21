using SimUDuck.Patos;
using System;

namespace SimUDuck
{
    class Program
    {
        static void Main(string[] args)
        {

            Simulador simulador = new Simulador();
            FabricaPatos fabrica = new FabricaPatos();

            fabrica.ObterPatos().ForEach((pato) => { simulador.Excutar(pato); });


            Console.ReadKey();
        }
    }
}
