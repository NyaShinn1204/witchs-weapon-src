using UnityEngine;

namespace Slate.ActionClips
{
	public class PlayAudio : ActionClip, ISubClipContainable, IDirectable
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

		[Required]
		public AudioClip audioClip;

		[AnimatableParameter]
		public float volume;

		[AnimatableParameter]
		public float stereoPan;

		public float clipOffset;

		public string subtitlesText;

		public Color subtitlesColor;

		float ISubClipContainable.subClipOffset
		{
			get
			{
				return 0f;
			}
			set
			{
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

		private AudioTrack track
		{
			get
			{
				return null;
			}
		}

		private AudioSource source
		{
			get
			{
				return null;
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

		private void Do()
		{
		}

		protected override void OnUpdate(float time, float previousTime)
		{
		}

		private void Undo()
		{
		}
	}
}
