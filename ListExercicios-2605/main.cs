using System;
using System.Diagnostics;

class MainClass {
  public static void Main (string[] args) 
  {
    int ex,i = 0;
    bool result,inputOk = false;
    string input;
    Console.WriteLine ("Lista Exercícios");
    Console.Write("1.Tabuada do 4\n2.Tabuada Escolhida\n3.Média Aritmética\n4.Maior valor\n5.Contar Numeros\n");
    do
    {
      Console.Write("\nExercício:");
      input = Console.ReadLine();
      result = int.TryParse(input, out i);
      while (!result)
      {
        Console.WriteLine("Digite um numero!");
        Console.Write("\nExercício:");
        input = Console.ReadLine();
        result = int.TryParse(input, out i);
      }
      ex = int.Parse(input);
      switch(ex)
      { 
        case 1:
          inputOk = true;
          Tabuada();
          break;
        case 2:
          inputOk = true;
          TabuadaEscolhida();
          break;
        case 3:
          inputOk = true;
          MediaAritimetica();
          break;
        case 4:
          inputOk = true;
          MaiorValor();
          break;
        case 5:
          inputOk = true;
          ContarNumeros();
          break;
        default:
          Console.WriteLine("invalid");
          break;
      }
    }while(!inputOk);
  }
  public static void Tabuada()
  {
    Console.WriteLine("Tabuada do 4");
    for(int i = 0;i <= 10; i++)
    {
      Console.WriteLine("4 x {0} = " + 4 * i,i);
    }
  }
  public static void TabuadaEscolhida()
  {
    int number,i = 0;
    string input;
    bool result;
    Console.WriteLine("Tabuada Escolhida");
    Console.Write("\nEscolha uma Tabuada: ");
    input = Console.ReadLine();
      result = int.TryParse(input, out i);
      while (!result)
      {
        Console.WriteLine("Digite um numero!");
        Console.Write("\nTabuada:");
        input = Console.ReadLine();
        result = int.TryParse(input, out i);
      }
      number = int.Parse(input);
      for(int j = 0;j <= 10; j++)
      {
        Console.WriteLine( "{0} x {1} = " + number * j ,number,j);
      }
  }
  public static void MediaAritimetica()
  {
    string input;
    int number,i=0,resAd = 0;
    bool result;
    Console.WriteLine("Média Aritmética");
    for(int j = 0; j < 15;j++)
    {
      Console.Write((j+1) + "° numero: ");
      input = Console.ReadLine();
      result = int.TryParse(input, out i);
      while (!result)
      {
        Console.WriteLine("Digite um numero!");
        Console.Write((j+1) + "° numero: ");
        input = Console.ReadLine();
        result = int.TryParse(input, out i);
      }
      number = int.Parse(input);
      if(j == 0)
        resAd = number;
      if(j > 0)
        resAd = resAd+number;
    }
    Console.WriteLine("A média aritmética é " + resAd/15);
  }
  public static void MaiorValor()
  {
    string input;
    int number,i=0,testBigger = 0;
    bool result;
    Console.WriteLine("\nMaior Valor\n");
    do
    {
      Console.Write("Digite um numero: ");
      input = Console.ReadLine();
      result = int.TryParse(input, out i);
      while (!result)
      {
        Console.WriteLine("Invalid input!");
        Console.Write("Digite um numero: ");
        input = Console.ReadLine();
        result = int.TryParse(input, out i);
      }
      number = int.Parse(input);
      if(number > testBigger)
      {
        testBigger = number;
      }
    }
    while(number != 0);
    Console.WriteLine("O maior numero foi " + testBigger);
  }
  public static void ContarNumeros()
  {
    Stopwatch stopWatch = new Stopwatch();
    stopWatch.Start();
      
        
    string input;
    int number,i=0,testPar = 0,testInpar = 0,testNegative = 0,testPositive = 0 ;
    bool result;
    Console.WriteLine("\nContar Numeros\n");
    do
    {
      Console.Write("Digite um numero: ");
      input = Console.ReadLine();
      result = int.TryParse(input, out i);
      while (!result)
      {
        Console.WriteLine("Invalid input!");
        Console.Write("Digite um numero: ");
        input = Console.ReadLine();
        result = int.TryParse(input, out i);
      }
      number = int.Parse(input);
      if((number % 2) == 0 )
        testPar++;
      else
        testInpar++;
      if(number > 0)
        testPositive++;
      else if(number < 0)
        testNegative++;
    }
    while(number != 0);
    Console.WriteLine("{0} numeros par;",testPar);
    Console.WriteLine("{0} numeros inpar;",testInpar);
    Console.WriteLine("{0} numeros positivo;",testPositive);
    Console.WriteLine("{0} numeros negativo.",testNegative);

    stopWatch.Stop();
        // Get the elapsed time as a TimeSpan value.
        TimeSpan ts = stopWatch.Elapsed;

        // Format and display the TimeSpan value.
        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime);
  }
}