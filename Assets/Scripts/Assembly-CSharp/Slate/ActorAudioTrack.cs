using UnityEngine;

namespace Slate
{
	public class ActorAudioTrack : AudioTrack
	{
		[SerializeField]
		protected bool _useAudioSourceOnActor;

		public override bool useAudioSourceOnActor
		{
			get
			{
				return false;
			}
		}
	}
}
