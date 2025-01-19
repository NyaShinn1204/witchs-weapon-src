using UnityEngine;

namespace Slate.ActionClips
{
	public class SampleParticleSystem : DirectorActionClip
	{
		[SerializeField]
		[HideInInspector]
		private float _length;

		[Required]
		public ParticleSystem particles;

		private ParticleSystem.EmissionModule em;

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

		public override float blendOut
		{
			get
			{
				return 0f;
			}
		}

		private bool loop
		{
			get
			{
				return false;
			}
		}

		private float duration
		{
			get
			{
				return 0f;
			}
		}

		private float startLifetime
		{
			get
			{
				return 0f;
			}
		}

		protected override void OnEnter()
		{
		}

		protected override void OnReverseEnter()
		{
		}

		protected override void OnExit()
		{
		}

		protected override void OnReverse()
		{
		}

		private void Play()
		{
		}

		protected override void OnUpdate(float time)
		{
		}

		private void Stop()
		{
		}
	}
}
