using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite quantos alunos deseja consultar:");
    int n=int.Parse(Console.ReadLine());//Coleta a quantidade de repetições que o usuário deseja
    notas(n);//chama o procedimento
    Console.WriteLine("Fim");//imprime a mensagem na tela após o término do programa
  }
  static void notas(int x){
    int soma=0;//soma para usar no cálculo dda média aritmética
    for(int i=0;i<x;i++){//repete até a quantidade que o usuário escolheu
      Console.Clear();//limpa o console após cada repetição para melhor visualização
      Console.WriteLine ("Digite as 3 notas do aluno:");//coleta de notas
      int a=int.Parse(Console.ReadLine());
      int b=int.Parse(Console.ReadLine());
      int c=int.Parse(Console.ReadLine());
      soma=a+b+c;//soma as 3 notas
      Console.WriteLine ("Digite A se deseja calcular a média aritmética ou P se deseja a média ponderada:");//coleta a escolha de média do usuário
      char m=char.Parse(Console.ReadLine());
      switch(m){
      case 'A': double ma=(double)soma/3;//divide-se a soma por 3 por ser 3 notas inseridas
        Console.WriteLine("A média aritmética é "+ma);//imprime o resultado
        break;
      case 'P': double mp=((double)(a*5)+(b*3)+(c*2))/10;//cada nota se multiplica pelos pesos impostos na questão, depois divide-se a soma de todos os valores pela soma dos pesos
        Console.WriteLine("A média ponderada é "+mp);//imprime o resultado
        break;
      }
      Console.ReadKey();//certifica que o usuário irá ver o resultado da média
    }
  }
}
