using System.Collections.Generic;
using UnityEngine;

namespace Slate
{
	public class ObjectSnapshot
	{
		private Dictionary<Object, string> serialized;

		public ObjectSnapshot(Object target, bool fullObjectHierarchy = false)
		{
		}

		public void Store(Object target, bool fullObjectHierarchy = false)
		{
		}

		public void Restore()
		{
		}
	}
}
