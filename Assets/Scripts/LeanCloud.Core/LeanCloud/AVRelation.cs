namespace LeanCloud
{
	public sealed class AVRelation<T> : AVRelationBase where T : AVObject
	{
		public AVQuery<T> Query
		{
			get
			{
				return null;
			}
		}

		internal AVRelation(AVObject parent, string key)
			: base(null, null)
		{
		}

		internal AVRelation(AVObject parent, string key, string targetClassName)
			: base(null, null)
		{
		}

		public void Add(T obj)
		{
		}

		public void Remove(T obj)
		{
		}
	}
}
