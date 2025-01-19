using System;
using UnityEngine;

namespace Pathfinding
{
	[Serializable]
	public abstract class MonoModifier : MonoBehaviour, IPathModifier
	{
		[NonSerialized]
		public Seeker seeker;

		public int priority;

		public int Priority
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public abstract ModifierData input { get; }

		public abstract ModifierData output { get; }

		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		public void Awake()
		{
		}

		public void OnDestroy()
		{
		}

		[Obsolete]
		public virtual void ApplyOriginal(Path p)
		{
		}

		public abstract void Apply(Path p, ModifierData source);

		[Obsolete]
		public virtual void PreProcess(Path p)
		{
		}

		[Obsolete]
		public virtual Vector3[] Apply(GraphNode[] path, Vector3 start, Vector3 end, int startIndex, int endIndex, NavGraph graph)
		{
			return null;
		}

		[Obsolete]
		public virtual Vector3[] Apply(Vector3[] path, Vector3 start, Vector3 end)
		{
			return null;
		}
	}
}
