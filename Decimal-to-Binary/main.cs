using System;

class MainClass {
  public static void Main (string[] args) {
    int dec, end;
    int[] bin = new int[20];
    for(int j = 0;j < 20; ++j)
    {
      bin[j] = 2;
    }
    Console.WriteLine ("DECIMAL to BINARY");
    Console.Write("Deciamal:");
    dec = int.Parse(Console.ReadLine());
    end = dec;
    Console.WriteLine(end);
    int i = 0;
    while(end > 0)
    {
      bin[i] = end%2;
      Console.WriteLine((end - bin[i]) / 2);
      end = (end - bin[i])/2;
      i++;
    }
    Console.WriteLine();
    for(int tt = 19;tt >= 0;tt--)
    {
      Console.Write(tt + 1 + " - ");
    }
    Console.WriteLine();
    for(int j = 19;j >= 0;j--)
    {
      
      if(bin[j] < 2)
      {
        Console.Write(bin[j]);
      }
    }
  }
}