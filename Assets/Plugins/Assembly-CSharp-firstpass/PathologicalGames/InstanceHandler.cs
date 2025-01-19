using System.Runtime.InteropServices;
using UnityEngine;

namespace PathologicalGames
{
	public static class InstanceHandler
	{
		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate GameObject InstantiateDelegate(GameObject prefab, Vector3 pos, Quaternion rot);

		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void DestroyDelegate(GameObject instance);

		public static InstantiateDelegate InstantiateDelegates;

		public static DestroyDelegate DestroyDelegates;

		internal static GameObject InstantiatePrefab(GameObject prefab, Vector3 pos, Quaternion rot)
		{
			return null;
		}

		internal static void DestroyInstance(GameObject instance)
		{
		}
	}
}
