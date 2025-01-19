using System;
using System.Collections;
using System.Collections.Generic;

namespace LeanCloud.Core.Internal
{
	public interface IObjectState : IEnumerable<KeyValuePair<string, object>>, IEnumerable
	{
		bool IsNew { get; }

		string ClassName { get; }

		string ObjectId { get; }

		DateTime? UpdatedAt { get; }

		DateTime? CreatedAt { get; }

		object Item { get; }

		bool ContainsKey(string key);

		IObjectState MutatedClone(Action<MutableObjectState> func);
	}
}
