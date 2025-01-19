using System.Collections.Generic;
using UnityEngine;

namespace Slate.ActionClips
{
	public class SetBehavioursActiveState : ActorActionClip
	{
		[SerializeField]
		[HideInInspector]
		private float _length;

		[HideInInspector]
		public List<string> behaviourNames;

		public ActiveState activeState;

		private Dictionary<Behaviour, bool> originalStates;

		private Dictionary<Behaviour, bool> currentStates;

		private bool temporary;

		public override string info
		{
			get
			{
				return null;
			}
		}

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
