using UnityEngine;

namespace Pathfinding
{
	public class MineBotAI : AIPath
	{
		public Animation anim;

		public float sleepVelocity;

		public float animationSpeed;

		public GameObject endOfPathEffect;

		protected Vector3 lastTarget;

		public new void Start()
		{
		}

		public override void OnTargetReached()
		{
		}

		public override Vector3 GetFeetPosition()
		{
			return default(Vector3);
		}

		protected new void Update()
		{
		}
	}
}
