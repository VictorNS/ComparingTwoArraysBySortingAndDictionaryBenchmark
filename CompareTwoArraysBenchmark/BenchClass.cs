using BenchmarkDotNet.Attributes;

namespace CompareTwoArraysBenchmark;

[MemoryDiagnoser(false)]
public class BenchClass
{
	Random _r = new();
	int[] _ar1000_0;
	int[] _ar1000_1;
	int[] _ar5000_0;
	int[] _ar5000_1;
	int[] _ar10000_0;
	int[] _ar10000_1;

	public BenchClass()
	{
		_ar1000_0 = Pupulate(1000);
		_ar1000_1 = Pupulate(1000);
		_ar5000_0 = Pupulate(5000);
		_ar5000_1 = Pupulate(5000);
		_ar10000_0 = Pupulate(10000);
		_ar10000_1 = Pupulate(10000);
	}

	public int[] Pupulate(int count)
	{
		var dic = new Dictionary<int, int>();
		var maxValue = count * 3;

		for (int i = 0; i < count; i++)
		{
			var newValue = _r.Next(maxValue);
			while (dic.ContainsKey(newValue))
				newValue = _r.Next(maxValue);
			dic.Add(newValue, 0);
		}

		return dic.Keys.ToArray();
	}

	[Benchmark]
	public void Test_CountDifferencesDictionary1000() => CountDifferencesDictionary.CountDifference(_ar1000_0, _ar1000_1);
	[Benchmark]
	public void Test_CountDifferencesHashSet1000() => CountDifferencesHashSet.CountDifference(_ar1000_0, _ar1000_1);
	[Benchmark]
	public void Test_CountDifferencesSort1000() => CountDifferencesSort.CountDifference(_ar1000_0, _ar1000_1);

	[Benchmark]
	public void Test_CountDifferencesDictionary5000() => CountDifferencesDictionary.CountDifference(_ar5000_0, _ar5000_1);
	[Benchmark]
	public void Test_CountDifferencesHashSet5000() => CountDifferencesHashSet.CountDifference(_ar5000_0, _ar5000_1);
	[Benchmark]
	public void Test_CountDifferencesSort5000() => CountDifferencesSort.CountDifference(_ar5000_0, _ar5000_1);

	[Benchmark]
	public void Test_CountDifferencesDictionary10000() => CountDifferencesDictionary.CountDifference(_ar10000_0, _ar10000_1);
	[Benchmark]
	public void Test_CountDifferencesHashSet10000() => CountDifferencesHashSet.CountDifference(_ar10000_0, _ar10000_1);
	[Benchmark]
	public void Test_CountDifferencesSort10000() => CountDifferencesSort.CountDifference(_ar10000_0, _ar10000_1);
}
