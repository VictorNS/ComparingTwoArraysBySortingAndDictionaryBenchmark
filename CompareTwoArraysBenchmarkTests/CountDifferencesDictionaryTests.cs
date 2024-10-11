using CompareTwoArraysBenchmark;
using Xunit;

namespace CompareTwoArraysBenchmarkTests;

public class CountDifferencesDictionaryTests
{
	[Theory]
	[InlineData(new int[] { 1 }, new int[] { 2 }, 1, 0, 1)]
	[InlineData(new int[] { 1, 2 }, new int[] { 2, 1 }, 0, 2, 0)]
	[InlineData(new int[] { 1 }, new int[] { 1, 2 }, 1, 1, 0)]
	[InlineData(new int[] { 1, 2 }, new int[] { 1 }, 0, 1, 1)]
	[InlineData(new int[] { 1, 3 }, new int[] { 2, 4 }, 2, 0, 2)]
	[InlineData(new int[] { 1, 2, 4, 5, 7, 8 }, new int[] { 2, 3, 4, 6 }, 2, 2, 4)]
	public static void Test(int[] existing, int[] input, int _added, int _unchanged, int _deleted)
	{
		var (added, unchanged, deleted) = CountDifferencesDictionary.CountDifference(existing, input);

		Assert.True(_added == added && _unchanged == unchanged && _deleted == deleted,
	$@"+ {_added} -> {added}
= {_unchanged} -> {unchanged}
- {_deleted} -> {deleted}");
	}
}
