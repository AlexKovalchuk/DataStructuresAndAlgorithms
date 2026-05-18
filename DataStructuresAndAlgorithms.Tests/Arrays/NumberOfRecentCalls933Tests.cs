namespace DataStructuresAndAlgorithms.Tests.Arrays;

using DataStructuresAndAlgorithms.Arrays;
using FluentAssertions;

public class NumberOfRecentCalls933Tests
{
    [Fact]
    public void Ping_ShouldMatchLeetCodeExample()
    {
        var sut = new NumberOfRecentCalls_933();

        sut.Ping(1).Should().Be(1);
        sut.Ping(100).Should().Be(2);
        sut.Ping(3001).Should().Be(3);
        sut.Ping(3002).Should().Be(3);
    }

    [Fact]
    public void Ping_ShouldKeepAllCalls_WhenTheyAreInside3000MillisecondsWindow()
    {
        var sut = new NumberOfRecentCalls_933();

        sut.Ping(1).Should().Be(1);
        sut.Ping(1000).Should().Be(2);
        sut.Ping(2000).Should().Be(3);
        sut.Ping(3000).Should().Be(4);
    }

    [Fact]
    public void Ping_ShouldRemoveCalls_OlderThan3000Milliseconds()
    {
        var sut = new NumberOfRecentCalls_933();

        sut.Ping(1).Should().Be(1);
        sut.Ping(3000).Should().Be(2);
        sut.Ping(3001).Should().Be(3);
        sut.Ping(6002).Should().Be(1);
    }

    [Fact]
    public void Ping_ShouldKeepBoundaryValue_WhenCallIsExactlyTMinus3000()
    {
        var sut = new NumberOfRecentCalls_933();

        sut.Ping(1).Should().Be(1);
        sut.Ping(3001).Should().Be(2);
    }

    [Fact]
    public void Ping_ShouldWork_ForMultipleFarApartCalls()
    {
        var sut = new NumberOfRecentCalls_933();

        sut.Ping(1).Should().Be(1);
        sut.Ping(5000).Should().Be(1);
        sut.Ping(8000).Should().Be(2);
        sut.Ping(12001).Should().Be(1);
    }
}
