using System.Collections.Generic;

namespace Facebook.Unity
{
	internal abstract class ResultBase : IInternalResult, IResult
	{
		public virtual string Error { get; protected set; }

		public virtual IDictionary<string, object> ResultDictionary { get; protected set; }

		public virtual string RawResult { get; protected set; }

		public virtual bool Cancelled { get; protected set; }

		public virtual string CallbackId { get; protected set; }

		protected long? CanvasErrorCode { get; private set; }

		internal ResultBase(ResultContainer result)
		{
		}

		internal ResultBase(ResultContainer result, string error, bool cancelled)
		{
		}

		public override string ToString()
		{
			return null;
		}

		protected void Init(ResultContainer result, string error, bool cancelled, string callbackId)
		{
		}

		private static string GetErrorValue(IDictionary<string, object> result)
		{
			return null;
		}

		private static bool GetCancelledValue(IDictionary<string, object> result)
		{
			return false;
		}

		private static string GetCallbackId(IDictionary<string, object> result)
		{
			return null;
		}
	}
}
