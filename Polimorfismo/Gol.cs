namespace Polimorfismo
{
    public class Gol : Carro
    {
        public override void AumentarAno(int quantidadeAnos)
        {
            base.AumentarAno(quantidadeAnos);
            ano += quantidadeAnos;
        }
    }
}
