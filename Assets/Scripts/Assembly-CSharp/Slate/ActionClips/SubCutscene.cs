using UnityEngine;

namespace Slate.ActionClips
{
	public class SubCutscene : DirectorActionClip
	{
		[Required]
		public Cutscene cutscene;

		private bool wasCamTrackActive;

		public override string info
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

		public override float length
		{
			get
			{
				return 0f;
			}
		}

		public new GameObject actor
		{
			get
			{
				return null;
			}
		}

		protected override void OnEnter()
		{
		}

		protected override void OnReverseEnter()
		{
		}

		protected override void OnExit()
		{
		}

		protected override void OnReverse()
		{
		}

		protected override void OnUpdate(float time)
		{
		}
	}
}
