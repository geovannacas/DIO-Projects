programa
{
	
	funcao inicio()
	{
		inteiro contador,limite,resultado,tabuada
		contador=0
		limite=0
		tabuada=0 
		escreva("Insira a tabuada que você quer:")
		leia(tabuada)
          escreva("Insira o limite para o resultado:")
          leia(limite)
          
		faca{ 
			resultado= tabuada * contador
			escreva(tabuada + "x" + contador + "=" + resultado + "\n")
			contador ++
		}enquanto (resultado<=limite)
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 226; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */