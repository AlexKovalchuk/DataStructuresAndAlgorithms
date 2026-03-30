using DataStructuresAndAlgorithms.Arrays;
using FluentAssertions;

namespace DataStructuresAndAlgorithms.Tests.Arrays;

public class RangeSumQueryImmutable303Tests
{
    [Fact]
    public void SumRange_ShouldMatchExampleFromProblem()
    {
        var numArray = new RangeSumQueryImmutable_303(new[] { -2, 0, 3, -5, 2, -1 });

        numArray.SumRange(0, 2).Should().Be(1);
        numArray.SumRange(2, 5).Should().Be(-1);
        numArray.SumRange(0, 5).Should().Be(-3);
    }

    [Fact]
    public void SumRange_ShouldReturnElement_WhenLeftEqualsRight()
    {
        var numArray = new RangeSumQueryImmutable_303(new[] { 4, -1, 7, 0 });

        numArray.SumRange(0, 0).Should().Be(4);
        numArray.SumRange(1, 1).Should().Be(-1);
        numArray.SumRange(3, 3).Should().Be(0);
    }

    [Fact]
    public void SumRange_ShouldReturnWholeArraySum_WhenQueryCoversFullRange()
    {
        var numArray = new RangeSumQueryImmutable_303(new[] { 1, 2, 3, 4, 5 });

        numArray.SumRange(0, 4).Should().Be(15);
    }

    [Fact]
    public void SumRange_ShouldHandleNegativeAndPositiveValues()
    {
        var numArray = new RangeSumQueryImmutable_303(new[] { 5, -2, -3, 10, 1, -4 });

        numArray.SumRange(0, 3).Should().Be(10);
        numArray.SumRange(1, 4).Should().Be(6);
        numArray.SumRange(2, 5).Should().Be(4);
    }

    [Fact]
    public void SumRange_ShouldSupportMultipleQueriesOnSameInstance()
    {
        var numArray = new RangeSumQueryImmutable_303(new[] { 3, 1, 4, 1, 5, 9 });

        numArray.SumRange(0, 1).Should().Be(4);
        numArray.SumRange(1, 3).Should().Be(6);
        numArray.SumRange(3, 5).Should().Be(15);
        numArray.SumRange(0, 5).Should().Be(23);
    }
}
