using UnityEngine.Events;

namespace Slate.ActionClips
{
	public class RaiseUnityEvent : DirectorActionClip
	{
		public string customLabel;

		public UnityEvent forwardEvent;

		public UnityEvent reverseEvent;

		public override string info
		{
			get
			{
				return null;
			}
		}

		protected override void OnEnter()
		{
		}

		protected override void OnReverse()
		{
		}
	}
}
