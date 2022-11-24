namespace Classes.Herança
{
    public class Ponto3D : Ponto
    {
        // Ponto3D herda da classe Ponto (SÓ POSSO HERDAR DE UMA ÚNICA CLASSE)
        public int z;
        public Ponto3D(int x, int y, int z) : base(x, y)
        {
            this.z = z;
            CalcularDistancia();
        }

        public static void Calcular()
        {
            //Faz alguma coisa...
        }
        public override void CalcularDistancia3()
        {
            //Faz outra coisa ...
            base.CalcularDistancia3();
            //OVERRIDE: SOBREESCREVA O Ponto (Possibilitado pelo virtual)
            //BASE: HERANÇA DE int DO PONTO.
        }
    }
}