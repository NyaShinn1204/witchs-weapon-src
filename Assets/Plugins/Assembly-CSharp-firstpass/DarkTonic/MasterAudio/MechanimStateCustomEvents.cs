using UnityEngine;

namespace DarkTonic.MasterAudio
{
	public class MechanimStateCustomEvents : StateMachineBehaviour
	{
		[MasterCustomEvent]
		public string enterCustomEvent;

		[MasterCustomEvent]
		public string exitCustomEvent;

		public bool fireEventUsingAnimTime;

		public float whenToFireEvent;

		private bool fireTimedEvent;

		[MasterCustomEvent]
		public string timedCustomEvent;

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
	}
}
