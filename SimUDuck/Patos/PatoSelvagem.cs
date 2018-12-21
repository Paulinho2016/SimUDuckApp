using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck.Patos
{
    class PatoSelvagem : IPato
    {
        public void Grasnar()
        {
            Console.WriteLine("Pato Selvagem grasnando na tela.");
        }

        public void Nadar()
        {
            Console.WriteLine("Pato Selvagem nadando na tela.");
        }

        public void Voar()
        {
            Console.WriteLine("Pato Selvagem voando na tela.");
        }
    }
}
