using UnityEngine;

namespace Slate.ActionClips
{
	public class SetMaterialTexture : ActorActionClip<Renderer>
	{
		[SerializeField]
		[HideInInspector]
		private float _length;

		[ShaderPropertyPopup]
		public string propertyName;

		public Texture texture;

		private Material sharedMat;

		private Material instanceMat;

		private bool temporary;

		public override string info
		{
			get
			{
				return null;
			}
		}

		public override bool isValid
		{
			get
			{
				return false;
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
