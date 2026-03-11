using DataStructuresAndAlgorithms.arrays;
using FluentAssertions;

namespace DataStructuresAndAlgorithms.Tests.Arrays;

public class RemoveDuplicatesFromSortedArrayTests
{
    [Theory]
    [InlineData(new int[] { }, 0, new int[] { })]
    [InlineData(new[] { 1 }, 1, new[] { 1 })]
    [InlineData(new[] { 1, 1, 2 }, 2, new[] { 1, 2 })]
    [InlineData(new[] { 1, 2, 3 }, 3, new[] { 1, 2, 3 })]
    [InlineData(new[] { 1, 1, 1, 1 }, 1, new[] { 1 })]
    [InlineData(new[] { 0,0,1,1,1,2,2,3,3,4 }, 5, new[] { 0,1,2,3,4 })]
    [InlineData(new[] { -3,-3,-2,-2,-1,0,0,1 }, 5, new[] { -3,-2,-1,0,1 })]
    public void RemoveDuplicatesSimple_ShouldReturnExpected(int[] nums, int expectedK, int[] expectedPrefix)
    {
        var k = RemoveDuplicatesFromSortedArray.RemoveDuplicatesSimple(nums);

        k.Should().Be(expectedK);
        nums.Take(k).Should().Equal(expectedPrefix);
    }
}