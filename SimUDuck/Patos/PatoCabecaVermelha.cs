using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck.Patos
{
    class PatoCabecaVermelha : IPato
    {
        public void Grasnar()
        {
            Console.WriteLine("Pato Cabeça Vermelha grasnando na tela.");
        }

        public void Nadar()
        {
            Console.WriteLine("Pato Cabeça Vermelha nadando na tela.");
        }

        public void Voar()
        {
            Console.WriteLine("Pato Cabeça Vermelha voando na tela.");
        }
    }
}
