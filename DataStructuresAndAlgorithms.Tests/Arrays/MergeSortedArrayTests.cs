using DataStructuresAndAlgorithms.Arrays;
using FluentAssertions;

namespace DataStructuresAndAlgorithms.Tests.Arrays;

public class MergeSortedArrayTests
{
    [Theory]
    [InlineData(new[] { 1,2,3,0,0,0 }, 3, new[] { 2,5,6 }, 3, new[] { 1,2,2,3,5,6 })]
    [InlineData(new[] { 1 },           1, new int[] { },   0, new[] { 1 })]
    [InlineData(new[] { 0 },           0, new[] { 1 },     1, new[] { 1 })]
    [InlineData(new[] { 3, 7, 11, 15, 20, 0,0,0,0,0,0,0,0 }, 5, new[] { 1,2,4,5,6,8,9,10 },8, new[] { 1,2,3,4,5,6,7,8,9,10,11,15,20 })]
    [InlineData(new[] { 1,3,5,7,9,11,13,15, 0,0,0,0,0 }, 8, new[] { 2,4,6,8,10 },5, new[] { 1,2,3,4,5,6,7,8,9,10,11,13,15 })]
    public void Merge_ShouldMergeInPlace(int[] nums1, int m, int[] nums2, int n, int[] expected)
    {
        // Act
        MergeSortedArray.Merge(nums1, m, nums2, n);

        // Assert
        nums1.Should().Equal(expected);
    }
}