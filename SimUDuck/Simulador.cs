using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck.Patos
{
    class Simulador
    {
        public void Excutar(IPato pato)
        {
            pato.Grasnar();
            pato.Nadar();
            pato.Voar();
        }
    }
}
