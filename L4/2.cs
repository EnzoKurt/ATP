using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Pesquisa de informações - Prefeitura de BH \nInforme os dados a seguir");//Mensagem de entrada
    coleta();//chama o procedimento
  }
  static void coleta(){
    int soma=0;
    for(int i=0;i<10;i++){//limitei as repetições em 10 vezes
      Console.WriteLine ("Digite o valor do salário:");
      int s=int.Parse(Console.ReadLine());//coleta salário
      Console.WriteLine ("Digite o número de filhos:");
      int f=int.Parse(Console.ReadLine());//coleta nº de filhos
      soma+=s;//soma todos os salários digitados
      Console.Clear();//limpa o console para melhor visualização
    }
    double media=(double)soma/10;//divide a soma dos salários pelo número de salarios digitados, achando a média
    Console.WriteLine("A média salarial dos cidadãos consultados foi de R${0:F2})", media);//imprime a média salarial
  }
}
