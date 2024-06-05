using System;

class Program Exercicio02{
  public static void Rodar() {
    Console.WriteLine ("Notas alunos 2024");
    int a=10;//tamanho do vetor
    preencher(a);
  }
  static void preencher (int a){
    int[] v= new int[a];//criação do vetor
      for(int i=0;i<v.Length;i++){
        Console.WriteLine("Digite um número (positivo ou negativo):");//coleta o número do usuário
        v[i]=int.Parse(Console.ReadLine());//cada posição do vetor toma a nota digitada pelo usuário
      }
    Console.WriteLine("Os números negativos são:");
    foreach(int item in vetor(v)){
      Console.Write(item + " ");
    }
      //aciona a função
  }
  static int[] vetor(int[] x){
    int a=0, contador=0;
    foreach(int item in x){//"item" percorre o vetor
      if(item<0){
        a++;//a é o contador de números negativos no vetor x
      }
    }
    int[] neg=new int[a];//vetor de negativos será do tamanho do valor de a
    for(int i=0;i<neg.Length;i++){
      if(x[i]<0){
        neg[contador++]=x[i];//cada vez que o programa acha um número negativo dentro do vetor x, ele introduz em uma posição do vetor de negativos
      }
    }
    return neg;//retorna o vetor de negativos
  }
}
