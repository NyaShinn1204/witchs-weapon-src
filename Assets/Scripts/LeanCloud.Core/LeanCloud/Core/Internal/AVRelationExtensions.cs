namespace LeanCloud.Core.Internal
{
	public static class AVRelationExtensions
	{
		public static AVRelation<T> Create<T>(AVObject parent, string childKey) where T : AVObject
		{
			return null;
		}

		public static AVRelation<T> Create<T>(AVObject parent, string childKey, string targetClassName) where T : AVObject
		{
			return null;
		}

		public static string GetTargetClassName<T>(this AVRelation<T> relation) where T : AVObject
		{
			return null;
		}
	}
}
