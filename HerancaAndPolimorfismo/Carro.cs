namespace Heranca
{
    public abstract class Carro
    {
        public int ano { get; private set; } = 2010;
        public string modelo { get; private set; }

        public Carro()
        {
            modelo = this.GetType().Name;
        }
        protected void AumentarUmAno()
        {
            ano++;
        }
    }
}
