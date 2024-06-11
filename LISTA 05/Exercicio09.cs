using System;

public class Exercicio09 {
    public void Rodar() {
        int[,]a=new int[4,6];//criação das matrizes A e B somente com as quantidade de linhas e colunas 
    int[,]b=new int[4,6];
    Preenche(a,b);//aciona o procedimento
    Console.WriteLine ("A soma dos elementos das duas matrizes se dá na matriz a seguir:");
    int[,] soma=SomaMatrizes(a,b);//imprime a matriz resultante da função SomaMatrizes
    Console.WriteLine ("A diferença dos elementos das duas matrizes se dá na matriz a seguir:");
    int[,] diferenca=SubtraiMatrizes(a,b);//imprime a matriz resultante da função SubtraiMatrizes
  }
  static void Preenche(int[,]a,int[,]b){
    Random sorte=new Random();//as matrizes terão números sorteados de 1 a 9
    Console.WriteLine("Matriz A:");
    for(int i=0;i<4;i++){
      for(int j=0;j<6;j++){
        a[i,j]=sorte.Next(1,10);
        Console.Write(a[i,j]+"\t");
      }
      Console.WriteLine();
    }
    Console.WriteLine("Matriz B:");
    for(int i=0;i<4;i++){
      for(int j=0;j<6;j++){
        b[i,j]=sorte.Next(1,10);
        Console.Write(b[i,j]+"\t");
      }
      Console.WriteLine();
    }
  }
  static int[,] SomaMatrizes(int[,]a,int[,]b){
    int[,] S=new int[4,6];
    for(int i=0;i<4;i++){
      for(int j=0;j<6;j++){
        S[i,j]=a[i,j]+b[i,j];//soma cada número de cada posição das duas matrizes
        Console.Write(S[i,j]+"\t");
      }
      Console.WriteLine();
    }
    return S;
  }
  static int[,] SubtraiMatrizes(int[,]a,int[,]b){
    int[,] D=new int[4,6];
    for(int i=0;i<4;i++){
      for(int j=0;j<6;j++){
        D[i,j]=a[i,j]-b[i,j];//subtrai cada número de cada posição das duas matrizes
        Console.Write(D[i,j]+"\t");
      }
      Console.WriteLine();
    }
    return D;
  }
}
