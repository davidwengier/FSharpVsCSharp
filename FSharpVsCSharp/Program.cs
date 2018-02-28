using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace FSharpVsCSharp
{
	[MemoryDiagnoser]
	public class Program
	{
		[Params(10,100,1000,10000)]
		public int Max
		{
			get;set;
		}

		[Benchmark]
		public string DoFSharp()
		{
			return FSharp.FizzBuzz.run(this.Max);
		}

		[Benchmark]
		public string DoCSharp()
		{
			return CSharp.FizzBuzz.run(this.Max);
		}

		static void Main(string[] args)
		{
			BenchmarkRunner.Run<Program>();
		}
	}
}
