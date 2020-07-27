namespace Polimorfismo
{
    public abstract class Carro
    {
        public Carro()
        {
            modelo = this.GetType().Name;
        }
        public int ano { get; set; } = 2010;
        public string modelo { get; private set; }
        public virtual void AumentarAno(int quantidadeAnos) { ano = 2012; }
    }
}
