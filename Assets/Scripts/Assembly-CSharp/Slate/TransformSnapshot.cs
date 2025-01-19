using System.Collections.Generic;
using UnityEngine;

namespace Slate
{
	public class TransformSnapshot
	{
		public enum StoreMode
		{
			All = 0,
			RootOnly = 1,
			ChildrenOnly = 2
		}

		private struct TransformData
		{
			public Transform transform;

			public Transform parent;

			public Vector3 pos;

			public Quaternion rot;

			public Vector3 scale;

			public TransformData(Transform transform, Transform parent, Vector3 pos, Quaternion rot, Vector3 scale)
			{
				this.transform = null;
				this.parent = null;
				this.pos = default(Vector3);
				this.rot = default(Quaternion);
				this.scale = default(Vector3);
			}
		}

		private List<TransformData> data;

		public TransformSnapshot(GameObject root, StoreMode mode)
		{
		}

		public void Store(GameObject root, StoreMode mode)
		{
		}

		public void Restore()
		{
		}
	}
}
