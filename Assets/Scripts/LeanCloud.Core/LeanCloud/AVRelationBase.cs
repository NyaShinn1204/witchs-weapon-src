using System.Collections.Generic;
using System.ComponentModel;
using LeanCloud.Core.Internal;
using LeanCloud.Storage.Internal;

namespace LeanCloud
{
	[EditorBrowsable]
	public abstract class AVRelationBase : IJsonConvertible
	{
		private AVObject parent;

		private string key;

		private string targetClassName;

		internal static IObjectSubclassingController SubclassingController
		{
			get
			{
				return null;
			}
		}

		internal string TargetClassName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal AVRelationBase(AVObject parent, string key)
		{
		}

		internal AVRelationBase(AVObject parent, string key, string targetClassName)
		{
		}

		internal void EnsureParentAndKey(AVObject parent, string key)
		{
		}

		internal void Add(AVObject obj)
		{
		}

		internal void Remove(AVObject obj)
		{
		}

		IDictionary<string, object> IJsonConvertible.ToJSON()
		{
			return null;
		}

		internal AVQuery<T> GetQuery<T>() where T : AVObject
		{
			return null;
		}

		internal AVQuery<T> GetReverseQuery<T>(T target) where T : AVObject
		{
			return null;
		}

		internal static AVRelationBase CreateRelation(AVObject parent, string key, string targetClassName)
		{
			return null;
		}

		private static AVRelation<T> CreateRelation<T>(AVObject parent, string key, string targetClassName) where T : AVObject
		{
			return null;
		}
	}
}
