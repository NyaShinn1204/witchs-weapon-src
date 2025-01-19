using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions
{
	public class CheckCollision : ConditionTask<Collider>
	{
		public CollisionTypes checkType;

		public bool specifiedTagOnly;

		[TagField]
		public string objectTag;

		[BlackboardOnly]
		public BBParameter<GameObject> saveGameObjectAs;

		[BlackboardOnly]
		public BBParameter<Vector3> saveContactPoint;

		[BlackboardOnly]
		public BBParameter<Vector3> saveContactNormal;

		private bool stay;

		protected override string info
		{
			get
			{
				return null;
			}
		}

		protected override bool OnCheck()
		{
			return false;
		}

		public void OnCollisionEnter(Collision info)
		{
		}

		public void OnCollisionExit(Collision info)
		{
		}
	}
}
