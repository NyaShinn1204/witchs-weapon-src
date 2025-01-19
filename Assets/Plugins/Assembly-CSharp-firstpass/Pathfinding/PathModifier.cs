using System;

namespace Pathfinding
{
	[Serializable]
	public abstract class PathModifier : IPathModifier
	{
		public int priority;

		[NonSerialized]
		public Seeker seeker;

		public abstract ModifierData input { get; }

		public abstract ModifierData output { get; }

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

		public void Awake(Seeker s)
		{
		}

		public void OnDestroy(Seeker s)
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
	}
}
