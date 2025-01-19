namespace TwitterKit.Unity
{
	public class ApiError
	{
		public int code { get; private set; }

		public string message { get; private set; }

		internal ApiError(int code, string message)
		{
		}

		internal static ApiError Deserialize(string error)
		{
			return null;
		}
	}
}
