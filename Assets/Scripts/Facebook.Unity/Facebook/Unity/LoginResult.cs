namespace Facebook.Unity
{
	internal class LoginResult : ResultBase, ILoginResult, IResult
	{
		public static readonly string UserIdKey;

		public static readonly string ExpirationTimestampKey;

		public static readonly string PermissionsKey;

		public static readonly string AccessTokenKey;

		public AccessToken AccessToken { get; private set; }

		internal LoginResult(ResultContainer resultContainer)
			: base(null)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
