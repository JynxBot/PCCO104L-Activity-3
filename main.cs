using System;

class Program {
  public static void Main (string[] args) {
    int num;

    do {
      Console.Write ("Enter a Number: ");
      string input = Console.ReadLine();

      if (!int.TryParse(input, out num) || num < 0) {
        Console.WriteLine($"Invalid Input: {input} ");
        continue;
      }

      if (num == 0) break;

      for (int i = 1; i <= num; i++) {
        for (int j = 1; j <= (num - i); j++)
          Console.Write(" ");

        for (int k = 1; k < i * 2; k++)
          Console.Write("*");

        Console.WriteLine();
      }
    } while (true);

    Console.WriteLine("Closing Program...");
  }
}