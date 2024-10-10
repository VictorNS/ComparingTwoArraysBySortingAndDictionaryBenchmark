namespace CompareTwoArraysBenchmark;

public static class CountDifferencesSort
{
	public static (int added, int unchanged, int deleted) CountDifference(int[] existing, int[] input)
	{
		var exLength = existing.Length;
		var inLength = input.Length;
		Array.Sort(existing);
		Array.Sort(input);
		var added = 0;
		var unchanged = 0;
		var deleted = 0;

		var exIndex = 0;
		var inIndex = 0;

		while (exIndex < exLength && inIndex < inLength)
		{
			if (existing[exIndex] == input[inIndex])
			{
				unchanged++;
				exIndex++;
				inIndex++;
			}
			else if (existing[exIndex] > input[inIndex])
			{
				while (inIndex < inLength && existing[exIndex] > input[inIndex])
				{
					added++;
					inIndex++;
				}
			}
			else if (existing[exIndex] < input[inIndex])
			{
				while (exIndex < exLength && existing[exIndex] < input[inIndex])
				{
					deleted++;
					exIndex++;
				}
			}
		}

		if (exIndex < exLength)
			deleted += exLength - exIndex;
		if (inIndex < inLength)
			added += inLength - inIndex;

		return (added, unchanged, deleted);
	}
}
