using DataStructuresAndAlgorithms.Arrays;
using FluentAssertions;

namespace DataStructuresAndAlgorithms.Tests.Arrays;

public class FindFirstAndLastPositionOfElementsInSortedArray34Tests
{
    [Theory]
    [InlineData(new[] { 5, 7, 7, 8, 8, 10 }, 8, new[] { 3, 4 })]
    [InlineData(new[] { 5, 7, 7, 8, 8, 10 }, 6, new[] { -1, -1 })]
    [InlineData(new int[] { }, 0, new[] { -1, -1 })]
    [InlineData(new[] { 1 }, 1, new[] { 0, 0 })]
    [InlineData(new[] { 1 }, 0, new[] { -1, -1 })]
    [InlineData(new[] { 2, 2, 2, 2 }, 2, new[] { 0, 3 })]
    [InlineData(new[] { 1, 2, 3, 4, 5 }, 3, new[] { 2, 2 })]
    [InlineData(new[] { 1, 2, 2, 2, 3, 4 }, 2, new[] { 1, 3 })]
    [InlineData(new[] { 1, 3, 5, 7 }, 0, new[] { -1, -1 })]
    [InlineData(new[] { 1, 3, 5, 7 }, 10, new[] { -1, -1 })]
    public void SearchRange_ShouldReturnExpectedRange(int[] nums, int target, int[] expected)
    {
        var sut = new FindFirstAndLastPositionOfElementsInSortedArray_34();

        var result = sut.SearchRange(nums, target);

        result.Should().Equal(expected);
    }
}