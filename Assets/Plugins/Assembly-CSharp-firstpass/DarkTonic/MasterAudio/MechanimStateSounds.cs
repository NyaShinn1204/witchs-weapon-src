using UnityEngine;

namespace DarkTonic.MasterAudio
{
	public class MechanimStateSounds : StateMachineBehaviour
	{
		public bool SoundFollowsObject;

		public bool playEnterSound;

		public bool stopEnterSoundOnExit;

		[SoundGroup]
		public string enterSoundGroup;

		public string enterVariationName;

		private bool wasEnterSoundPlayed;

		public bool playExitSound;

		[SoundGroup]
		public string exitSoundGroup;

		public string exitVariationName;

		public bool playAnimTimeSound;

		public bool stopAnimTimeSoundOnExit;

		public bool useStopTime;

		public float whenToStartSound;

		public float whenToStopSound;

		[SoundGroup]
		public string TimedSoundGroup;

		public string timedVariationName;

		private bool playSoundStart;

		private bool playSoundStop;

		public bool playMultiAnimTimeSounds;

		public bool StopMultiAnimTimeSoundsOnExit;

		public int numOfMultiSoundsToPlay;

		public float whenToStartMultiSound1;

		public float whenToStartMultiSound2;

		public float whenToStartMultiSound3;

		public float whenToStartMultiSound4;

		[SoundGroup]
		public string MultiSoundsTimedGroup;

		public string multiTimedVariationName;

		private bool playMultiSound1;

		private bool playMultiSound2;

		private bool playMultiSound3;

		private bool playMultiSound4;

		private Transform _actorTrans;

		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		private Transform ActorTrans(Animator anim)
		{
			return null;
		}

		private static string GetVariationName(string varName)
		{
			return null;
		}
	}
}
