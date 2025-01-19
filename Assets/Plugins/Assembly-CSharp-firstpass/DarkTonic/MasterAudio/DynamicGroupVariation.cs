using UnityEngine;

namespace DarkTonic.MasterAudio
{
	public class DynamicGroupVariation : MonoBehaviour
	{
		public int probabilityToPlay;

		public bool useLocalization;

		public bool useRandomPitch;

		public SoundGroupVariation.RandomPitchMode randomPitchMode;

		public float randomPitchMin;

		public float randomPitchMax;

		public bool useRandomVolume;

		public SoundGroupVariation.RandomVolumeMode randomVolumeMode;

		public float randomVolumeMin;

		public float randomVolumeMax;

		public int weight;

		public MasterAudio.AudioLocation audLocation;

		public string resourceFileName;

		public string internetFileUrl;

		public bool isExpanded;

		public bool isChecked;

		public float fxTailTime;

		public bool useFades;

		public float fadeInTime;

		public float fadeOutTime;

		public bool useIntroSilence;

		public float introSilenceMin;

		public float introSilenceMax;

		public bool useRandomStartTime;

		public float randomStartMinPercent;

		public float randomStartMaxPercent;

		private AudioDistortionFilter _distFilter;

		private AudioEchoFilter _echoFilter;

		private AudioHighPassFilter _hpFilter;

		private AudioLowPassFilter _lpFilter;

		private AudioReverbFilter _reverbFilter;

		private AudioChorusFilter _chorusFilter;

		private DynamicSoundGroup _parentGroupScript;

		private Transform _trans;

		private AudioSource _aud;

		public AudioDistortionFilter DistortionFilter
		{
			get
			{
				return null;
			}
		}

		public AudioReverbFilter ReverbFilter
		{
			get
			{
				return null;
			}
		}

		public AudioChorusFilter ChorusFilter
		{
			get
			{
				return null;
			}
		}

		public AudioEchoFilter EchoFilter
		{
			get
			{
				return null;
			}
		}

		public AudioLowPassFilter LowPassFilter
		{
			get
			{
				return null;
			}
		}

		public AudioHighPassFilter HighPassFilter
		{
			get
			{
				return null;
			}
		}

		public DynamicSoundGroup ParentGroup
		{
			get
			{
				return null;
			}
		}

		public Transform Trans
		{
			get
			{
				return null;
			}
		}

		public bool HasActiveFXFilter
		{
			get
			{
				return false;
			}
		}

		public AudioSource VarAudio
		{
			get
			{
				return null;
			}
		}
	}
}
