using DataStructuresAndAlgorithms.Strings;
using FluentAssertions;

namespace DataStructuresAndAlgorithms.Tests.Strings;

public class ValidParentheses20Tests
{
    [Theory]
    [InlineData("", true)]
    [InlineData("()", true)]
    [InlineData(")(", false)]
    [InlineData("()[]{}", true)]
    [InlineData("(]", false)]
    [InlineData("([)]", false)]
    [InlineData("{[]}", true)]
    [InlineData("(", false)]
    [InlineData("]", false)]
    [InlineData("((({{{[[[]]]}}})))", true)]
    [InlineData("((({{{[[[]]]}}}))]", false)]
    [InlineData(")", false)]
    [InlineData("}", false)]
    public void IsValid_ShouldReturnExpected(string input, bool expected)
    {
        var result = ValidParentheses20.IsValid(input);

        result.Should().Be(expected);
    }
}