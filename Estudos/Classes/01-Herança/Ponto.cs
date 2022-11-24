namespace Classes.Herança
{
    public class Ponto
    {
        public int x, y;
        private int distancia;
        
        public Ponto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        // DIFICULDADE COM THIS: VARIAVEIS INTERNAS SENDO MENCIONADAS NO LOCAL, MAIS USADO EM PRIVATE.
        protected void CalcularDistancia()
        {
            //Faz alguma coisa...
            CalcularDistancia2();
        }

        private void CalcularDistancia2()
        {
            //Faz alguma coisa...
        }

        public virtual void CalcularDistancia3()
        {
            //Faz alguma coisa...
            // O QUE VIRTUAL FAZ?? = PERMITE UMA CLASSE FILHA (Ponto3D) SOBREESCREVER.
        }
    }
}