namespace Facebook.Unity
{
	internal class AccessTokenRefreshResult : ResultBase, IAccessTokenRefreshResult, IResult
	{
		public AccessToken AccessToken { get; private set; }

		public AccessTokenRefreshResult(ResultContainer resultContainer)
			: base(null)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
