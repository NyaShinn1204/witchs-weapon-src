using System.Collections.Generic;
using UnityEngine;

namespace NodeCanvas.Framework.Internal
{
	public class VersionUpdateProxyGraph : MonoBehaviour
	{
		public string _serializedGraph;

		public List<Object> _objectReferences;

		public void GetSerializationData(out string json, out List<Object> references)
		{
			json = null;
			references = null;
		}
	}
}
