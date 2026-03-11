using DSA.arrays;
using FluentAssertions;

namespace DataStructuresAndAlgorithms.Tests.Arrays;

public class TwoSumTests
{
    [Theory]
    [InlineData(new[] {2,7,11,15}, 9, new[] {1,0})]
    [InlineData(new[] {3,2,4}, 6, new[] {2,1})]
    [InlineData(new[] {3,3}, 6, new[] {1,0})]
    [InlineData(new[] {1,5,3,7}, 8, new[] {2,1})]
    [InlineData(new[] {1,2,3,4,5}, 9, new[] {4,3})]
    [InlineData(new[] {-3,4,3,90}, 0, new[] {2,0})]
    [InlineData(new[] {5,5,5}, 10, new[] {1,0})]
    [InlineData(new[] {1,2,3}, 100, new int[] { })]
    public void TwoSumOptimized_ShouldReturnExpectedIndices(
        int[] nums,
        int target,
        int[] expected)
    {
        var result = TwoSums.TwoSumOptimized(nums, target);

        result.Should().Equal(expected);
    }
}