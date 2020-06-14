using System;

class MainClass {
  public static void Main (string[] args) {
    DateTime date = DateTime.Now;
    int option,hour,minute = date.Minute,i = 0;
    string minuteFormat,input;
    bool result,inputOk = true;

    Console.WriteLine ("Selecione o País para ver as horas: \n1.Brasil\n2.Alemanha\n3.Estados Unidos\n4.França");
    do
    {
      Console.Write("\nPaís:");
      input = Console.ReadLine();
      result = int.TryParse(input, out i);
      while (!result)
      {
        Console.WriteLine("Digite um numero!");
        Console.Write("\nPaís:");
        input = Console.ReadLine();
        result = int.TryParse(input, out i);
      }
      option = int.Parse(input);
      switch(option)
      {
        case 1:
          hour = date.Hour - 3;
          if(hour < 0)
            hour = 24 + hour;
          if(minute < 10)
          {
            minuteFormat = "0"+ minute.ToString();
            Console.WriteLine("\nBrasil: {0}:{1}",hour,minuteFormat);
          }
          else
            Console.WriteLine("\nBrasil: {0}:{1}",hour,date.Minute);
          inputOk = false;
          break;
        case 2:
          hour = date.Hour + 2;
          if(hour < 0)
            hour = 24 + hour;
          if(minute < 10)
          {
            minuteFormat = "0"+ minute.ToString();
            Console.WriteLine("\nAlemanha: {0}:{1}",hour,minuteFormat);
          }
          else
            Console.WriteLine("\nAlemanha: {0}:{1}",hour,date.Minute);
          inputOk = false;
          break;
        case 3:
          hour = date.Hour - 4;
          if(hour < 0)
            hour = 24 + hour;
          if(minute < 10)
          {
            minuteFormat = "0"+ minute.ToString();
            Console.WriteLine("\nEstados Unidos: {0}:{1}",hour,minuteFormat);
          }
          else
            Console.WriteLine("\nEstados Unidos: {0}:{1}",hour,date.Minute);
          inputOk = false;
          break;
        case 4:
          hour = date.Hour + 2;
          if(hour < 0)
            hour = 24 + hour;
          if(minute < 10)
          {
            minuteFormat = "0"+ minute.ToString();
            Console.WriteLine("\nFrança: {0}:{1}",hour,minuteFormat);
          }
          else
            Console.WriteLine("\nFrança: {0}:{1}",hour,date.Minute);
          inputOk = false;
          break;
        default:
          Console.WriteLine("invalid");
          break;
      }
    }while(inputOk);
    Console.Write("\n\nPress to quit");
    Console.ReadKey();
  }
}