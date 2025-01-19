using System;
using System.Collections.Generic;

namespace ShaderWeaver
{
	[Serializable]
	public class SWLayerMaskString : SWLayerMask
	{
		public List<string> strs;

		public void AddKey(string key)
		{
		}

		public void RemoveKey(string key)
		{
		}

		public bool Has(string key)
		{
			return false;
		}

		public void Set(string key, bool on)
		{
		}

		public void Clear()
		{
		}
	}
}
