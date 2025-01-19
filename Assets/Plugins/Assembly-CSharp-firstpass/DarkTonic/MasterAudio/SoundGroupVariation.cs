using System.Runtime.InteropServices;
using UnityEngine;

namespace DarkTonic.MasterAudio
{
	public class SoundGroupVariation : MonoBehaviour
	{
		[StructLayout(LayoutKind.Auto, Size = 8)]
		public delegate void SoundFinishedEventHandler();

		public class PlaySoundParams
		{
			public string SoundType;

			public float VolumePercentage;

			public float? Pitch;

			public Transform SourceTrans;

			public bool AttachToSource;

			public float DelaySoundTime;

			public bool IsChainLoop;

			public bool IsSingleSubscribedPlay;

			public float GroupCalcVolume;

			public bool IsPlaying;

			public PlaySoundParams(string soundType, float volPercent, float groupCalcVolume, float? pitch, Transform sourceTrans, bool attach, float delaySoundTime, bool isChainLoop, bool isSingleSubscribedPlay)
			{
			}
		}

		public enum FadeMode
		{
			None = 0,
			FadeInOut = 1,
			FadeOutEarly = 2,
			GradualFade = 3
		}

		public enum RandomPitchMode
		{
			AddToClipPitch = 0,
			IgnoreClipPitch = 1
		}

		public enum RandomVolumeMode
		{
			AddToClipVolume = 0,
			IgnoreClipVolume = 1
		}

		public enum DetectEndMode
		{
			None = 0,
			DetectEnd = 1
		}

		public int weight;

		public int probabilityToPlay;

		public bool useLocalization;

		public bool useRandomPitch;

		public RandomPitchMode randomPitchMode;

		public float randomPitchMin;

		public float randomPitchMax;

		public bool useRandomVolume;

		public RandomVolumeMode randomVolumeMode;

		public float randomVolumeMin;

		public float randomVolumeMax;

		public MasterAudio.AudioLocation audLocation;

		public string resourceFileName;

		public string internetFileUrl;

		public MasterAudio.InternetFileLoadStatus internetFileLoadStatus;

		public float fxTailTime;

		public float original_pitch;

		public float original_volume;

		public bool isExpanded;

		public bool isChecked;

		public bool useFades;

		public float fadeInTime;

		public float fadeOutTime;

		public bool useRandomStartTime;

		public float randomStartMinPercent;

		public float randomStartMaxPercent;

		public bool useIntroSilence;

		public float introSilenceMin;

		public float introSilenceMax;

		public float fadeMaxVolume;

		public FadeMode curFadeMode;

		public DetectEndMode curDetectEndMode;

		public int frames;

		private AudioSource _audioSource;

		private readonly PlaySoundParams _playSndParam;

		private AudioDistortionFilter _distFilter;

		private AudioEchoFilter _echoFilter;

		private AudioHighPassFilter _hpFilter;

		private AudioLowPassFilter _lpFilter;

		private AudioReverbFilter _reverbFilter;

		private AudioChorusFilter _chorusFilter;

		private bool _isWaitingForDelay;

		private float _maxVol;

		private int _instanceId;

		private bool? _audioLoops;

		private SoundGroupVariationUpdater _varUpdater;

		private int _previousSoundFinishedFrame;

		private string _soundGroupName;

		private Transform _trans;

		private GameObject _go;

		private Transform _objectToFollow;

		private Transform _objectToTriggerFrom;

		private MasterAudioGroup _parentGroupScript;

		private bool _attachToSource;

		private string _resFileName;

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
			set
			{
			}
		}

		public AudioHighPassFilter HighPassFilter
		{
			get
			{
				return null;
			}
		}

		public Transform ObjectToFollow
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Transform ObjectToTriggerFrom
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool HasActiveFXFilter
		{
			get
			{
				return false;
			}
		}

		public MasterAudioGroup ParentGroup
		{
			get
			{
				return null;
			}
		}

		public float OriginalPitch
		{
			get
			{
				return 0f;
			}
		}

		public float OriginalVolume
		{
			get
			{
				return 0f;
			}
		}

		public string SoundGroupName
		{
			get
			{
				return null;
			}
		}

		public bool IsAvailableToPlay
		{
			get
			{
				return false;
			}
		}

		public float LastTimePlayed { get; set; }

		public int InstanceId
		{
			get
			{
				return 0;
			}
		}

		public Transform Trans
		{
			get
			{
				return null;
			}
		}

		public GameObject GameObj
		{
			get
			{
				return null;
			}
		}

		public AudioSource VarAudio
		{
			get
			{
				return null;
			}
		}

		public bool AudioLoops
		{
			get
			{
				return false;
			}
		}

		public string ResFileName
		{
			get
			{
				return null;
			}
		}

		public SoundGroupVariationUpdater VariationUpdater
		{
			get
			{
				return null;
			}
		}

		public bool IsWaitingForDelay
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public PlaySoundParams PlaySoundParm
		{
			get
			{
				return null;
			}
		}

		public bool IsPlaying
		{
			get
			{
				return false;
			}
		}

		public float SetGroupVolume
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		private bool Is2D
		{
			get
			{
				return false;
			}
		}

		private bool ShouldLoadAsync
		{
			get
			{
				return false;
			}
		}

		public bool UsesOcclusion
		{
			get
			{
				return false;
			}
		}

		public event SoundFinishedEventHandler SoundFinished
		{
			add
			{
			}
			remove
			{
			}
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void SetMixerGroup()
		{
		}

		public void SetSpatialBlend()
		{
		}

		public void LoadInternetFile()
		{
		}

		private void SetOcclusion()
		{
		}

		private void SetPriority()
		{
		}

		public void DisableUpdater()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnDisable()
		{
		}

		private void StopSoundEarly()
		{
		}

		private void OnDrawGizmos()
		{
		}

		public void Play(float? pitch, float maxVolume, string gameObjectName, float volPercent, float targetVol, float? targetPitch, Transform sourceTrans, bool attach, float delayTime, bool isChaining, bool isSingleSubscribedPlay)
		{
		}

		public void SetPlaySoundParams(string gameObjectName, float volPercent, float targetVol, float? targetPitch, Transform sourceTrans, bool attach, float delayTime, bool isChaining, bool isSingleSubscribedPlay)
		{
		}

		private void InternetFileFailedToLoad()
		{
		}

		private void InternetFileLoaded()
		{
		}

		private void ResourceFailedToLoad()
		{
		}

		private void FinishSetupToPlay()
		{
		}

		public void JumpToTime(float timeToJumpTo)
		{
		}

		public void AdjustVolume(float volumePercentage)
		{
		}

		public void Pause()
		{
		}

		public void DoNextChain(float volumePercentage, float? pitch, Transform transActor, bool attach)
		{
		}

		private void EnableUpdater(bool waitForSoundFinish = true)
		{
		}

		private void MaybeUnloadClip()
		{
		}

		private void PlayEndLinkedGroups()
		{
		}

		private void PlayEndLinkedGroup(string sType)
		{
		}

		public void Stop(bool stopEndDetection = false, bool skipLinked = false)
		{
		}

		public void FadeToVolume(float newVolume, float fadeTime)
		{
		}

		public void FadeOutNow()
		{
		}

		public void FadeOutNow(float fadeTime)
		{
		}

		public bool WasTriggeredFromTransform(Transform trans)
		{
			return false;
		}

		public void UpdateTransformTracker(Transform sourceTrans)
		{
		}

		public void ClearSubscribers()
		{
		}
	}
}
