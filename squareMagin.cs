/*
  Author: Pedro Bonifacio
  GitHub repository: https://github.com/PedroBoni/learning-Csharp
  Run on: https://repl.it/@PedroBoni/squareMagic
*/
using System;

class MainClass {
  public static void Main () {
    int dimension = 0;

    Console.Clear();
    Console.WriteLine ("Quadrado Mágico");
    Console.Write("Qual o tamanho do seu Quadrado: ");
    dimension = inputRight(inputIsInteger(Console.ReadLine()));

    int[,] square = new int[dimension, dimension];
    double maxNumber = Math.Pow(dimension, 2);
    int positionX = (dimension/2);
    int positionY = 0;
    int formattingSpaces = 0;

    // starting position
    square[positionY, positionX] = 1;

    for(int i = 2; i <= maxNumber; i++){      
      int previousX = positionX, previousY = positionY;

      // Up and Right
      positionX++;
      positionY--;

      // reached the limit of the square
      if(positionX > dimension - 1)
        positionX = 0;
      if(positionY < 0)
        positionY = dimension - 1;
      
      // if you already have a filled house
      if(square[positionY, positionX] != 0){
        positionX = previousX;
        positionY = previousY + 1;
        if(positionY < 0)
          positionY = dimension - 1;
      }

      square[positionY, positionX] = i;
    }

    // calculate formatting Spaces
    formattingSpaces = (maxNumber.ToString()).Length * 2;

    // print result
    for(int i = 0; i < dimension; i++){
        Console.Write("\n");
        for(int j = 0 ; j < dimension; j++){ 
           Console.Write((square[i, j].ToString()).PadRight(formattingSpaces));
        }
    }
    Console.WriteLine();
  }
 
  static int inputRight(int n){
    bool inputOk = n % 2 == 1 &&  n >= 3;

    while (!inputOk) { 
      Console.WriteLine("Deve ser um número maior que 3 e ímpar!");
      Console.Write("\nTente novamente: ");
      n = inputIsInteger(Console.ReadLine());
      inputOk = n % 2 == 1 &&  n >= 3;
    }
    return n;
  }

  static int inputIsInteger(string input) {
    int i;
    bool isInteger = int.TryParse(input, out i);
            
    while (!isInteger) {
      Console.WriteLine("Digite um numero!");
      Console.Write("\nTente novamente: ");
      input = Console.ReadLine();
      isInteger = int.TryParse(input, out i);
    }

    return int.Parse(input);
  }

}
