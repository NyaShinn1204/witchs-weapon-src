using UnityEngine;

namespace DarkTonic.MasterAudio
{
	public class SoundGroupVariationUpdater : MonoBehaviour
	{
		private enum WaitForSoundFinishMode
		{
			None = 0,
			Delay = 1,
			Play = 2,
			WaitForEnd = 3,
			StopOrRepeat = 4,
			FxTailWait = 5
		}

		private const float FakeNegativeFloatValue = -10f;

		private Transform _objectToFollow;

		private GameObject _objectToFollowGo;

		private bool _isFollowing;

		private SoundGroupVariation _variation;

		private float _priorityLastUpdated;

		private bool _useClipAgePriority;

		private WaitForSoundFinishMode _waitMode;

		private float _soundPlayTime;

		private AudioSource _varAudio;

		private MasterAudioGroup _parentGrp;

		private Transform _trans;

		private int _frameNum;

		private float _fadeOutStartTime;

		private bool _fadeInOutWillFadeOut;

		private bool _hasFadeInOutSetMaxVolume;

		private float _fadeInOutInFactor;

		private float _fadeInOutOutFactor;

		private int _fadeOutEarlyTotalFrames;

		private float _fadeOutEarlyFrameVolChange;

		private int _fadeOutEarlyFrameNumber;

		private float _fadeOutEarlyOrigVol;

		private float _fadeToTargetFrameVolChange;

		private int _fadeToTargetFrameNumber;

		private float _fadeToTargetOrigVol;

		private int _fadeToTargetTotalFrames;

		private float _fadeToTargetVolume;

		private bool _fadeOutStarted;

		private float _lastFrameClipTime;

		private float _fxTailEndTime;

		private bool _isPlayingBackward;

		private bool _hasStartedNextInChain;

		private bool _isWaitingForQueuedOcclusionRay;

		private int _framesPlayed;

		private static int _maCachedFromFrame;

		private static MasterAudio _maThisFrame;

		private static Transform _listenerThisFrame;

		public int FramesPlayed
		{
			get
			{
				return 0;
			}
		}

		public MasterAudio MAThisFrame
		{
			get
			{
				return null;
			}
		}

		public float MaxOcclusionFreq
		{
			get
			{
				return 0f;
			}
		}

		public float MinOcclusionFreq
		{
			get
			{
				return 0f;
			}
		}

		private Transform Trans
		{
			get
			{
				return null;
			}
		}

		private AudioSource VarAudio
		{
			get
			{
				return null;
			}
		}

		private MasterAudioGroup ParentGroup
		{
			get
			{
				return null;
			}
		}

		private SoundGroupVariation GrpVariation
		{
			get
			{
				return null;
			}
		}

		private float RayCastOriginOffset
		{
			get
			{
				return 0f;
			}
		}

		private bool IsOcclusionMeasuringPaused
		{
			get
			{
				return false;
			}
		}

		public void FadeOverTimeToVolume(float targetVolume, float fadeTime)
		{
		}

		public void FadeOutEarly(float fadeTime)
		{
		}

		public void FadeInOut()
		{
		}

		public void FollowObject(bool follow, Transform objToFollow, bool clipAgePriority)
		{
		}

		public void WaitForSoundFinish(float delaySound)
		{
		}

		public void StopFading()
		{
		}

		public void StopWaitingForFinish()
		{
		}

		public void StopFollowing()
		{
		}

		private void DisableIfFinished()
		{
		}

		private void UpdateAudioLocationAndPriority(bool rePrioritize)
		{
		}

		private void ResetToNonOcclusionSetting()
		{
		}

		private void UpdateOcclusion()
		{
		}

		private void DoneWithOcclusion()
		{
		}

		public bool RayCastForOcclusion()
		{
			return false;
		}

		private void PlaySoundAndWait()
		{
		}

		private void StopOrChain()
		{
		}

		public void MaybeChain()
		{
		}

		private void PerformFading()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void UpdateCachedObjects()
		{
		}

		private void LateUpdate()
		{
		}
	}
}
