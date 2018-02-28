using System;

namespace CSharp
{
	internal class Option<T>
	{
		private bool _hasValue;
		private string _value;

		internal Option()
		{
			_hasValue = false;
		}

		internal Option(string value)
		{
			_value = value;
			_hasValue = true;
		}

		internal string defaultValue(string defaultValue)
		{
			return _hasValue ? _value : defaultValue;
		}
	}
}