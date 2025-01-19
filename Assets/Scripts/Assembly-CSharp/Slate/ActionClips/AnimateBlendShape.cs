using UnityEngine;

namespace Slate.ActionClips
{
	public class AnimateBlendShape : ActorActionClip
	{
		[SerializeField]
		[HideInInspector]
		private float _length;

		[SerializeField]
		[HideInInspector]
		private float _blendIn;

		[SerializeField]
		[HideInInspector]
		private float _blendOut;

		[SerializeField]
		[HideInInspector]
		private string _skinName;

		[SerializeField]
		[HideInInspector]
		private string _shapeName;

		[AnimatableParameter]
		public float weight;

		private float originalWeight;

		private int index;

		private SkinnedMeshRenderer _skinnedMesh;

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

		public override float blendIn
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public override float blendOut
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public string skinName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string shapeName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private SkinnedMeshRenderer skinnedMesh
		{
			get
			{
				return null;
			}
		}

		protected override void OnEnter()
		{
		}

		protected override void OnUpdate(float deltaTime)
		{
		}

		protected override void OnReverse()
		{
		}
	}
}
