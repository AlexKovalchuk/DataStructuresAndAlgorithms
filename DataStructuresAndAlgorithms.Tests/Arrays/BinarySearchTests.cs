using DataStructuresAndAlgorithms.Arrays;
using FluentAssertions;

namespace DataStructuresAndAlgorithms.Tests.Arrays;

public class BinarySearchTests
{
    [Theory]
    [InlineData(new[] { -1,0,3,5,9,12 }, 9, 4)]
    [InlineData(new[] { -1,0,3,5,9,12 }, 2, -1)]
    [InlineData(new[] { 1 }, 1, 0)]
    [InlineData(new[] { 1 }, 0, -1)]
    [InlineData(new[] { 1,3,5,7,9 }, 1, 0)]
    [InlineData(new[] { 1,3,5,7,9 }, 9, 4)]
    [InlineData(new[] { 1,3,5,7,9 }, 6, -1)]
    [InlineData(new[] { -10,-5,0,5,10 }, -5, 1)]
    public void BinarySearch_ShouldReturnExpectedIndex(int[] nums, int target, int expected)
    {
        var result = Search.BinarySearch(nums, target);

        result.Should().Be(expected);
    }
}