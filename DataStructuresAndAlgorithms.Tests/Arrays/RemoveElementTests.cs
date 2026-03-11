using DataStructuresAndAlgorithms.arrays;
using FluentAssertions;

namespace DataStructuresAndAlgorithms.Tests.Arrays;

public class RemoveElementTests
{
    [Theory]
    [InlineData(new int[] { 3,2,2,3 }, 3, 2, new[] { 2,2 })]
    [InlineData(new int[] { 0,1,2,2,3,0,4,2 }, 2, 5, new[] { 0,1,4,0,3 })]
    [InlineData(new int[] { 1,1,1 }, 1, 0, new int[] { })]
    [InlineData(new int[] { 1,2,3,4 }, 5, 4, new[] { 1,2,3,4 })]
    [InlineData(new int[] { 2,2,2,2 }, 2, 0, new int[] { })]
    [InlineData(new int[] { 1 }, 1, 0, new int[] { })]
    [InlineData(new int[] { 1 }, 2, 1, new[] { 1 })]
    [InlineData(new int[] { 4,5 }, 5, 1, new[] { 4 })]
    public void RemoveElementBruteForce_ShouldReturnExpected(int[] nums, int val, int expectedK, int[] expectedValues)
    {
        var k = RemoveElement.RemoveElementBruteForce(nums, val);

        k.Should().Be(expectedK);
        nums.Take(k).Should().BeEquivalentTo(expectedValues);
    }
}