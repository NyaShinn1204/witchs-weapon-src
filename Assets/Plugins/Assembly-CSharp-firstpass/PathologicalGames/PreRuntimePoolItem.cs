using UnityEngine;

namespace PathologicalGames
{
	public class PreRuntimePoolItem : MonoBehaviour
	{
		public string poolName;

		public string prefabName;

		public bool despawnOnStart;

		public bool doNotReparent;

		private void Start()
		{
		}
	}
}
