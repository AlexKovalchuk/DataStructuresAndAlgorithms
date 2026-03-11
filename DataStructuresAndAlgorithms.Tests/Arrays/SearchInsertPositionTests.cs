using DataStructuresAndAlgorithms.Arrays;
using FluentAssertions;

namespace DataStructuresAndAlgorithms.Tests.Arrays;

public class SearchInsertPositionTests
{
    [Theory]
    [InlineData(new[] {1,3,5,6}, 5, 2)]
    [InlineData(new[] {1,3,5,6}, 2, 1)]
    [InlineData(new[] {1,3,5,6}, 7, 4)]
    [InlineData(new[] {1,3,5,6}, 0, 0)]
    [InlineData(new[] {1}, 0, 0)]
    [InlineData(new[] {1}, 1, 0)]
    [InlineData(new[] {1}, 2, 1)]
    [InlineData(new[] {1,2,4,6,8}, 3, 2)]
    [InlineData(new[] {1,2,4,6,8}, 8, 4)]
    [InlineData(new[] {1,2,4,6,8}, 9, 5)]
    public void SearchInsertUsingBinarySearch_ShouldReturnExpectedIndex(
        int[] nums,
        int target,
        int expected)
    {
        var result = SearchInsertPosition.SearchInsertUsingBinarySearch(nums, target);

        result.Should().Be(expected);
    }
}