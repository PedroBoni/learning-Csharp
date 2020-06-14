using System;


class MainClass {
  public static void Main (string[] args) 
  {
    int ex,i = 0;
    bool result,inputOk = false;
    string input;
    Console.WriteLine ("Lista Exercícios");
    Console.Write("1.Par 11-250\n2.Teste Impar\n3.Tabuada 	Escolhida\n4.Teste Qnt Impar\n5.Maior Numero\n6.Media\n7.Multiplo de 10\n8.Fatorial\n9.Contar Numeros");
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
          Par11a250();
          break;
        case 2:
          inputOk = true;
          TestImpar();
          break;
        case 3:
          inputOk = true;
          TabuadaEscolhida();
          break;
        case 4:
          inputOk = true;
          TestQntImpar();
          break;
        case 5:
          inputOk = true;
          ContarMaiorNumero();
          break;
				case 6:
          inputOk = true;
          Media();
          break;
				case 7:
					inputOk = true;
					Multiplo10();
					break;
				case 8:
					inputOk = true;
					Fatorial();
					break;
				case 9:
					inputOk = true;
					ContarNumeros();
					break;
				case 10:
					inputOk = true;
					Salario();
					break;
        default:
          Console.WriteLine("invalid");
          break;
      }
    }while(!inputOk);
  }
  public static void Par11a250()
  {
    Console.WriteLine("Teste numeros pares entre 11 a 250\n");
		int j = 0;
    for(int i = 11;i <= 250; ++i)
    {
			if(i % 2 == 0)
			{
				++j;
				
				if(i < 100)
					Console.Write(" " + i + "|");
				else
					Console.Write(i + "|");
				if(j % 10 == 0)
					Console.Write("\n");
			}
    }
  }
  public static void TestImpar()
  {
    int start = 0,end=0,i = 0,j = 0;
    string input;
    bool result;
    Console.WriteLine("Imprimir números ímpares");
		for(int it = 1;it <= 2;it++)
		{
			if(it == 1)
				Console.Write("\nDigite o primeiro número: ");
			else
				Console.Write("\nDigite o ultimo número: ");
    	input = Console.ReadLine();
    	result = int.TryParse(input, out i);
    	while (!result)
    	{
      	Console.WriteLine("Digite um numero!");
      	Console.Write("\nDigite o primeiro número: ");
      	input = Console.ReadLine();
      	result = int.TryParse(input, out i);
    	}
			if(it == 1)
				start = int.Parse(input);
			else
				end = int.Parse(input);
		}
    for(int k = end;k >= start; --k)
    {
			if(k % 2 == 1)
			{
				++j;
				Console.Write(k + "|");
				if(j % 10 == 0)
					Console.Write("\n");
			}
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
  public static void TestQntImpar()
  {
    int start = 0,end=0,i = 0,j = 0;
    string input;
    bool result;
    Console.WriteLine("Imprimir quantidade de números ímpares");
		for(int it = 1;it <= 2;it++)
		{
			if(it == 1)
				Console.Write("\nDigite o primeiro número: ");
			else
				Console.Write("\nDigite o ultimo número: ");
    	input = Console.ReadLine();
    	result = int.TryParse(input, out i);
    	while (!result)
    	{
      	Console.WriteLine("Digite um numero!");
      	Console.Write("\nDigite o primeiro número: ");
      	input = Console.ReadLine();
      	result = int.TryParse(input, out i);
    	}
			if(it == 1)
				start = int.Parse(input);
			else
				end = int.Parse(input);
		}
    for(int k = start;k <= end; k++)
    {
			if(k % 2 == 1)
			{
				j++;
			}
    }
		Console.WriteLine("{0} números ímpar",j);
  }
  public static void ContarMaiorNumero()
  {
    int number,maiorNumber = 0,i = 0;
    string input;
    bool result;
    Console.WriteLine("Imprimir maior número");
		Console.WriteLine("Você terá que digitar 15 números");
		for(int it = 1;it <= 15;it++)
		{
			Console.Write("\nDigite o {0}° número: ",it);
    	input = Console.ReadLine();
    	result = int.TryParse(input, out i);
    	while (!result)
    	{
      	Console.WriteLine("Digite um numero!");
      	Console.Write("\nDigite o {0}° número: ",it);
      	input = Console.ReadLine();
      	result = int.TryParse(input, out i);
    	}
			number = int.Parse(input);
			if(number > maiorNumber)
				maiorNumber = number;
		}
		Console.WriteLine("\n{0} é o maior número",maiorNumber);
	}
	 public static void Media()
  {
    int nota = 0,i = 0;
    string input;
    bool result;
    Console.WriteLine("Imprimir média");
		Console.WriteLine("Você terá que digitar 10 notas de 0 a 10");
		for(int it = 1;it <= 10;it++)
		{
			Console.Write("\nDigite o {0}° número: ",it);
    	input = Console.ReadLine();
    	result = int.TryParse(input, out i);
			if(!((int.Parse(input)) >= 0 && (int.Parse(input)) <= 10))
				{
					Console.WriteLine("\nDigite um número de 0 a 10!");
					result = false;
				}
    	while (!result)
    	{
      	Console.WriteLine("\nTente novamente!");
      	Console.Write("\nDigite o {0}° número: ",it);
      	input = Console.ReadLine();
      	result = int.TryParse(input, out i);
				if(!((int.Parse(input)) >= 0 && (int.Parse(input)) <= 10))
				{
					Console.WriteLine("Digite um número de 0 a 10!");
					result = false;
				}
					
    	}
			nota = nota + int.Parse(input);
		}
		Console.WriteLine(nota);
		//média arrendoda pra cima se o resto da divisão for maior ou igual que 5
		if(nota % 10 >= 5)
			Console.WriteLine("\n {0} é a média",(nota / 10 + 1));
		else
			Console.WriteLine("\n {0} é a média",(nota / 10));
	}
	 public static void Multiplo10()
  {
    Console.WriteLine("Testa números multiplos de 10\n");
		
    for(int i = 1;i <= 100; ++i)
    {
			if(i % 10 == 0)
				Console.WriteLine(i + "- MÚLTIPLO DE 10");
			else
				Console.WriteLine(i);
    }
  }
	public static void Fatorial()
  {
   	int number,i = 0,n;
    string input;
    bool result;
    Console.WriteLine("Calcule Fatorial");
    Console.Write("\nDigite um número: ");
    input = Console.ReadLine();
    result = int.TryParse(input, out i);
      while (!result)
      {
        Console.WriteLine("Tente novamente!");
        Console.Write("\nDigite um numero: ");
        input = Console.ReadLine();
        result = int.TryParse(input, out i);
      }
			n = int.Parse(input);
      number = int.Parse(input);
      for(int j = number - 1;j >= 1; j--)
      {
				number = number * j; 
      }
			Console.WriteLine( "{0}! = {1}",n,number);
  }
	 public static void ContarNumeros()
  {
    string input;
    int number,i=0,testPar = 0,testInpar = 0,testNegative = 0,testPositive = 0 ;
		char st;
    bool result,stop = false;
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
			Console.Write("Deseja encessar o programa?(S/n) ");
      input = Console.ReadLine();
      result = char.TryParse(input, out st);
      while (!result)
      {
        Console.WriteLine("Tente Novamente!");
        Console.Write("Deseja encessar o programa?(S/n) ");
        input = Console.ReadLine();
        result = char.TryParse(input, out st);
      }
			if(input == "S" || input == "s")
				stop = true;
    }
    while(!stop);
    Console.WriteLine("{0} numeros par;",testPar);
    Console.WriteLine("{0} numeros inpar;",testInpar);
    Console.WriteLine("{0} numeros positivo;",testPositive);
    Console.WriteLine("{0} numeros negativo.",testNegative);
  }
	public static void Salario()
  {
    int i = 0,C = 0,N = 0,E = 0;
    string input;
    bool result,stop = false;
		char st;
    Console.WriteLine("Calcular salário");
		Console.WriteLine("Você terá que digitar o código do operário e as horas trabalhadas.");
		for(int it = 1;it <= 2;it++)
		{
			if(it == 1)
				Console.Write("\nDigite o código do operário: ");
			else
				Console.Write("\nDigite as horas trabalhadas do operário: ");
    	input = Console.ReadLine();
    	result = int.TryParse(input, out i);
    	while (!result)
    	{
      	Console.WriteLine("\nTente novamente!");
      	Console.Write("\nDigite um número: ");
      	input = Console.ReadLine();
      	result = int.TryParse(input, out i);					
    	}
			if(it == 1)
				C = int.Parse(input);
			else
				N = int.Parse(input);
		}
		Console.WriteLine("Salário do operário {0}:",C);
		if(N % 50 >= 50)		
			E = N - 50;
		
		if(E > 0)
		{
			Console.WriteLine("\nSalario: R$ {0}.",((N - E )* 10));
			Console.WriteLine("\nSalario Excedente: R$ {0}.",(E * 20));
		}
		else
			Console.WriteLine("\nSalario: R$ {0}.",(N * 10));
		
		while(!stop)
		{
			Console.Write("Deseja encessar o programa?(S/n) ");
      input = Console.ReadLine();
      result = char.TryParse(input, out st);
      while (!result)
      {
        Console.WriteLine("Tente Novamente!");
        Console.Write("Deseja encessar o programa?(S/n) ");
        input = Console.ReadLine();
        result = char.TryParse(input, out st);
      }
			if(input == "S" || input == "s")
				stop = true;
		}	
	}
}