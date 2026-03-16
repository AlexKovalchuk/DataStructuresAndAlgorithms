using DataStructuresAndAlgorithms.Arrays;
using FluentAssertions;

namespace DataStructuresAndAlgorithms.Tests.Arrays;

public class BestTimeToBuyAndSellStock121Tests
{
    [Theory]
    [InlineData(new[] { 7, 1, 5, 3, 6, 4 }, 5)]
    [InlineData(new[] { 7, 6, 4, 3, 1 }, 0)]
    [InlineData(new[] { 1, 2, 3, 4, 5 }, 4)]
    [InlineData(new[] { 2, 1, 2, 1, 0, 1, 2 }, 2)]
    [InlineData(new[] { 3, 3, 3, 3 }, 0)]
    [InlineData(new[] { 5 }, 0)]
    [InlineData(new[] { 2, 4, 1 }, 2)]
    [InlineData(new[] { 2, 4, 1, 7 }, 6)]
    [InlineData(new[] { 10, 1, 2, 3, 0, 8 }, 8)]
    [InlineData(new[] { 0, 0, 0, 5 }, 5)]
    public void MaxProfit_ShouldReturnExpectedProfit(int[] prices, int expected)
    {
        var result = BestTimeToBuyAndSellStock121.MaxProfit(prices);

        result.Should().Be(expected);
    }
}
