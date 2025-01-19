using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	public class MecanimSetIK : ActionTask<Animator>
	{
		public AvatarIKGoal IKGoal;

		[RequiredField]
		public BBParameter<GameObject> goal;

		public BBParameter<float> weight;

		protected override string info
		{
			get
			{
				return null;
			}
		}

		public void OnAnimatorIK()
		{
		}
	}
}
