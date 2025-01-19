using UnityEngine;

namespace Slate.ActionClips
{
	public abstract class ActorActionClip : ActionClip
	{
	}
	public abstract class ActorActionClip<T> : ActionClip where T : Component
	{
		private T _actorComponent;

		public new T actor
		{
			get
			{
				return null;
			}
		}

		public override bool isValid
		{
			get
			{
				return false;
			}
		}
	}
}
