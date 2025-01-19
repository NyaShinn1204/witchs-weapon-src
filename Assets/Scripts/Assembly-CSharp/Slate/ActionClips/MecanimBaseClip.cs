using UnityEngine;

namespace Slate.ActionClips
{
	public abstract class MecanimBaseClip : ActorActionClip<Animator>
	{
		public override bool isValid
		{
			get
			{
				return false;
			}
		}

		protected bool HasParameter(string name)
		{
			return false;
		}
	}
}
