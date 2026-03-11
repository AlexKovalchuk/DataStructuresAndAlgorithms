using DataStructuresAndAlgorithms.Arrays;
using FluentAssertions;

namespace DataStructuresAndAlgorithms.Tests.Arrays;

public class PlusOneTests
{
    [Theory]
    [InlineData(new[] { 1, 2, 3 }, new[] { 1, 2, 4 })]
    [InlineData(new[] { 4, 3, 2, 1 }, new[] { 4, 3, 2, 2 })]
    [InlineData(new[] { 9 }, new[] { 1, 0 })]
    [InlineData(new[] { 9, 9, 9 }, new[] { 1, 0, 0, 0 })]
    [InlineData(new[] { 1, 9, 9 }, new[] { 2, 0, 0 })]
    [InlineData(new[] { 0 }, new[] { 1 })]
    [InlineData(new[] { 8, 9, 9, 9 }, new[] { 9, 0, 0, 0 })]
    [InlineData(new[] { 2, 9 }, new[] { 3, 0 })]
    public void IncrementTheLargestIntegerByOne_ShouldReturnExpected(int[] input, int[] expected)
    {
        var result = PlusOne.IncrementTheLargestIntegerByOne(input);

        result.Should().Equal(expected);
    }
}