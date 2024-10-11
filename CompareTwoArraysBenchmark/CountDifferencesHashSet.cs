namespace CompareTwoArraysBenchmark;

public static class CountDifferencesHashSet
{
	public static (int added, int unchanged, int deleted) CountDifference(int[] existing, int[] input)
	{
		var added = 0;
		var unchanged = 0;
		var deleted = 0;

		var exDic = new HashSet<int>(existing);
		var inDic = new HashSet<int>(input);

		foreach (var item in input)
		{
			var has = exDic.Contains(item);

			if (has)
				unchanged++;
			else
				added++;
		}

		deleted = existing.Length - unchanged;

		return (added, unchanged, deleted);
	}
}
