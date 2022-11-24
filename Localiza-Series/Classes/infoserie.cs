namespace Localiza.Series
{
    public class infoserie : id
    {
        private Genero Gênero {get; set; }
        private string Título { get; set; }
        private string Sinopse { get; set; }
        private int Ano { get; set; }
        private int Idade { get; set; }
        private string Tempo { get; set; }
        private string Elenco { get; set; }
        private bool Excluido { get; set; }
        public infoserie(int id, Genero Genero, string Titulo, string Sinopse, int Ano, int Idade, string Tempo, string Elenco)
         {
            this.Id = id;
            this.Gênero = Genero;
            this.Título = Titulo;
            this.Sinopse = Sinopse;
            this.Ano = Ano;
            this.Idade = Idade;
            this.Tempo = Tempo;
            this.Elenco = Elenco;
            this.Excluido = false;
         }
        public override string ToString()
		{
			// Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
            string retorno = "";
            retorno += "Gênero: " + this.Gênero + Environment.NewLine;
            retorno += "Série: " + this.Título + Environment.NewLine;
            retorno += "Sinopse: " + this.Sinopse + Environment.NewLine;
            retorno += "Ano: " + this.Ano + Environment.NewLine;
            retorno += "Idade Indicativa: " + this.Idade + Environment.NewLine;
            retorno += "Duração: " + this.Tempo + Environment.NewLine;
            retorno += "Elenco: " + this.Elenco + Environment.NewLine;
			return retorno;
		}
        public string retornaTitulo()
		{
			return this.Título;
		}

		public int retornaId()
		{
			return this.Id;
		}
         public bool retornaExcluido()
		{
			return this.Excluido;
		}
        public void Excluir() {
            this.Excluido = true;
        }
    }
}