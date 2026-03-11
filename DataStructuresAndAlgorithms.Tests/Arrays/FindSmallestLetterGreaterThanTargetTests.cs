using DataStructuresAndAlgorithms.Arrays;
using FluentAssertions;
using Xunit;

namespace DataStructuresAndAlgorithms.Tests.Arrays;

public class FindSmallestLetterGreaterThanTargetTests
{
    [Theory]
    [InlineData(new[] { 'c','f','j' }, 'a', 'c')]
    [InlineData(new[] { 'c','f','j' }, 'c', 'f')]
    [InlineData(new[] { 'x','x','y','y' }, 'z', 'x')]
    [InlineData(new[] { 'm','n','o' }, 'a', 'm')]
    [InlineData(new[] { 'a','b','c' }, 'c', 'a')]
    [InlineData(new[] { 'e','e','e','e' }, 'e', 'e')]
    [InlineData(new[] { 'a','a','b','b','c','c' }, 'a', 'b')]
    [InlineData(new[] { 'g','z' }, 'g', 'z')]

    public void NextGreatestLetter_ShouldReturnExpected(char[] letters, char target, char expected)
    {
        // Act
        var result = FindSmallestLetterGreaterThanTarget.NextGreatestLetter(letters, target);

        // Assert
        result.Should().Be(expected);
    }
}