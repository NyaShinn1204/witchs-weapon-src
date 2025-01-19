namespace System.Runtime.ExceptionServices
{
	public class ExceptionDispatchInfo
	{
		public Exception SourceException { get; private set; }

		public static ExceptionDispatchInfo Capture(Exception ex)
		{
			return null;
		}

		private ExceptionDispatchInfo(Exception ex)
		{
		}

		public void Throw()
		{
		}
	}
}
