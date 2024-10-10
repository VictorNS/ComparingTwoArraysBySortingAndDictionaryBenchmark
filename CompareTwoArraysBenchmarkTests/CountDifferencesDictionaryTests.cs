using CompareTwoArraysBenchmark;
using Xunit;

namespace CompareTwoArraysBenchmarkTests;

public class CountDifferencesDictionaryTests
{
	public static IEnumerable<object[]> GetCases
	{
		get
		{
			yield return [new int[] { 1, 2 }, new int[] { 2, 1 }, 0, 2, 0];
			yield return [new int[] { 1 }, new int[] { 2 }, 1, 0, 1];
			yield return [new int[] { 1 }, new int[] { 1, 2 }, 1, 1, 0];
			yield return [new int[] { 1, 2 }, new int[] { 1 }, 0, 1, 1];
			yield return [new int[] { 1, 3 }, new int[] { 2, 4 }, 2, 0, 2];
			yield return [new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 4, 8, 11 }, 2, 1, 5];
			yield return [new int[] { 4, 2, 7, 8, 1, 9 }, new int[] { 9, 1, 8, 7, 2, 4 }, 0, 6, 0];
			yield return [new int[] { 6, 4, 5, 1, 9, 8 }, new int[] { 6, 4, 5 }, 0, 3, 3];
			yield return [new int[] { 6, 5, 4, 3, 2, 1 }, new int[] { 7, 6, 5, 4, 3, 2, 1 }, 1, 6, 0];
		}
	}

	[Theory]
	[MemberData(nameof(GetCases))]
	public static void Test(int[] existing, int[] input, int _added, int _unchanged, int _deleted)
	{
		var (added, unchanged, deleted) = CountDifferencesDictionary.CountDifference(existing, input);

		Assert.True(_added == added && _unchanged == unchanged && _deleted == deleted,
	$@"+ {_added} -> {added}
= {_unchanged} -> {unchanged}
- {_deleted} -> {deleted}");
	}
}
