using System;
using System.Collections.Generic;

namespace CSharp
{
	public class FizzBuzz
	{
		private static Option<string> @is(int divisor, string outputString, int i, Option<string> result)
		{
			if (i % divisor == 0)
			{
				return new Option<string>(result.defaultValue("") + outputString);
			}
			else
			{
				return result;
			}
		}

		private static Option<string> fizz(int i, Option<string> result) => @is(3, "fizz", i, result);

		private static Option<string> buzz(int i, Option<string> result) => @is(5, "buzz", i, result);

		private static Option<string> bang(int i, Option<string> result) => @is(7, "bang", i, result);

		private static string fizzBuzzChecks(int i)
		{
			Option<string> result = new Option<string>();
			result = fizz(i, result);
			result = buzz(i, result);
			result = bang(i, result);
			return result.defaultValue(i.ToString());
		}

		public static IEnumerable<string> fizzBuzz(int max)
		{
			List<string> results = new List<string>(max);
			for (int i = 1; i <= max; i++)
			{
				results.Add(fizzBuzzChecks(i));
			}
			return results;
		}

		public static string run(int max)
		{
			return string.Concat(fizzBuzz(max));
		}
	}
}