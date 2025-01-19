using System.Collections.Generic;

namespace LeanCloud.Realtime
{
	public interface IAVIMNotice
	{
		AVIMNotice Restore(IDictionary<string, object> estimatedData);
	}
}
