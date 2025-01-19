using UnityEngine;

namespace Slate.ActionClips
{
	public class SetMaterial : ActorActionClip<Renderer>
	{
		[SerializeField]
		[HideInInspector]
		private float _length;

		public Material material;

		private Material sharedMat;

		private bool temporary;

		public override string info
		{
			get
			{
				return null;
			}
		}

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

		protected override void OnReverseEnter()
		{
		}

		protected override void OnReverse()
		{
		}

		protected override void OnExit()
		{
		}

		private void DoSet()
		{
		}

		private void DoReset()
		{
		}
	}
}
