``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.248)
Intel Core i7-6600U CPU 2.60GHz (Skylake), 1 CPU, 4 logical cores and 2 physical cores
Frequency=2742191 Hz, Resolution=364.6719 ns, Timer=TSC
.NET Core SDK=2.2.0-preview1-007622
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|   Method |   Max |         Mean |      Error |     StdDev |       Median |    Gen 0 |    Gen 1 |   Gen 2 |  Allocated |
|--------- |------ |-------------:|-----------:|-----------:|-------------:|---------:|---------:|--------:|-----------:|
| **DoFSharp** |    **10** |     **1.494 us** |  **0.0560 us** |  **0.1606 us** |     **1.429 us** |   **0.7496** |        **-** |       **-** |    **1.54 KB** |
| DoCSharp |    10 |     1.164 us |  0.0270 us |  0.0696 us |     1.138 us |   0.5245 |        - |       - |    1.08 KB |
| **DoFSharp** |   **100** |    **12.796 us** |  **0.2293 us** |  **0.2145 us** |    **12.783 us** |   **7.1716** |        **-** |       **-** |   **14.71 KB** |
| DoCSharp |   100 |    11.487 us |  0.2281 us |  0.2134 us |    11.411 us |   5.1270 |        - |       - |   10.51 KB |
| **DoFSharp** |  **1000** |   **140.903 us** |  **2.4491 us** |  **2.4053 us** |   **141.002 us** |  **75.9277** |   **0.2441** |       **-** |  **155.93 KB** |
| DoCSharp |  1000 |   124.636 us |  1.5742 us |  1.4725 us |   124.681 us |  55.6641 |        - |       - |  114.29 KB |
| **DoFSharp** | **10000** | **1,843.656 us** | **32.1990 us** | **30.1189 us** | **1,850.531 us** | **263.6719** | **138.6719** | **27.3438** | **1646.74 KB** |
| DoCSharp | 10000 | 1,671.483 us | 28.2928 us | 25.0808 us | 1,664.843 us | 285.1563 | 119.1406 | 27.3438 | 1230.77 KB |
