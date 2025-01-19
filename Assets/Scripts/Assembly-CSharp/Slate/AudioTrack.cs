using UnityEngine;
using UnityEngine.Audio;

namespace Slate
{
	public abstract class AudioTrack : CutsceneTrack
	{
		[SerializeField]
		private AudioMixerGroup _outputMixer;

		[SerializeField]
		private float _masterVolume;

		[SerializeField]
		private float _stereoPan;

		[SerializeField]
		private float _spatialBlend;

		[SerializeField]
		private bool _ignoreTimeScale;

		public override string info
		{
			get
			{
				return null;
			}
		}

		public AudioSource source { get; private set; }

		public float weight
		{
			get
			{
				return 0f;
			}
		}

		public AudioMixerGroup mixer
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float stereoPan
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float spatialBlend
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool ignoreTimeScale
		{
			get
			{
				return false;
			}
		}

		public virtual bool useAudioSourceOnActor
		{
			get
			{
				return false;
			}
		}

		protected override void OnEnter()
		{
		}

		protected override void OnReverseEnter()
		{
		}

		protected override void OnUpdate(float time, float previousTime)
		{
		}

		protected override void OnExit()
		{
		}

		protected override void OnReverse()
		{
		}

		private void Enable()
		{
		}

		private void Disable()
		{
		}

		private void ApplySettings()
		{
		}
	}
}
