using System;

public class Exercicio08 {
    int[,] matriz = new int[4, 4];//criação do vetor de 4 linhas e 4 colunas
  
  public void Rodar () {
    Preenche();//chama o procedimento
    Imprime();//imprime a matriz
    SomaAbaixoDiagonalPrincipal();//procedimento que resolve a questão
  }
  
  public void Preenche() {
    Random sort = new Random();//cria o sorteador
    
    for(int i = 0; i < 4; i++) 
      for(int j = 0; j < 4; j++) 
        matriz[i, j] = sort.Next(0,10);//cada posição da matriz vai pegar um número sorteado de 0 a 9
  }
  
  public void Imprime() {
    for(int i = 0; i < 4; i++) {
      for(int j = 0; j < 4; j++) 
        Console.Write (matriz[i, j] + "   ");
      Console.WriteLine();
    }
  }

  public void SomaAbaixoDiagonalPrincipal(){
    int soma = 0;
    
    for(int i = 0; i < 4; i++) //a linha não pode passar de 4
      for(int j = 0; j < i; j++) //a coluna tem necessariamente que ser menor que a coluna, então o for só vai começar a pegar os números para somar quando o i for 1
        soma += matriz[i, j];
    Console.WriteLine("Soma dos elementos abaixo da diagonal principal: " + soma);//imprime o resultado para o usuário
  }
}
