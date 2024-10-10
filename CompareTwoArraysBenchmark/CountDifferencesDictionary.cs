using System.ComponentModel.DataAnnotations;

namespace CompareTwoArraysBenchmark;

public static class CountDifferencesDictionary
{
	public static (int added, int unchanged, int deleted) CountDifference(int[] existing, int[] input)
	{
		var added = 0;
		var unchanged = 0;
		var deleted = 0;

		var exDic = new Dictionary<int, int>();
		var inDic = new Dictionary<int, int>();

		foreach (var item in existing)
			exDic.Add(item, item);
		foreach (var item in input)
			inDic.Add(item, item);

		foreach (var item in input)
		{
			var has = exDic.ContainsKey(item);

			if (has)
				unchanged++;
			else
				added++;
		}

		deleted = existing.Length - unchanged;

		return (added, unchanged, deleted);
	}
}
