using System.Collections.Generic;

namespace LeanCloud.Storage.Internal
{
	public interface IJsonConvertible
	{
		IDictionary<string, object> ToJSON();
	}
}
