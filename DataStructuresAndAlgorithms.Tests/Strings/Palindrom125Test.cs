using DataStructuresAndAlgorithms.Strings;
using FluentAssertions;

namespace DataStructuresAndAlgorithms.Tests.Strings;

public class ValidPalindrome125Tests
{
    [Theory]
    // Examples (3 from description + 1 common LeetCode example)
    [InlineData("A man, a plan, a canal: Panama", true)]
    [InlineData("race a car", false)]
    [InlineData(" ", true)]
    [InlineData("0P", false)] // common example: after filtering => "0p" != "p0"

    // Edge cases
    [InlineData("No 'x' in Nixon", true)] // mixed case + punctuation
    [InlineData("1a2a1", true)]           // digits + letters palindrome
    public void IsPalindrome_ShouldReturnExpected(string s, bool expected)
    {
        // Act
        var result = ValidPalindrome125.IsPalindrome(s);

        // Assert
        result.Should().Be(expected);
    }
}