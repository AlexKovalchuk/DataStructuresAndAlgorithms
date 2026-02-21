using DataStructuresAndAlgorithms.arrays;
using FluentAssertions;

namespace DataStructuresAndAlgorithms.Tests.Arrays;

public class FindDuplicateTests
{
    [Theory]
    [InlineData(new int[] { }, false)]
    [InlineData(new[] { 1 }, false)]
    [InlineData(new[] { 1, 2, 3, 4, 5 }, false)]
    [InlineData(new[] { 1, 2, 3, 1 }, true)]
    [InlineData(new[] { 5, 5, 5, 5 }, true)]
    [InlineData(new[] { -1, -2, -3, -1 }, true)]
    [InlineData(new[] { 0, 1, 2, 3, 0 }, true)]
    [InlineData(new[] { int.MaxValue, int.MinValue, 0 }, false)]
    public void FindDuplicateHashSet_ShouldReturnExpectedResult(int[] input, bool expected)
    {
        var result = FindDuplicate.FindDuplicateHashSet(input);

        result.Should().Be(expected);
    }
}