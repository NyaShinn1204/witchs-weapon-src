using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	public class PlayAudioAtPosition : ActionTask<Transform>
	{
		[RequiredField]
		public BBParameter<AudioClip> audioClip;

		public float volume;

		public bool waitActionFinish;

		protected override string info
		{
			get
			{
				return null;
			}
		}

		protected override void OnExecute()
		{
		}

		protected override void OnUpdate()
		{
		}
	}
}
