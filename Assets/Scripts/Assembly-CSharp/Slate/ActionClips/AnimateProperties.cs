using UnityEngine;

namespace Slate.ActionClips
{
	public class AnimateProperties : ActionClip
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
		protected string _name;

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

		public override bool isValid
		{
			get
			{
				return false;
			}
		}

		public override string info
		{
			get
			{
				return null;
			}
		}

		public override object animatedParametersTarget
		{
			get
			{
				return null;
			}
		}

		public override bool useWeightInParameters
		{
			get
			{
				return false;
			}
		}
	}
}
