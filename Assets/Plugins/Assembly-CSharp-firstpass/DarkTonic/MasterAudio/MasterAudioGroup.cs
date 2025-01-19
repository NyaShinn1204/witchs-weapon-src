using System;
using System.Collections.Generic;
using UnityEngine;

namespace DarkTonic.MasterAudio
{
	public class MasterAudioGroup : MonoBehaviour
	{
		public enum TargetDespawnedBehavior
		{
			None = 0,
			Stop = 1,
			FadeOut = 2
		}

		public enum VariationSequence
		{
			Randomized = 0,
			TopToBottom = 1
		}

		public enum VariationMode
		{
			Normal = 0,
			LoopedChain = 1,
			Dialog = 2
		}

		public enum ChainedLoopLoopMode
		{
			Endless = 0,
			NumberOfLoops = 1
		}

		public enum LimitMode
		{
			None = 0,
			FrameBased = 1,
			TimeBased = 2
		}

		public const float UseCurveSpatialBlend = -99f;

		public const string NoBus = "[NO BUS]";

		public const int MinNoRepeatVariations = 3;

		public int busIndex;

		public MasterAudio.ItemSpatialBlendType spatialBlendType;

		public float spatialBlend;

		public bool isSelected;

		public bool isExpanded;

		public float groupMasterVolume;

		public int retriggerPercentage;

		public VariationMode curVariationMode;

		public bool alwaysHighestPriority;

		public float chainLoopDelayMin;

		public float chainLoopDelayMax;

		public ChainedLoopLoopMode chainLoopMode;

		public int chainLoopNumLoops;

		public bool useDialogFadeOut;

		public float dialogFadeOutTime;

		public VariationSequence curVariationSequence;

		public bool useNoRepeatRefill;

		public bool useInactivePeriodPoolRefill;

		public float inactivePeriodSeconds;

		public List<SoundGroupVariation> groupVariations;

		public MasterAudio.AudioLocation bulkVariationMode;

		public bool resourceClipsAllLoadAsync;

		public bool logSound;

		public bool copySettingsExpanded;

		public int selectedVariationIndex;

		public bool expandLinkedGroups;

		public List<string> childSoundGroups;

		public List<string> endLinkedGroups;

		public MasterAudio.LinkedGroupSelectionType linkedStartGroupSelectionType;

		public MasterAudio.LinkedGroupSelectionType linkedStopGroupSelectionType;

		public LimitMode limitMode;

		public int limitPerXFrames;

		public float minimumTimeBetween;

		public bool useClipAgePriority;

		public bool limitPolyphony;

		public int voiceLimitCount;

		public TargetDespawnedBehavior targetDespawnedBehavior;

		public float despawnFadeTime;

		public bool isUsingOcclusion;

		public bool willOcclusionOverrideRaycastOffset;

		public float occlusionRayCastOffset;

		public bool willOcclusionOverrideFrequencies;

		public float occlusionMaxCutoffFreq;

		public float occlusionMinCutoffFreq;

		public bool isSoloed;

		public bool isMuted;

		public bool soundPlayedEventActive;

		public string soundPlayedCustomEvent;

		public int frames;

		private List<int> _activeAudioSourcesIds;

		private string _objectName;

		private Transform _trans;

		private float _originalVolume;

		public MasterAudio.InternetFileLoadStatus GroupLoadStatus
		{
			get
			{
				return default(MasterAudio.InternetFileLoadStatus);
			}
		}

		public float SpatialBlendForGroup
		{
			get
			{
				return 0f;
			}
		}

		public int ActiveVoices
		{
			get
			{
				return 0;
			}
		}

		public int TotalVoices
		{
			get
			{
				return 0;
			}
		}

		public GroupBus BusForGroup
		{
			get
			{
				return null;
			}
		}

		public float OriginalVolume
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool LoggingEnabledForGroup
		{
			get
			{
				return false;
			}
		}

		public int ChainLoopCount { get; set; }

		public string GameObjectName
		{
			get
			{
				return null;
			}
		}

		public bool UsesNoRepeat
		{
			get
			{
				return false;
			}
		}

		private Transform Trans
		{
			get
			{
				return null;
			}
		}

		private List<int> ActiveAudioSourceIds
		{
			get
			{
				return null;
			}
		}

		public event Action LastVariationFinishedPlay
		{
			add
			{
			}
			remove
			{
			}
		}

		private void Start()
		{
		}

		private void OnDisable()
		{
		}

		public void AddActiveAudioSourceId(int varInstanceId)
		{
		}

		public void RemoveActiveAudioSourceId(int varInstanceId)
		{
		}

		public void FireLastVariationFinishedPlay()
		{
		}

		public void SubscribeToLastVariationFinishedPlay(Action finishedCallback)
		{
		}

		public void UnsubscribeFromLastVariationFinishedPlay()
		{
		}
	}
}
