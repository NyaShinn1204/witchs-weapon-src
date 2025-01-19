using UnityEngine;

namespace Slate.ActionClips
{
	public class SimpleGrounder : ActorActionClip
	{
		[SerializeField]
		[HideInInspector]
		private float _length;

		public float maxCheckDistance;

		public float offset;

		private RaycastHit hit;

		private Vector3 lastPos;

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

		protected override void OnEnter()
		{
		}

		protected override void OnUpdate(float time)
		{
		}

		protected override void OnReverse()
		{
		}
	}
}
