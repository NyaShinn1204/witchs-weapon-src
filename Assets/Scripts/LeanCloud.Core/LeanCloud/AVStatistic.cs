using System.Collections.Generic;

namespace LeanCloud
{
	public class AVStatistic
	{
		public string Name { get; private set; }

		public double Value { get; private set; }

		public int Version { get; internal set; }

		public AVStatistic(string name, double value)
		{
		}

		private AVStatistic()
		{
		}

		internal static AVStatistic Parse(IDictionary<string, object> data)
		{
			return null;
		}
	}
}
