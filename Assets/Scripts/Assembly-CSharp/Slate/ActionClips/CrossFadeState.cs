using UnityEngine;

namespace Slate.ActionClips
{
	public class CrossFadeState : MecanimBaseClip
	{
		[SerializeField]
		[HideInInspector]
		private float _length;

		[Required]
		public string stateName;

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

		public override float blendIn
		{
			get
			{
				return 0f;
			}
		}

		protected override void OnEnter()
		{
		}
	}
}
