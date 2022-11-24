programa
{
	
	funcao inicio()
	{
		escreva("Escolha uma das opções: 1- Minecraft 2- League of Legends 3- The Sims 4")
		inteiro menu=0
		escreva ("\n" + "Sua escolha é:")
		leia(menu)

		escolha(menu)
		{ 
          caso 1:
          escreva ("Você escolheu Minecraft")
          pare
          caso 2:
          escreva ("Você escolheu LoL")
          pare
          caso 3:
          escreva ("Você escolheu The Sims 4")
          pare
          caso contrario:
          escreva ("Boa escolha :)")
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 346; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */