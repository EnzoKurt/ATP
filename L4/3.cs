using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Olá! Digite a quantidade de conjuntos de números que deseja colocar em órdem crescente:");//coleta o número de repetições
    int n=int.Parse(Console.ReadLine());
    for(int i=0;i<n;i++){//repetirá até a quantidade escolhida pelo usuário
      Console.WriteLine ("Digite 3 números:");//coleta 3 números
      int x=int.Parse(Console.ReadLine());
      int y=int.Parse(Console.ReadLine());
      int z=int.Parse(Console.ReadLine());
      crescente(x,y,z);//aciona o procedimento para os 3 números
      Console.ReadKey();//garante que o usuário irá ver o resultado antes do console clear limpar a tela
      Console.Clear();
    }
  }
  static void crescente(int n,int o,int p){
    int aux=0;//auxiliar para possível troca de posição
    if(n>o){//se o primeiro valor for maior que o segundo, então estes trocarão seu valor pelo método a seguir:
      aux=n;
      n=o;
      o=aux;
    }
    if(n>p){//se o primeiro valor for maior que o último, então estes trocarão seu valor pelo método a seguir:
      aux=n;
      n=p;
      p=aux;
    }
    if(o>p){//se o segundo valor for maior que o último, então estes trocarão seu valor pelo método a seguir:
      aux=o;
      o=p;
      p=aux;
    }    
    Console.WriteLine ("A órdem crescente é:\n{0} \n{1} \n{2}", n,o,p);//após as análises e possíveis trocas de posições dos números, imprime-se a órdem crescente ao usuário
  }
}
