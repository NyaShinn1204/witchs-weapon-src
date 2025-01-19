using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace System
{
	public class AggregateException : Exception
	{
		public ReadOnlyCollection<Exception> InnerExceptions { get; private set; }

		public AggregateException(IEnumerable<Exception> innerExceptions)
		{
		}

		public AggregateException Flatten()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
