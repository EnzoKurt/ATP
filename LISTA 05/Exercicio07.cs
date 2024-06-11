using System;

public class Exercicio07 {
    public void Rodar() {
        int[,]matriz=new int[5,5];//cria o vetor 5 linhas e 5 colunas
    Preenche(matriz);//chama o procedimento
    Console.WriteLine();//pula uma linha
    //retorna as mensagens com o resultado de cada função
    Console.WriteLine("A soma de todos elementos da linha 4 é igual a: {0}",LinhaQuatro(matriz));
    Console.WriteLine("A soma de todos elementos da coluna 2 é igual a: {0}",ColunaDois(matriz));
    Console.WriteLine("A soma de todos elementos da diagonal principal é igual a: {0}",DiagPrin(matriz));
    Console.WriteLine("A soma de todos elementos da diagonal secundária é igual a: {0}",DiagSec(matriz));
    Console.WriteLine("A soma de todos elementos da matriz é igual a: {0}",Elementos(matriz));
  }
  static void Preenche(int [,]x){
    Random sorteio=new Random();//criação do sorteador
    for(int i=0;i<5;i++){
      for(int j=0;j<5;j++){
        x[i,j]=sorteio.Next(1,11);//sorteia um número pra cada linha e cada coluna
        Console.Write(x[i,j]+"\t");//escreve e tabula
      }
      Console.WriteLine();
    }    
  }
  static int LinhaQuatro(int[,]a){
    int soma=0;
    for(int i=3, j=0;j<5;j++){//i é posição da linha, então para calcularmos os elementos da linha 4 teremos que começar com o i valendo 3(já que posições começam pelo 0) e j começar por 0 e acrescentar até o limite do vetor
      soma+=a[i,j];//soma cada número da posição referida
    }
    return soma;
  }
  static int ColunaDois(int[,]a){
    int soma=0;
    for(int i=0,j=1;i<5;i++){//j é posição da coluna, então para calcularmos os elementos da coluna 2 teremos que começar com o j valendo 1(já que posições começam pelo 0) e i começar por 0 e acrescentar até o limite do vetor
      soma+=a[i,j];//soma cada número da posição referida
    }
    return soma;
  }
  static int DiagPrin(int[,]a){
    int soma=0;
    for(int i=0, j=0;i<5 && j<5;i++,j++){//i é posição da linha e j da coluna, quando a posição de ambos é a mesma até o limite do vetor(no caso 5), então teremos o elemento da diagonal principal
      soma+=a[i,j];//soma cada número da posição referida
    }
    return soma;
  }
  static int DiagSec(int[,]a){
    int soma=0;
    for(int i=0, j=4;i<5 && j>=0;i++,j--){//i é posição da linha e j da coluna, para termos o elemento da diagonal secundária, precisamos que a coluna (j)comece pela última e descremente até a primeira, enquanto a linha comece pela primeira e acrescente até a última
      soma+=a[i,j];//soma cada número da posição referida
    }
    return soma;
  }
  static int Elementos(int[,]a){
    int soma= 0;
    foreach(int item in a){//percorre a matriz e some todos os elementos
      soma+=item;
    }
    return soma;
  }
}
