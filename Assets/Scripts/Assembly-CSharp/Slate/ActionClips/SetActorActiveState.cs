using UnityEngine;

namespace Slate.ActionClips
{
	public class SetActorActiveState : ActorActionClip
	{
		[SerializeField]
		[HideInInspector]
		private float _length;

		public ActiveState activeState;

		private bool lastState;

		private bool currentState;

		private bool temporary;

		public override float length
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

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

		protected override void OnExit()
		{
		}

		protected override void OnReverseEnter()
		{
		}

		protected override void OnReverse()
		{
		}
	}
}
