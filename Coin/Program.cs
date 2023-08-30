using System;
using System.Collections.Generic;
using System.Linq;
using Coin.Models;


namespace Coin
{
 class Program
 {
  static void Main()
  {
   Console.WriteLine("Welcome to Coin Calculator!");
   Console.WriteLine("Please enter a ¢ amount");

  // int centAmount = Console.ReadLine();
  // int changeTotal = centAmount.CoinCombinations();


  string centAmount = Console.ReadLine();
  int centInt = int.Parse(centAmount);
  var changeTotal = CoinCalculator.CoinCombinations(centInt);

  foreach (var value in changeTotal)
  {
    Console.WriteLine($"Your change is: ${value}.");
  }
  // Console.WriteLine($"Your change is: ${changeTotal}.");

  }
 }
}





// string str = "123";
// int parsedValue = int.Parse(str);

