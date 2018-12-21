using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck.Patos
{
    class FabricaPatos
    {
        public List<IPato> ObterPatos()
        {
            List<IPato> patos = new List<IPato>();
            patos.Add(new Pato());
            patos.Add(new PatoSelvagem());
            patos.Add(new PatoCabecaVermelha());

            return patos;
        }
    }
}
