using System;
using Localiza.Series;

class Program
    {
        static repositorioserie repositorio = new repositorioserie();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

			while (opcaoUsuario.ToUpper() != "X")
			{
				switch (opcaoUsuario)
				{
					case "1":
						ListarSeries();
						break;
					case "2":
						AdicionarSerie();
						break;
					case "3":
						AtualizarSerie();
						break;
					case "4":
						ExcluirSerie();
						break;
					case "5":
						VisualizarSerie();
						break;
					case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuario = ObterOpcaoUsuario();
			}

			Console.WriteLine("Agradecemos pelo interesse");
			Console.WriteLine("Volte sempre!");
			Console.ReadLine();
        }
        private static void ExcluirSerie()
		{
			Console.Write("Digite o ID da série: ");
			int indiceSerie = int.Parse(Console.ReadLine());

			repositorio.Exclui(indiceSerie);
		}
        private static void VisualizarSerie()
		{
			Console.Write("Digite o ID da série: ");
			int indiceSerie = int.Parse(Console.ReadLine());

			var serie = repositorio.Id_Info(indiceSerie);

			Console.WriteLine(serie);
		}

        private static void AtualizarSerie()
		{
			Console.Write("Digite o ID da série: ");
			int indiceSerie = int.Parse(Console.ReadLine());

			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("Digite algum Gênero acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título da Série: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o Ano de Início da Série: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite a Sinopse da Série: ");
			string entradaSinopse = Console.ReadLine();

            Console.Write("Digite a Idade Indicativa da Série: ");
			int entradaIdade = int.Parse(Console.ReadLine());

            Console.Write("Digite a Duração da Série (Temporadas e/ou Episódios): ");
			string entradaTempo = Console.ReadLine();

            Console.Write("Digite o Elenco da Série: ");
			string entradaElenco = Console.ReadLine();


			infoserie atualizaSerie = new infoserie(id: indiceSerie,
										Genero: (Genero)entradaGenero,
										Titulo: entradaTitulo,
										Ano: entradaAno,
										Sinopse: entradaSinopse,
                                        Idade: entradaIdade,
                                        Tempo: entradaTempo,
                                        Elenco: entradaElenco);

			repositorio.Atualiza(indiceSerie, atualizaSerie);
		}
        private static void ListarSeries()
		{
			Console.WriteLine("Todas as séries:");

			var lista = repositorio.Lista();

			if (lista.Count == 0)
			{
				Console.WriteLine("Nenhuma série cadastrada.");
				return;
			}

			foreach (var serie in lista)
			{
				var excluido = serie.retornaExcluido();
                
				Console.WriteLine("[ID] {0}: {1} {2}", serie.retornaId(), serie.retornaTitulo(), (excluido ? "//**Excluído**//" : ""));
			}
		}

        private static void AdicionarSerie()
		{
			Console.WriteLine("Adicionar nova série");
			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("Digite o Gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título da Série: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o Ano de Início da Série: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite a Sinopse da Série: ");
			string entradaSinopse = Console.ReadLine();

            Console.Write("Digite a Idade Indicativa da Série: ");
			int entradaIdade = int.Parse(Console.ReadLine());

            Console.Write("Digite a Duração da Série: ");
			string entradaTempo = Console.ReadLine();

            Console.Write("Digite o Elenco da Série: ");
			string entradaElenco = Console.ReadLine();

			infoserie novaSerie = new infoserie(id: repositorio.ProximoId(),
										Genero: (Genero)entradaGenero,
										Titulo: entradaTitulo,
										Ano: entradaAno,
										Sinopse: entradaSinopse,
                                        Idade: entradaIdade,
                                        Tempo: entradaTempo,
                                        Elenco: entradaElenco);

			repositorio.Adiciona(novaSerie);
		}

        private static string ObterOpcaoUsuario()
		{
			Console.WriteLine();
			Console.WriteLine("-------* Localiza Séries *-------");
			Console.WriteLine("Digite o número de sua escolha:");

			Console.WriteLine("[1] Listar todas as séries");
			Console.WriteLine();
			Console.WriteLine("[2] Adicionar uma nova série");
			Console.WriteLine();
			Console.WriteLine("[3] Modificar série");
			Console.WriteLine();
			Console.WriteLine("[4] Excluir série");
            Console.WriteLine();
			Console.WriteLine("[5] Observações da série");
			Console.WriteLine();
			Console.WriteLine("[C] Limpar Tela");
			Console.WriteLine();
			Console.WriteLine("[X] Sair");
			Console.WriteLine("*---------------------------------*");
			Console.WriteLine();

			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuario;
		}
    }
