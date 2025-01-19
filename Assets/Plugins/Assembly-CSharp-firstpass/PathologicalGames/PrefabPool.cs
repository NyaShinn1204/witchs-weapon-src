using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace PathologicalGames
{
	[Serializable]
	public class PrefabPool
	{
		public Transform prefab;

		internal GameObject prefabGO;

		public int preloadAmount;

		public bool preloadTime;

		public int preloadFrames;

		public float preloadDelay;

		public bool limitInstances;

		public int limitAmount;

		public bool limitFIFO;

		public bool cullDespawned;

		public int cullAbove;

		public int cullDelay;

		public int cullMaxPerPass;

		public bool _logMessages;

		private bool forceLoggingSilent;

		public SpawnPool spawnPool;

		private bool cullingActive;

		internal List<Transform> _spawned;

		internal List<Transform> _despawned;

		private bool _preloaded;

		public bool logMessages
		{
			get
			{
				return false;
			}
		}

		public List<Transform> spawned
		{
			get
			{
				return null;
			}
		}

		public List<Transform> despawned
		{
			get
			{
				return null;
			}
		}

		public int totalCount
		{
			get
			{
				return 0;
			}
		}

		internal bool preloaded
		{
			get
			{
				return false;
			}
			private set
			{
			}
		}

		public PrefabPool(Transform prefab)
		{
		}

		public PrefabPool()
		{
		}

		internal void inspectorInstanceConstructor()
		{
		}

		internal void SelfDestruct()
		{
		}

		internal bool DespawnInstance(Transform xform)
		{
			return false;
		}

		internal bool DespawnInstance(Transform xform, bool sendEventMessage)
		{
			return false;
		}

		[DebuggerHidden]
		internal IEnumerator CullDespawned()
		{
			return null;
		}

		internal Transform SpawnInstance(Vector3 pos, Quaternion rot)
		{
			return null;
		}

		public Transform SpawnNew()
		{
			return null;
		}

		public Transform SpawnNew(Vector3 pos, Quaternion rot)
		{
			return null;
		}

		private void SetRecursively(Transform xform, int layer)
		{
		}

		internal void AddUnpooled(Transform inst, bool despawn)
		{
		}

		internal void PreloadInstances()
		{
		}

		[DebuggerHidden]
		private IEnumerator PreloadOverTime()
		{
			return null;
		}

		public bool Contains(Transform transform)
		{
			return false;
		}

		private void nameInstance(Transform instance)
		{
		}
	}
}
