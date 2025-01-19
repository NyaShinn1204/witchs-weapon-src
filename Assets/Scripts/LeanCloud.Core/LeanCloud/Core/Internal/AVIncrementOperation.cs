using System;
using System.Collections.Generic;

namespace LeanCloud.Core.Internal
{
	public class AVIncrementOperation : IAVFieldOperation
	{
		private static readonly IDictionary<Tuple<Type, Type>, Func<object, object, object>> adders;

		private object amount;

		public object Amount
		{
			get
			{
				return null;
			}
		}

		static AVIncrementOperation()
		{
		}

		public AVIncrementOperation(object amount)
		{
		}

		public object Encode()
		{
			return null;
		}

		private static object Add(object obj1, object obj2)
		{
			return null;
		}

		public IAVFieldOperation MergeWithPrevious(IAVFieldOperation previous)
		{
			return null;
		}

		public object Apply(object oldValue, string key)
		{
			return null;
		}
	}
}
