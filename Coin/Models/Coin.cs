using System.Collections.Generic;


namespace Coin.Models
{
public class CoinCalculator
{
  public static Dictionary<string, int> CoinCombinations(int cents)
  {
    Dictionary<string, int> result = new Dictionary<string, int>();

    int quarters = cents / 25;
    cents %= 25;
    int dimes = cents / 10;
    cents %= 10;
    int nickels = cents / 5;
    cents %= 5;
    int pennies = cents / 1;

    result.Add("Quarters", quarters);
    result.Add("Dimes", dimes);
    result.Add("Nickels", nickels);
    result.Add("Pennies", pennies);

    return result;
  }
}

}
