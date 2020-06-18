using System;

namespace snackBar
{
  //Objeto Produto
  public class Products
  {
    public string Name { get; set; }
    public int Count { get; set; }
    public int Price { get; set; }
    public Products(string name, int count, int price)
    {
      Name = name;
      Count = count;
      Price = price;
    }
  }


  class Program
  {
    public static void Main(string[] args)
    {
      // Array de produtos template: xTudo, xEgg, xSalada, bauru, cocaC, guarana, sodaL, fanta;
      Products[] products = new Products[8];
      products[0] = new Products("X-Tudo", 0, 10);
      products[1] = new Products("X-Egg", 0, 7);
      products[2] = new Products("X-Salada", 0, 6);
      products[3] = new Products("Bauru", 0, 5);
      products[4] = new Products("Coca-Cola", 0, 8);
      products[5] = new Products("Guarana", 0, 7);
      products[6] = new Products("Soda", 0, 6);
      products[7] = new Products("Fanta", 0, 6);
      int i = 0, option;
      double billPrice = 0;
      bool result, inputOk = false, inputOkSub = false;
      string input;
      Console.WriteLine("LANCHONETE BONI");
      do
      {
       //principal switch
        inputOk = false;
        Console.WriteLine("\nMENU PRINCIPAL");
        Console.WriteLine("1 - LANCHES \n2 - BEBIDAS \n3 - CONTA \n0 - SAIR");
        Console.Write("\n> ");
        input = Console.ReadLine();
        result = int.TryParse(input, out i);        
        while (!result) //testa se o input é um número
        {
          Console.WriteLine("Escolha uma das opções!");
          Console.Write("\n> ");
          input = Console.ReadLine();
          result = int.TryParse(input, out i);
        }
        option = int.Parse(input);
        switch (option)
        {
          case 1:
            inputOkSub = false;
            Console.WriteLine("\nMENU LANCHES");
            do
            {
              Console.WriteLine("1 - X-TUDO R$ 10,00 \n2 - X-EGG R$ 7,00 \n3 - X-SALADA R$ 6,00 \n4 - BAURU R$ 5,00 \n0 - VOLTAR");
              Console.Write("\n> ");
              input = Console.ReadLine();
              result = int.TryParse(input, out i);
              while (!result)//testa se o input é um número
              {
                Console.WriteLine("Escolha uma das opções!");
                Console.Write("\n> ");
                input = Console.ReadLine();
                result = int.TryParse(input, out i);
              }
              option = int.Parse(input);
              //sub switch
              switch (option)
              {
                case 1:
                  products[0].Count++;
                  break;
                case 2:
                  products[1].Count++;
                  break;
                case 3:
                  products[2].Count++;
                  break;
                case 4:
                  products[3].Count++;
                  break;
                case 0:
                  inputOkSub = true;
                  break;
                default:
                  Console.WriteLine("invalid");
                  break;
              }
            } while (!inputOkSub);
            break;
          case 2:
            inputOkSub = false;
            Console.WriteLine("\nMENU BEBIDAS");
            do
            {
              Console.WriteLine("1-COCA-COLA R$ 8,00 \n2-GUARANÁ R$ 7,00 \n3-SODA-LIMONADA R$ 6,00 \n4-FANTA R$ 6,00 \n0 - VOLTAR");
              Console.Write("\n> ");
              input = Console.ReadLine();
              result = int.TryParse(input, out i);
              while (!result)//testa se o input é um número
              {
                Console.WriteLine("Escolha uma das opções!");
                Console.Write("\n> ");
                input = Console.ReadLine();
                result = int.TryParse(input, out i);
              }
              option = int.Parse(input);
              switch (option)
              {
                case 1:
                  products[4].Count++;
                  break;
                case 2:
                  products[5].Count++;
                  break;
                case 3:
                  products[6].Count++;
                  break;
                case 4:
                  products[7].Count++;
                  break;
                case 0:
                  inputOkSub = true;
                  break;
                default:
                  Console.WriteLine("invalid");
                  break;
              }
            } while (!inputOkSub);
            break;
          case 3:
            for(int j = 0; j < products.Length; j++)            
              billPrice += products[j].Count * products[j].Price;
            Console.WriteLine("\n{0,-10} {1,-6} {2,5}","PRODUTO", "QTDE", "VALOR");
            for (int j = 0; j < 8; j++)
            {
              if (products[j].Count >= 1)
                Console.WriteLine("{0, -10} {1,-6} {2,5:N2}", products[j].Name, products[j].Count, (products[j].Count * products[j].Price));
            }
            Console.WriteLine("-----------------------");
            Console.WriteLine("{0,-10} {1,12:N2}\n", "TOTAL",billPrice);
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
  }
}
