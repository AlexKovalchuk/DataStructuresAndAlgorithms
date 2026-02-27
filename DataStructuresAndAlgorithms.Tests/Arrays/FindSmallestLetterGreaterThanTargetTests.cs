using DataStructuresAndAlgorithms.Arrays;
using FluentAssertions;
using Xunit;

namespace DataStructuresAndAlgorithms.Tests.Arrays;

public class FindSmallestLetterGreaterThanTargetTests
{
    [Theory]

    // 📌 Example cases
    [InlineData(new[] { 'c','f','j' }, 'a', 'c')]
    [InlineData(new[] { 'c','f','j' }, 'c', 'f')]
    [InlineData(new[] { 'x','x','y','y' }, 'z', 'x')]

    // 📌 Edge case 1 — target smaller than all
    [InlineData(new[] { 'm','n','o' }, 'a', 'm')]

    // 📌 Edge case 2 — target equal to last
    [InlineData(new[] { 'a','b','c' }, 'c', 'a')]

    // 📌 Edge case 3 — all duplicates
    [InlineData(new[] { 'e','e','e','e' }, 'e', 'e')]

    // 📌 Edge case 4 — target between duplicates
    [InlineData(new[] { 'a','a','b','b','c','c' }, 'a', 'b')]

    // 📌 Edge case 5 — two letters only (minimum constraint)
    [InlineData(new[] { 'g','z' }, 'g', 'z')]

    public void NextGreatestLetter_ShouldReturnExpected(char[] letters, char target, char expected)
    {
        // Act
        var result = FindSmallestLetterGreaterThanTarget.NextGreatestLetter(letters, target);

        // Assert
        result.Should().Be(expected);
    }
}