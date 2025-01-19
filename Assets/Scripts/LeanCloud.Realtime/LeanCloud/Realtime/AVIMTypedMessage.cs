using System.Collections;
using System.Collections.Generic;

namespace LeanCloud.Realtime
{
	public class AVIMTypedMessage : AVIMMessage, IEnumerable<KeyValuePair<string, object>>, IEnumerable
	{
		private IDictionary<string, object> estimatedData;

		public string TextContent { get; set; }

		public virtual object Item
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string Serialize()
		{
			return null;
		}

		public virtual IDictionary<string, object> Encode()
		{
			return null;
		}

		public override bool Validate(string msgStr)
		{
			return false;
		}

		public override IAVIMMessage Deserialize(string msgStr)
		{
			return null;
		}

		public void MergeCustomAttributes(IDictionary<string, object> customAttributes)
		{
		}

		public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}
