using UnityEngine;

namespace Slate
{
	public class MecanimTrack : CutsceneTrack
	{
		private Animator animator;

		private AnimatorDispatcher _dispatcher;

		public AnimatorDispatcher dispatcher
		{
			get
			{
				return null;
			}
		}

		protected override bool OnInitialize()
		{
			return false;
		}

		protected override void OnReverse()
		{
		}

		protected override void OnExit()
		{
		}

		private void DestroyDispatcher()
		{
		}
	}
}
