using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    public class GolRallye : Carro
    {
        public void AumentarAno(int multiploDe, int valorBase)
        {
            ano += (multiploDe * valorBase);
        }

        public void AumentarAno()
        {
            ano += 10;
        }
        public override void AumentarAno(int quantidadeAnos)
        {
            ano += quantidadeAnos;
        }
    }
}
