/*
  Author: Pedro Bonifacio,
  GitHub repository: https://github.com/PedroBoni/learning-Csharp;
  Run on: https://repl.it/@PedroBoni/listEx15-07,
  Date: 20/07/2020.
*/

using System;

class MainClass {
  public static void Main (string[] args) {
    bool inputOk = false;
    do
    {
      Console.Clear();
      Console.WriteLine ("1. Média 10\n2. Soma Par\n3. Nomes M\n0.Sair");
      Console.Write("\nOpção: ");
      switch (inputIsInteger(Console.ReadLine()))
      {
        case 1:
          average();
          break;
        case 2:
          sumEven();
          break;
        case 3:
          namesM();
          break;
        case 0:
          inputOk = true;
        break;
        default:
          Console.WriteLine("invalid");
          break;
      }
    } while (!inputOk);
  }
  static void average()
  {
    double[] averages = new double[10];
    string[] names = new string[10];
    double grades = 0;

    for(int i = 0; i < 10; i++)
    {
      Console.WriteLine("\n{0}° Aluno \n", i + 1);
      Console.Write("Nome: "); names[i] = Console.ReadLine();
      for(int j = 0; j < 4; j++)
      {
        Console.Write("{0}° Nota: ", j + 1);
        grades += isLess10(inputIsDouble(Console.ReadLine())); 
      }
      averages[i] = grades/4;
      grades = 0;
    }
    Console.WriteLine();
    for(int i = 0; i < 10; i++)
    {
      Console.WriteLine("{0}: {1}", names[i], averages[i]);
    }
  }
  static void sumEven()
  {
    int[] values = new int[50];
    for(int j = 0; j < 2; j++)
    {
      for(int i = 0; i < values.Length; i++)
      {
        if(j == 0)
        {
          Console.Write("{0}°N: ", i); 
          values[i] = inputIsInteger(Console.ReadLine());
        }
        else
        {
          if(values[i] % 2 == 0)
            Console.Write("{0}  ", values[i]);
        }
      }
    }
  }
  static void namesM()
  {
    string[] names = new string[10];
    for(int j = 0; j < 2; j++)
    {
      for(int i = 0; i < names.Length; i++)
      {
        if(j == 0)
        {
          Console.Write("{0}° Name: ", i); 
          names[i] = Console.ReadLine();
        }
        else
        {
          if(Char.ToUpper(names[i][0]) == 'M')
            Console.WriteLine("{0}", names[i]);
        }
      }
    }
  }
  // Input validators
  static int inputIsInteger(string input)
  {
    int i;
    bool isInteger = int.TryParse(input, out i);
            
    while (!isInteger)
    {
      Console.WriteLine("Digite um numero!");
      Console.Write("\nTente novamente: ");
      input = Console.ReadLine();
      isInteger = int.TryParse(input, out i);
    }

    return int.Parse(input);
  }

  static double inputIsDouble(string input)
  {
    double i;
    bool isDouble = double.TryParse(input, out i);

    while (!isDouble)
    {
      Console.WriteLine("Digite um numero!");
      Console.Write("\nTente novamente: ");
      input = Console.ReadLine();
      isDouble = double.TryParse(input, out i);
    }         
    return double.Parse(input);
  }
  
  static double isLess10(double n)
  {   
    bool isLess10 = false;
    isLess10 = n <= 10;

    while (!isLess10)
    {
      Console.WriteLine("Digite um numero menor ou igual a 10!");
      Console.Write("\nTente novamente: ");
      n = inputIsDouble(Console.ReadLine());
      isLess10 = n <= 10;
    }         
    return n;
  }
}
