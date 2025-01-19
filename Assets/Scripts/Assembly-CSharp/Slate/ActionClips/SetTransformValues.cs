using UnityEngine;

namespace Slate.ActionClips
{
	public class SetTransformValues : ActorActionClip
	{
		public bool setPosition;

		public Vector3 position;

		public MiniTransformSpace space;

		public bool setRotation;

		public Vector3 rotation;

		public bool setScale;

		public Vector3 scale;

		private TransformSnapshot undo;

		protected override void OnEnter()
		{
		}

		protected override void OnReverse()
		{
		}
	}
}
