using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Nota dos Alunos turma 1 - 2024");
    int a=0,soma=0,i=0;
      do{
        Console.WriteLine("Digite a nota do aluno:");
        a=int.Parse(Console.ReadLine());//coleta da nota pelo usuário
        if(a>=6){//se a nota for maior ou igual a 6, então soma no valor da variável "soma" e contabiliza na quantidade de alunos aprovados "i++"
          soma+=a;
          i++;
        }
        Console.Clear();//limpa o console
      }while(a>0);//enquanto a nota informada for maior que 0
    Console.WriteLine("A média das notas dos alunos aprovados foi: "+notas(soma,i));//imprime a média retornada pela função notas
  }
  static double notas(int x,int y){//pega por parâmetro x o valor da soma e y o valor de i
    double media=(double)x/y;//calcula a média das notas dos alunos aprovados
    return media;//retorna a média
  }
}
