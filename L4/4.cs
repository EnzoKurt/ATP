using System;

class Program {
  public static void Main (string[] args) {
    int x,y,z;
    do{
      Console.WriteLine ("Digite 3 medidas inteiras:");//coleta 3 números
      x=int.Parse(Console.ReadLine());
      y=int.Parse(Console.ReadLine());
      z=int.Parse(Console.ReadLine());
      triangulo(x,y,z);//aciona o procedimento para os 3 números
      Console.ReadKey();//garante que o usuário irá ver o resultado antes do console clear limpar a tela
      Console.Clear();
      }while(x>0);
  }
  static void triangulo(int n,int o,int p){
    if(n+p!=o && n+o!=p && o+p!=n){//para se formar um triângulo, a soma de dois lados não pode ser igual a medida de um dos lados
      if(n==o && o==p){//se os 3 lados forem iguais, então imprime a seguinte mensagem
        Console.WriteLine ("triângulo equilátero");
      }
      else if(n==p || n==o || o==p){//se nem todos forem iguais, porém dois dos lados forem, então imprime a seguinte mensagem
        Console.WriteLine ("triângulo isósceles");
      }
      else{//se todos os lados tiverem medidas diferentes, então imprime a seguinte mensagem
        Console.WriteLine ("triângulo escaleno");
      }    
    }
    else{//se não obedecer a regra de formação de triângulo, então imprime a mensagem
      Console.WriteLine ("Não é triângulo!");
    }
  }
}
