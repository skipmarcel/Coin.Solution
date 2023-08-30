using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Coin.Models;

namespace Coin.Tests.ModelTests
{
    
[TestClass]
public class CoinCalculatorTests
{
    [TestMethod]
    public void CalculateCoinCombinations_ReturnsCorrectCombinationFor5Cents()
    {
        // Arrange
        int cents = 5;

        // Act
        Dictionary<string, int> result = CoinCalculator.CoinCombinations(cents);

        // Assert
        Assert.AreEqual(0, result["Quarters"]);
        Assert.AreEqual(0, result["Dimes"]);
        Assert.AreEqual(1, result["Nickels"]);
        Assert.AreEqual(0, result["Pennies"]);
    }

    [TestMethod]
    public void CalculateCoinCombinations_ReturnsCorrectCombinationFor10Cents()
    {
        // Arrange
        int cents = 10;

        // Act
        Dictionary<string, int> result = CoinCalculator.CoinCombinations(cents);

        // Assert
        Assert.AreEqual(0, result["Quarters"]);
        Assert.AreEqual(1, result["Dimes"]);
        Assert.AreEqual(0, result["Nickels"]);
        Assert.AreEqual(0, result["Pennies"]);
    }

    [TestMethod]
    public void CalculateCoinCombinations_ReturnsCorrectCombinationFor25Cents()
    {
        // Arrange
        int cents = 25;

        // Act
        Dictionary<string, int> result = CoinCalculator.CoinCombinations(cents);

        // Assert
        Assert.AreEqual(1, result["Quarters"]);
        Assert.AreEqual(0, result["Dimes"]);
        Assert.AreEqual(0, result["Nickels"]);
        Assert.AreEqual(0, result["Pennies"]);
    }

}
}


