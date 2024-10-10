# ComparingTwoArraysBySortingAndDictionaryBenchmark
Benchmark to test two algorithms comparing two arrays using sorting and dictionary.

The task in general sounds like comparing two arrays, find the number of added, deleted and identical elements.

We can sort the items and pass in one pass, but the sorting complexity is O(n log n).

The second approach is to put them in a dictionary and it's complexity is O(n), dictionary lookup is also O(n).

As a result of the experiment we got the following console output:
```
| Method                              | Mean       | Error     | StdDev    | Allocated |
|------------------------------------ |-----------:|----------:|----------:|----------:|
| Test_CountDifferencesDictionary1000 |  20.632 us | 0.2454 us | 0.2295 us |  146336 B |
| Test_CountDifferencesDictionary5000 | 251.306 us | 4.2808 us | 6.4073 us |  645292 B |
| Test_CountDifferencesSort1000       |   7.226 us | 0.1394 us | 0.1432 us |         - |
| Test_CountDifferencesSort5000       |  52.181 us | 1.0261 us | 1.0078 us |         - |
```
A bit of a surprise, but the sorting is much quicker!

BTW The library [BenchmarkDotNet](https://github.com/dotnet/BenchmarkDotNet) is used.
