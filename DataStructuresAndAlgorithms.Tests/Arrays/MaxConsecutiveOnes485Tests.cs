using DataStructuresAndAlgorithms.Arrays;
using FluentAssertions;

namespace DataStructuresAndAlgorithms.Tests.Arrays;

public class MaxConsecutiveOnes485Tests
{
    [Theory]

    [InlineData(new[] { 1, 1, 0, 1, 1, 1 }, 3)]
    [InlineData(new[] { 1, 1, 1, 1, 1 }, 5)]
    [InlineData(new[] { 0, 0, 0, 0 }, 0)]
    [InlineData(new[] { 1 }, 1)]
    [InlineData(new[] { 0 }, 0)]
    [InlineData(new[] { 0, 0, 1, 1, 1 }, 3)]
    [InlineData(new[] { 1, 1, 1, 0, 0 }, 3)]
    [InlineData(new[] { 1, 0, 1, 0, 1, 0, 1 }, 1)]
    [InlineData(new[] { 0, 1, 1, 1, 1, 0, 1 }, 4)]

    public void FindMaxConsecutiveOnes_ShouldReturnExpected(int[] nums, int expected)
    {
        var result = MaxConsecutiveOnes485.FindMaxConsecutiveOnes(nums);

        result.Should().Be(expected);
    }
}