using System;

class Program {
  public static void Main (string[] args) {
    for(int i=0;i<10;i++){
      Console.WriteLine ("Digite um número");//coleta do número
      int a=int.Parse(Console.ReadLine());
      if(a==0) Console.WriteLine("Número neutro");//auto explicativo
      else if(sinal(a)){//a função booleana é chamada para analisar o número. Como o valor padrão da função é true, então se a for true, então a mensagem abaixo é mostrada
        Console.WriteLine("Número é positivo");
      }
      else if(!sinal(a)){//a função booleana é chamada para analisar o número. Como o valor padrão da função é true, então se a for diferente (!) de true, então a mensagem abaixo é mostrada
        Console.WriteLine("Número é negativo");
      }      
      Console.ReadKey();
      Console.Clear();
    }
  }
  static bool sinal(int x){
    if(x>0)//se o número for maior que 0, então retorna true
    return true;
    else //se o número não for maior que 0, então retorna true
    return false;
  }
}
