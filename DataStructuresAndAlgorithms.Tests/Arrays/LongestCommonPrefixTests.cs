using DataStructuresAndAlgorithms.arrays;
using FluentAssertions;

namespace DataStructuresAndAlgorithms.Tests.Arrays;

public class LongestCommonPrefixTests
{
    [Theory]
    [InlineData(new[] { "flower", "flow", "flight" }, "fl")]
    [InlineData(new[] { "dog", "racecar", "car" }, "")]
    [InlineData(new[] { "test", "test", "test" }, "test")]
    [InlineData(new[] { "alone" }, "alone")]
    [InlineData(new string[] { }, "")]
    [InlineData(new[] { "interview", "internet", "internal", "into" }, "int")]
    [InlineData(new[] { "", "b", "c" }, "")]
    [InlineData(new[] { "Case", "casing" }, "")]
    [InlineData(new[] { "a", "ab", "ac" }, "a")]
    [InlineData(new[] { "abcdef", "abcxyz", "abc123" }, "abc")]

    public void FindLongestCommonPrefix_ShouldReturnExpected(string[] input, string expected)
    {
        var result = LongestCommonPrefix.FindLongestCommonPrefixSeniorOptimization(input);

        result.Should().Be(expected);
    }
}