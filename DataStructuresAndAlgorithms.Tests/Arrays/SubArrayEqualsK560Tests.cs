using DataStructuresAndAlgorithms.Arrays;
using FluentAssertions;

namespace DataStructuresAndAlgorithms.Tests.Arrays;

public class SubArrayEqualsK560Tests
{
    [Theory]
    [InlineData(new[] { 1, 1, 1 }, 2, 2)]
    [InlineData(new[] { 1, 2, 3 }, 3, 2)]
    [InlineData(new[] { 1, -1, 1, -1, 1 }, 1, 6)]
    [InlineData(new[] { 1 }, 1, 1)]
    [InlineData(new[] { 1 }, 0, 0)]
    [InlineData(new[] { 0, 0, 0 }, 0, 6)]
    [InlineData(new[] { 3, 4, 7, 2, -3, 1, 4, 2 }, 7, 4)]
    [InlineData(new[] { -1, -1, 1 }, 0, 1)]
    [InlineData(new[] { 2, -1, 2 }, 3, 1)]
    public void SubarraySum_ShouldReturnExpectedCount(int[] nums, int k, int expected)
    {
        var sut = new SubArrayEqualsK_560();

        var result = sut.SubarraySum(nums, k);

        result.Should().Be(expected);
    }
}