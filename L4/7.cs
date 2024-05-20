using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite a quantidade de alunos:");
    int a=int.Parse(Console.ReadLine());//coleta do usuário
    notas(a);//chama a função
  }
  static void notas(int x){
    for(int i=0;i<x;i++){
      Console.WriteLine ("Digite a nota do aluno:");
      int a=int.Parse(Console.ReadLine());//coleta a nota do aluno
      if(a<=39){//se for menor ou igual a 39, entâo imprime na tela:
        Console.WriteLine("Conceito: F");
      }
      else if(a<=59){//se for maior que 39 e menor ou igual a 59, entâo imprime na tela
        Console.WriteLine("Conceito: E");
      }
      else if(a<=69){//se for maior que 59 e menor ou igual a 69, entâo imprime na tela
        Console.WriteLine("Conceito: D");
      }
      else if(a<=79){//se for maior que 69 menor ou igual a 79, entâo imprime na tela
        Console.WriteLine("Conceito: C");
      }
      else if(a<=89){//se for maior que 79 e menor ou igual a 89, entâo imprime na tela
        Console.WriteLine("Conceito: B");
      }
      else{//se for maior que 89, entâo imprime na tela
        Console.WriteLine("Conceito: A");
      }
      Console.ReadKey();
      Console.Clear();
    }
  }
}
