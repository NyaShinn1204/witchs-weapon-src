using UnityEngine;

namespace Pathfinding
{
	public abstract class GraphModifier : MonoBehaviour
	{
		public enum EventType
		{
			PostScan = 1,
			PreScan = 2,
			LatePostScan = 4,
			PreUpdate = 8,
			PostUpdate = 0x10,
			PostCacheLoad = 0x20
		}

		private static GraphModifier root;

		private GraphModifier prev;

		private GraphModifier next;

		public static void FindAllModifiers()
		{
		}

		public static void TriggerEvent(EventType type)
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		public virtual void OnPostScan()
		{
		}

		public virtual void OnPreScan()
		{
		}

		public virtual void OnLatePostScan()
		{
		}

		public virtual void OnPostCacheLoad()
		{
		}

		public virtual void OnGraphsPreUpdate()
		{
		}

		public virtual void OnGraphsPostUpdate()
		{
		}
	}
}
