using DataStructuresAndAlgorithms.Arrays;
using FluentAssertions;

namespace DataStructuresAndAlgorithms.Tests.Arrays;

public class ThreeSum15Tests
{
    public static IEnumerable<object[]> TestCases()
    {
        yield return new object[]
        {
            new[] { -1, 0, 1, 2, -1, -4 },
            new[]
            {
                new[] { -1, -1, 2 },
                new[] { -1, 0, 1 }
            }
        };

        yield return new object[]
        {
            new[] { 0, 1, 1 },
            Array.Empty<int[]>()
        };

        yield return new object[]
        {
            new[] { 0, 0, 0 },
            new[]
            {
                new[] { 0, 0, 0 }
            }
        };

        yield return new object[]
        {
            new[] { -2, 0, 0, 2, 2 },
            new[]
            {
                new[] { -2, 0, 2 }
            }
        };

        yield return new object[]
        {
            new[] { -2, 0, 1, 1, 2 },
            new[]
            {
                new[] { -2, 0, 2 },
                new[] { -2, 1, 1 }
            }
        };

        yield return new object[]
        {
            new[] { 1, -1 },
            Array.Empty<int[]>()
        };

        yield return new object[]
        {
            new[] { 1, 2, 3, 4 },
            Array.Empty<int[]>()
        };

        yield return new object[]
        {
            new[] { -4, -2, -2, -2, 0, 1, 2, 2, 3, 4 },
            new[]
            {
                new[] { -4, 0, 4 },
                new[] { -4, 1, 3 },
                new[] { -4, 2, 2 },
                new[] { -2, -2, 4 },
                new[] { -2, 0, 2 }
            }
        };
    }

    [Theory]
    [MemberData(nameof(TestCases))]
    public void ThreeSum_ShouldReturnExpectedTriplets(int[] nums, int[][] expected)
    {
        var sut = new ThreeSum_15();

        var result = Normalize(sut.ThreeSum(nums));

        result.Should().BeEquivalentTo(Normalize(expected), options => options.WithStrictOrdering());
    }

    private static List<List<int>> Normalize(IEnumerable<IList<int>> triplets)
    {
        return triplets
            .Select(triplet => triplet.OrderBy(x => x).ToList())
            .OrderBy(triplet => triplet[0])
            .ThenBy(triplet => triplet[1])
            .ThenBy(triplet => triplet[2])
            .ToList();
    }

    private static List<List<int>> Normalize(IEnumerable<int[]> triplets)
    {
        return triplets
            .Select(triplet => triplet.OrderBy(x => x).ToList())
            .OrderBy(triplet => triplet[0])
            .ThenBy(triplet => triplet[1])
            .ThenBy(triplet => triplet[2])
            .ToList();
    }
}
