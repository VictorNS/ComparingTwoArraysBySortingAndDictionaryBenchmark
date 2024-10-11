# ComparingTwoArraysBySortingAndDictionaryBenchmark
Benchmark to test two algorithms comparing two arrays using sorting and dictionary.

The task in general sounds like comparing two arrays, find the number of added, deleted and identical elements.

We can sort the items and pass in one pass, but the sorting complexity is O(n log n).

The second approach is to put them in a dictionary and it's complexity is O(n), dictionary lookup is also O(n).
In fact, not only the dictionary but also the hashset was used, and the latter is predictably faster.

As a result of the experiment we got the following console output:
```
| Method                               | Mean       | Error     | StdDev    | Median     | Allocated |
|------------------------------------- |-----------:|----------:|----------:|-----------:|----------:|
| Test_CountDifferencesDictionary1000  |  19.640 us | 0.3361 us | 0.3144 us |  19.605 us |  146336 B |
| Test_CountDifferencesHashSet1000     |  12.530 us | 0.2488 us | 0.5301 us |  12.480 us |   35600 B |
| Test_CountDifferencesSort1000        |   6.906 us | 0.1108 us | 0.1037 us |   6.927 us |         - |
| Test_CountDifferencesDictionary5000  | 221.086 us | 4.4125 us | 6.6045 us | 220.002 us |  645292 B |
| Test_CountDifferencesHashSet5000     | 105.266 us | 2.0773 us | 3.8504 us | 103.462 us |  187152 B |
| Test_CountDifferencesSort5000        |  49.762 us | 0.9069 us | 1.4900 us |  49.507 us |         - |
| Test_CountDifferencesDictionary10000 | 554.907 us | 9.0084 us | 7.5224 us | 552.261 us | 1346212 B |
| Test_CountDifferencesHashSet10000    | 350.394 us | 1.9717 us | 1.6465 us | 350.497 us |  323626 B |
| Test_CountDifferencesSort10000       | 123.661 us | 2.4724 us | 2.3126 us | 123.837 us |         - |
```
A bit of a surprise, but the sorting is much quicker!

BTW The library [BenchmarkDotNet](https://github.com/dotnet/BenchmarkDotNet) is used.
