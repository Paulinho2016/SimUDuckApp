using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck.Patos
{
    class Pato : IPato
    {
        private string nome;
        public string Nome { get => this.nome; set => this.nome = value; }

        public void Grasnar()
        {
            Console.WriteLine("Pato grasnando na tela.");
        }

        public void Voar()
        {
            Console.WriteLine("pato voando na tela.");
        }

        public void Nadar()
        {
            Console.WriteLine("pato nadando na tela.");
        }
    }
}
