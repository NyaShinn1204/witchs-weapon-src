using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Audio;

namespace DarkTonic.MasterAudio
{
	public class MasterAudio : MonoBehaviour
	{
		public enum LinkedGroupSelectionType
		{
			All = 0,
			OneAtRandom = 1
		}

		public enum OcclusionSelectionType
		{
			AllGroups = 0,
			TurnOnPerBusOrGroup = 1
		}

		public enum RaycastMode
		{
			Physics3D = 0,
			Physics2D = 1
		}

		public enum AllMusicSpatialBlendType
		{
			ForceAllTo2D = 0,
			ForceAllTo3D = 1,
			ForceAllToCustom = 2,
			AllowDifferentPerController = 3
		}

		public enum AllMixerSpatialBlendType
		{
			ForceAllTo2D = 0,
			ForceAllTo3D = 1,
			ForceAllToCustom = 2,
			AllowDifferentPerGroup = 3
		}

		public enum ItemSpatialBlendType
		{
			ForceTo2D = 0,
			ForceTo3D = 1,
			ForceToCustom = 2,
			UseCurveFromAudioSource = 3
		}

		public enum InternetFileLoadStatus
		{
			Loading = 0,
			Loaded = 1,
			Failed = 2
		}

		public enum MixerWidthMode
		{
			Narrow = 0,
			Normal = 1,
			Wide = 2
		}

		public enum CustomEventReceiveMode
		{
			Always = 0,
			WhenDistanceLessThan = 1,
			WhenDistanceMoreThan = 2,
			Never = 3,
			OnSameGameObject = 4,
			OnChildGameObject = 5,
			OnParentGameObject = 6,
			OnSameOrChildGameObject = 7,
			OnSameOrParentGameObject = 8
		}

		public enum EventReceiveFilter
		{
			All = 0,
			Closest = 1,
			Random = 2
		}

		public enum AudioLocation
		{
			Clip = 0,
			ResourceFile = 1,
			FileOnInternet = 2
		}

		public enum CustomSongStartTimeMode
		{
			Beginning = 0,
			SpecificTime = 1,
			RandomTime = 2
		}

		public enum BusCommand
		{
			None = 0,
			FadeToVolume = 1,
			Mute = 2,
			Pause = 3,
			Solo = 4,
			Unmute = 5,
			Unpause = 6,
			Unsolo = 7,
			Stop = 8,
			ChangePitch = 9,
			ToggleMute = 10,
			StopBusOfTransform = 11,
			PauseBusOfTransform = 12,
			UnpauseBusOfTransform = 13
		}

		public enum DragGroupMode
		{
			OneGroupPerClip = 0,
			OneGroupWithVariations = 1
		}

		public enum EventSoundFunctionType
		{
			PlaySound = 0,
			GroupControl = 1,
			BusControl = 2,
			PlaylistControl = 3,
			CustomEventControl = 4,
			GlobalControl = 5,
			UnityMixerControl = 6,
			PersistentSettingsControl = 7
		}

		public enum LanguageMode
		{
			UseDeviceSetting = 0,
			SpecificLanguage = 1,
			DynamicallySet = 2
		}

		public enum UnityMixerCommand
		{
			None = 0,
			TransitionToSnapshot = 1,
			TransitionToSnapshotBlend = 2
		}

		public enum PlaylistCommand
		{
			None = 0,
			ChangePlaylist = 1,
			FadeToVolume = 2,
			PlayClip = 3,
			PlayRandomSong = 4,
			PlayNextSong = 5,
			Pause = 6,
			Resume = 7,
			Stop = 8,
			Mute = 9,
			Unmute = 10,
			ToggleMute = 11,
			Restart = 12,
			Start = 13,
			StopLoopingCurrentSong = 14,
			StopPlaylistAfterCurrentSong = 15
		}

		public enum CustomEventCommand
		{
			None = 0,
			FireEvent = 1
		}

		public enum GlobalCommand
		{
			None = 0,
			PauseMixer = 1,
			UnpauseMixer = 2,
			StopMixer = 3,
			StopEverything = 4,
			PauseEverything = 5,
			UnpauseEverything = 6,
			MuteEverything = 7,
			UnmuteEverything = 8,
			SetMasterMixerVolume = 9,
			SetMasterPlaylistVolume = 10
		}

		public enum SoundGroupCommand
		{
			None = 0,
			FadeToVolume = 1,
			FadeOutAllOfSound = 2,
			Mute = 3,
			Pause = 4,
			Solo = 5,
			StopAllOfSound = 6,
			Unmute = 7,
			Unpause = 8,
			Unsolo = 9,
			StopAllSoundsOfTransform = 10,
			PauseAllSoundsOfTransform = 11,
			UnpauseAllSoundsOfTransform = 12,
			StopSoundGroupOfTransform = 13,
			PauseSoundGroupOfTransform = 14,
			UnpauseSoundGroupOfTransform = 15,
			FadeOutSoundGroupOfTransform = 16,
			RefillSoundGroupPool = 17,
			RouteToBus = 18
		}

		public enum PersistentSettingsCommand
		{
			None = 0,
			SetBusVolume = 1,
			SetGroupVolume = 2,
			SetMixerVolume = 3,
			SetMusicVolume = 4,
			MixerMuteToggle = 5,
			MusicMuteToggle = 6
		}

		public enum SongFadeInPosition
		{
			NewClipFromBeginning = 1,
			NewClipFromLastKnownPosition = 3,
			SynchronizeClips = 5
		}

		public enum SoundSpawnLocationMode
		{
			MasterAudioLocation = 0,
			CallerLocation = 1,
			AttachToCaller = 2
		}

		public enum VariationCommand
		{
			None = 0,
			Stop = 1,
			Pause = 2,
			Unpause = 3
		}

		public struct CustomEventCandidate
		{
			public float DistanceAway;

			public ICustomEventReceiver Receiver;

			public Transform Trans;

			public int RandomId;

			public CustomEventCandidate(float distance, ICustomEventReceiver rec, Transform trans, int randomId)
			{
				DistanceAway = 0f;
				Receiver = null;
				Trans = null;
				RandomId = 0;
			}
		}

		[Serializable]
		public class AudioGroupInfo
		{
			public List<AudioInfo> Sources;

			public int LastFramePlayed;

			public float LastTimePlayed;

			public MasterAudioGroup Group;

			public bool PlayedForWarming;

			public AudioGroupInfo(List<AudioInfo> sources, MasterAudioGroup groupScript)
			{
			}
		}

		[Serializable]
		public class AudioInfo
		{
			public AudioSource Source;

			public float OriginalVolume;

			public float LastPercentageVolume;

			public float LastRandomVolume;

			public SoundGroupVariation Variation;

			public AudioInfo(SoundGroupVariation variation, AudioSource source, float origVol)
			{
			}
		}

		[Serializable]
		public class Playlist
		{
			public enum CrossfadeTimeMode
			{
				UseMasterSetting = 0,
				Override = 1
			}

			public bool isExpanded;

			public string playlistName;

			public SongFadeInPosition songTransitionType;

			public List<MusicSetting> MusicSettings;

			public AudioLocation bulkLocationMode;

			public CrossfadeTimeMode crossfadeMode;

			public float crossFadeTime;

			public bool fadeInFirstSong;

			public bool fadeOutLastSong;

			public bool resourceClipsAllLoadAsync;
		}

		[Serializable]
		public class SoundGroupRefillInfo
		{
			public float LastTimePlayed;

			public float InactivePeriodSeconds;

			public SoundGroupRefillInfo(float lastTimePlayed, float inactivePeriodSeconds)
			{
			}
		}

		public const string MasterAudioDefaultFolder = "Assets/Plugins/DarkTonic/MasterAudio";

		public const string PreviewText = "Fading & random settings are ignored by preview in edit mode.";

		public const string NoCategory = "[Uncategorized]";

		public const float SemiTonePitchFactor = 1.05946f;

		public const float SpatialBlend_2DValue = 0f;

		public const float SpatialBlend_3DValue = 1f;

		public const float MaxCrossFadeTimeSeconds = 120f;

		public const float DefaultDuckVolCut = -6f;

		public const string StoredLanguageNameKey = "~MA_Language_Key~";

		public static readonly YieldInstruction EndOfFrameDelay;

		public static readonly List<string> ExemptChildNames;

		public static Action NumberOfAudioSourcesChanged;

		public const string GizmoFileName = "MasterAudio/MasterAudio Icon.png";

		public const int HardCodedBusOptions = 2;

		public const string AllBusesName = "[All]";

		public const string NoGroupName = "[None]";

		public const string DynamicGroupName = "[Type In]";

		public const string NoPlaylistName = "[No Playlist]";

		public const string NoVoiceLimitName = "[NO LMT]";

		public const string OnlyPlaylistControllerName = "~only~";

		public const float InnerLoopCheckInterval = 0.1f;

		private const int MaxComponents = 20;

		public AudioLocation bulkLocationMode;

		public string groupTemplateName;

		public string audioSourceTemplateName;

		public bool showGroupCreation;

		public bool useGroupTemplates;

		public DragGroupMode curDragGroupMode;

		public List<GameObject> groupTemplates;

		public List<GameObject> audioSourceTemplates;

		public bool mixerMuted;

		public bool playlistsMuted;

		public LanguageMode langMode;

		public SystemLanguage testLanguage;

		public SystemLanguage defaultLanguage;

		public List<SystemLanguage> supportedLanguages;

		public string busFilter;

		public bool useTextGroupFilter;

		public string textGroupFilter;

		public bool resourceClipsPauseDoNotUnload;

		public bool resourceClipsAllLoadAsync;

		public Transform playlistControllerPrefab;

		public bool persistBetweenScenes;

		public bool areGroupsExpanded;

		public Transform soundGroupTemplate;

		public Transform soundGroupVariationTemplate;

		public List<GroupBus> groupBuses;

		public bool groupByBus;

		public bool showGizmos;

		public bool showAdvancedSettings;

		public bool showLocalization;

		public bool playListExpanded;

		public bool playlistsExpanded;

		public AllMusicSpatialBlendType musicSpatialBlendType;

		public float musicSpatialBlend;

		public AllMixerSpatialBlendType mixerSpatialBlendType;

		public float mixerSpatialBlend;

		public ItemSpatialBlendType newGroupSpatialType;

		public float newGroupSpatialBlend;

		public List<Playlist> musicPlaylists;

		public float _masterAudioVolume;

		public bool useSpatializer;

		public bool ignoreTimeScale;

		public bool useGaplessPlaylists;

		public bool saveRuntimeChanges;

		public bool prioritizeOnDistance;

		public int rePrioritizeEverySecIndex;

		public bool useOcclusion;

		public float occlusionMaxCutoffFreq;

		public float occlusionMinCutoffFreq;

		public float occlusionFreqChangeSeconds;

		public OcclusionSelectionType occlusionSelectType;

		public int occlusionMaxRayCastsPerFrame;

		public float occlusionRayCastOffset;

		public bool occlusionUseLayerMask;

		public LayerMask occlusionLayerMask;

		public bool occlusionShowRaycasts;

		public bool occlusionShowCategories;

		public RaycastMode occlusionRaycastMode;

		public bool occlusionIncludeStartRaycast2DCollider;

		public bool occlusionRaycastsHitTriggers;

		public bool visualAdvancedExpanded;

		public bool logAdvancedExpanded;

		public bool showFadingSettings;

		public bool stopZeroVolumeVariations;

		public bool stopZeroVolumeGroups;

		public bool stopZeroVolumeBuses;

		public bool stopZeroVolumePlaylists;

		public bool resourceAdvancedExpanded;

		public bool useClipAgePriority;

		public bool LogSounds;

		public bool logCustomEvents;

		public bool disableLogging;

		public bool showMusicDucking;

		public bool enableMusicDucking;

		public List<DuckGroupInfo> musicDuckingSounds;

		public float defaultRiseVolStart;

		public float defaultUnduckTime;

		public float defaultDuckedVolumeCut;

		public float crossFadeTime;

		public float _masterPlaylistVolume;

		public bool showGroupSelect;

		public bool hideGroupsWithNoActiveVars;

		public string newEventName;

		public bool showCustomEvents;

		public string newCustomEventCategoryName;

		public string addToCustomEventCategoryName;

		public List<CustomEvent> customEvents;

		public List<CustomEventCategory> customEventCategories;

		public Dictionary<string, DuckGroupInfo> duckingBySoundType;

		public int frames;

		public bool showUnityMixerGroupAssignment;

		public static readonly PlaySoundResult AndForgetSuccessResult;

		private static readonly Dictionary<string, AudioGroupInfo> AudioSourcesBySoundType;

		private static Dictionary<string, List<int>> _randomizer;

		private static Dictionary<string, List<int>> _randomizerOrigin;

		private static Dictionary<string, List<int>> _randomizerLeftovers;

		private static Dictionary<string, List<int>> _clipsPlayedBySoundTypeOldestFirst;

		private static readonly List<CustomEventCandidate> ValidReceivers;

		private static readonly List<MasterAudioGroup> SoloedGroups;

		private static readonly List<BusFadeInfo> BusFades;

		private static readonly List<GroupFadeInfo> GroupFades;

		private static readonly List<OcclusionFreqChangeInfo> VariationOcclusionFreqChanges;

		private static readonly List<AudioSource> AllAudioSources;

		private static readonly Dictionary<string, Dictionary<ICustomEventReceiver, Transform>> ReceiversByEventName;

		private static readonly Dictionary<string, PlaylistController> PlaylistControllersByName;

		private static readonly Dictionary<string, SoundGroupRefillInfo> LastTimeSoundGroupPlayed;

		private static readonly List<GameObject> OcclusionSourcesInRange;

		private static readonly List<GameObject> OcclusionSourcesOutOfRange;

		private static readonly List<GameObject> OcclusionSourcesBlocked;

		private static readonly Queue<SoundGroupVariationUpdater> QueuedOcclusionRays;

		private static readonly List<SoundGroupVariation> VariationsStartedDuringMultiStop;

		private static bool _isStoppingMultiple;

		private static MasterAudio _instance;

		private static float _repriTime;

		private static List<string> _groupsToRemove;

		private static string _prospectiveMAFolder;

		private static Transform _listenerTrans;

		private static YieldInstruction _innerLoopDelay;

		private Transform _trans;

		private bool _soundsLoaded;

		private bool _warming;

		public static readonly List<SoundGroupCommand> GroupCommandsWithNoGroupSelector;

		public static readonly List<SoundGroupCommand> GroupCommandsWithNoAllGroupSelector;

		public static float PlaylistMasterVolume
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public static bool LogSoundsEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static List<AudioSource> MasterAudioSources
		{
			get
			{
				return null;
			}
		}

		public static Transform ListenerTrans
		{
			get
			{
				return null;
			}
		}

		public static PlaylistController OnlyPlaylistController
		{
			get
			{
				return null;
			}
		}

		public static bool IsWarming
		{
			get
			{
				return false;
			}
		}

		public static bool MixerMuted
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool PlaylistsMuted
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool EnableMusicDucking
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float MasterCrossFadeTime
		{
			get
			{
				return 0f;
			}
		}

		public static List<Playlist> MusicPlaylists
		{
			get
			{
				return null;
			}
		}

		public static List<GroupBus> GroupBuses
		{
			get
			{
				return null;
			}
		}

		public static List<string> RuntimeSoundGroupNames
		{
			get
			{
				return null;
			}
		}

		public static List<string> RuntimeBusNames
		{
			get
			{
				return null;
			}
		}

		public static MasterAudio SafeInstance
		{
			get
			{
				return null;
			}
		}

		public static MasterAudio Instance
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static bool SoundsReady
		{
			get
			{
				return false;
			}
		}

		public static bool AppIsShuttingDown { get; set; }

		public List<string> GroupNames
		{
			get
			{
				return null;
			}
		}

		public static List<string> SoundGroupHardCodedNames
		{
			get
			{
				return null;
			}
		}

		public List<string> BusNames
		{
			get
			{
				return null;
			}
		}

		public List<string> PlaylistNames
		{
			get
			{
				return null;
			}
		}

		public List<string> PlaylistNamesOnly
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

		public bool ShouldShowUnityAudioMixerGroupAssignments
		{
			get
			{
				return false;
			}
		}

		public List<string> CustomEventNames
		{
			get
			{
				return null;
			}
		}

		public List<string> CustomEventNamesOnly
		{
			get
			{
				return null;
			}
		}

		public static List<string> CustomEventHardCodedNames
		{
			get
			{
				return null;
			}
		}

		public static float MasterVolumeLevel
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		private static bool SceneHasMasterAudio
		{
			get
			{
				return false;
			}
		}

		public static bool IgnoreTimeScale
		{
			get
			{
				return false;
			}
		}

		public static YieldInstruction InnerLoopDelay
		{
			get
			{
				return null;
			}
		}

		public static SystemLanguage DynamicLanguage
		{
			get
			{
				return default(SystemLanguage);
			}
			set
			{
			}
		}

		public static float ReprioritizeTime
		{
			get
			{
				return 0f;
			}
		}

		public static string ProspectiveMAPath
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		private static void UpdateRefillTime(string sType, float inactivePeriodSeconds)
		{
		}

		private static void RefillInactiveGroupPools()
		{
		}

		private static void PerformOcclusionFrequencyChanges()
		{
		}

		private void PerformBusFades()
		{
		}

		private void PerformGroupFades()
		{
		}

		private void OnApplicationQuit()
		{
		}

		public static bool PlaySoundAndForget(string sType, float volumePercentage = 1f, float? pitch = null, float delaySoundTime = 0f, string variationName = null)
		{
			return false;
		}

		public static PlaySoundResult PlaySound(string sType, float volumePercentage = 1f, float? pitch = null, float delaySoundTime = 0f, string variationName = null, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		public static bool PlaySound3DAtVector3AndForget(string sType, Vector3 sourcePosition, float volumePercentage = 1f, float? pitch = null, float delaySoundTime = 0f, string variationName = null)
		{
			return false;
		}

		public static PlaySoundResult PlaySound3DAtVector3(string sType, Vector3 sourcePosition, float volumePercentage = 1f, float? pitch = null, float delaySoundTime = 0f, string variationName = null)
		{
			return null;
		}

		public static bool PlaySound3DAtTransformAndForget(string sType, Transform sourceTrans, float volumePercentage = 1f, float? pitch = null, float delaySoundTime = 0f, string variationName = null)
		{
			return false;
		}

		public static PlaySoundResult PlaySound3DAtTransform(string sType, Transform sourceTrans, float volumePercentage = 1f, float? pitch = null, float delaySoundTime = 0f, string variationName = null, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		public static bool PlaySound3DFollowTransformAndForget(string sType, Transform sourceTrans, float volumePercentage = 1f, float? pitch = null, float delaySoundTime = 0f, string variationName = null)
		{
			return false;
		}

		public static PlaySoundResult PlaySound3DFollowTransform(string sType, Transform sourceTrans, float volumePercentage = 1f, float? pitch = null, float delaySoundTime = 0f, string variationName = null, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[DebuggerHidden]
		public static IEnumerator PlaySoundAndWaitUntilFinished(string sType, float volumePercentage = 1f, float? pitch = null, float delaySoundTime = 0f, string variationName = null, Action completedAction = null)
		{
			return null;
		}

		[DebuggerHidden]
		public static IEnumerator PlaySound3DAtTransformAndWaitUntilFinished(string sType, Transform sourceTrans, float volumePercentage = 1f, float? pitch = null, float delaySoundTime = 0f, string variationName = null, Action completedAction = null)
		{
			return null;
		}

		[DebuggerHidden]
		public static IEnumerator PlaySound3DFollowTransformAndWaitUntilFinished(string sType, Transform sourceTrans, float volumePercentage = 1f, float? pitch = null, float delaySoundTime = 0f, string variationName = null, Action completedAction = null)
		{
			return null;
		}

		public static bool PSRAsSuccessBool(PlaySoundResult psr)
		{
			return false;
		}

		private static PlaySoundResult PlaySoundAtVolume(string sType, float volumePercentage, Vector3 sourcePosition, float? pitch = null, Transform sourceTrans = null, string variationName = null, bool attachToSource = false, float delaySoundTime = 0f, bool useVector3 = false, bool makePlaySoundResult = false, bool isChaining = false, bool isSingleSubscribedPlay = false, bool triggeredAsChildGroup = false)
		{
			return null;
		}

		private static void MaybeChainNextVar(bool isChaining, SoundGroupVariation variation, float volumePercentage, float? pitch, Transform sourceTrans, bool attachToSource)
		{
		}

		private static void SetLastPlayed(AudioGroupInfo grp)
		{
		}

		private static void RemoveClipAndRefillIfEmpty(AudioGroupInfo grp, bool isNonSpecific, int? randomIndex, List<int> choices, string sType, int pickedChoice, bool loggingEnabledForGrp, bool isSingleVarLoop)
		{
		}

		private static PlaySoundResult PlaySoundIfAvailable(AudioInfo info, Vector3 sourcePosition, float volumePercentage, ref bool forgetSoundPlayed, float? pitch = null, AudioGroupInfo audioGroup = null, Transform sourceTrans = null, bool attachToSource = false, float delaySoundTime = 0f, bool useVector3 = false, bool makePlaySoundResult = false, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		public static void DuckSoundGroup(string soundGroupName, AudioSource aSource)
		{
		}

		private static void StopPauseOrUnpauseSoundsOfTransform(Transform trans, List<AudioInfo> varList, VariationCommand varCmd)
		{
		}

		public static void StopAllSoundsOfTransform(Transform sourceTrans)
		{
		}

		public static void StopSoundGroupOfTransform(Transform sourceTrans, string sType)
		{
		}

		public static void PauseAllSoundsOfTransform(Transform sourceTrans)
		{
		}

		public static void PauseSoundGroupOfTransform(Transform sourceTrans, string sType)
		{
		}

		public static void UnpauseAllSoundsOfTransform(Transform sourceTrans)
		{
		}

		public static void UnpauseSoundGroupOfTransform(Transform sourceTrans, string sType)
		{
		}

		public static void FadeOutSoundGroupOfTransform(Transform sourceTrans, string sType, float fadeTime)
		{
		}

		public static void StopAllOfSound(string sType)
		{
		}

		public static void FadeOutAllOfSound(string sType, float fadeTime)
		{
		}

		public static List<SoundGroupVariation> GetAllPlayingVariations()
		{
			return null;
		}

		public static List<SoundGroupVariation> GetAllPlayingVariationsOfTransform(Transform sourceTrans)
		{
			return null;
		}

		public static List<SoundGroupVariation> GetAllPlayingVariationsInBus(string busName)
		{
			return null;
		}

		public static void CreateGroupVariationFromClip(string sType, AudioClip clip, string variationName, float volume = 1f, float pitch = 1f)
		{
		}

		public static void ChangeVariationPitch(string sType, bool changeAllVariations, string variationName, float pitch)
		{
		}

		public static void ChangeVariationVolume(string sType, bool changeAllVariations, string variationName, float volume)
		{
		}

		public static void ChangeVariationClipFromResources(string sType, bool changeAllVariations, string variationName, string resourceFileName)
		{
		}

		public static void ChangeVariationClip(string sType, bool changeAllVariations, string variationName, AudioClip clip)
		{
		}

		public static void GradualOcclusionFreqChange(SoundGroupVariation variation, float fadeTime, float newCutoffFreq)
		{
		}

		public static bool IsSoundGroupPlaying(string sType)
		{
			return false;
		}

		public static bool IsTransformPlayingSoundGroup(string sType, Transform sourceTrans)
		{
			return false;
		}

		public static void RouteGroupToBus(string sType, string busName)
		{
		}

		public static float GetVariationLength(string sType, string variationName)
		{
			return 0f;
		}

		public static void RefillSoundGroupPool(string sType)
		{
		}

		public static bool SoundGroupExists(string sType)
		{
			return false;
		}

		public static void PauseSoundGroup(string sType)
		{
		}

		public static void SetGroupSpatialBlend(string sType)
		{
		}

		public static void RouteGroupToUnityMixerGroup(string sType, AudioMixerGroup mixerGroup)
		{
		}

		public static void UnpauseSoundGroup(string sType)
		{
		}

		public static void FadeSoundGroupToVolume(string sType, float newVolume, float fadeTime, Action completionCallback = null, bool willStopAfterFade = false, bool willResetVolumeAfterFade = false)
		{
		}

		public static void DeleteSoundGroup(string sType)
		{
		}

		public static Transform CreateSoundGroup(DynamicSoundGroup aGroup, string creatorObjectName, bool errorOnExisting = true)
		{
			return null;
		}

		public static float GetGroupVolume(string sType)
		{
			return 0f;
		}

		public static void SetGroupVolume(string sType, float volumeLevel)
		{
		}

		public static void MuteGroup(string sType, bool shouldCheckMuteStatus = true)
		{
		}

		public static void UnmuteGroup(string sType, bool shouldCheckMuteStatus = true)
		{
		}

		private static void AddRuntimeGroupInfo(string groupName, AudioGroupInfo groupInfo)
		{
		}

		private static void FireAudioSourcesNumberChangedEvent()
		{
		}

		public static void TrackRuntimeAudioSources(List<AudioSource> sources)
		{
		}

		public static void StopTrackingRuntimeAudioSources(List<AudioSource> sources)
		{
		}

		private static void RemoveRuntimeGroupInfo(string groupName)
		{
		}

		private static void RescanChildren(MasterAudioGroup group)
		{
		}

		private static void SetGroupMuteStatus(MasterAudioGroup aGroup, string sType, bool isMute)
		{
		}

		public static void SoloGroup(string sType, bool shouldCheckMuteStatus = true)
		{
		}

		public static void SilenceOrUnsilenceGroupsFromSoloChange()
		{
		}

		private static void UnsilenceNonSoloedGroups()
		{
		}

		private static void UnsilenceGroup(string sType)
		{
		}

		private static void SilenceNonSoloedGroups()
		{
		}

		private static void SilenceGroup(string sType)
		{
		}

		public static void UnsoloGroup(string sType, bool shouldCheckMuteStatus = true)
		{
		}

		public static MasterAudioGroup GrabGroup(string sType, bool logIfMissing = true)
		{
			return null;
		}

		public static int VoicesForGroup(string sType)
		{
			return 0;
		}

		public static Transform FindGroupTransform(string sType)
		{
			return null;
		}

		public static List<AudioInfo> GetAllVariationsOfGroup(string sType, bool logIfMissing = true)
		{
			return null;
		}

		public static AudioGroupInfo GetGroupInfo(string sType)
		{
			return null;
		}

		public static void SubscribeToLastVariationPlayed(string sType, Action finishedCallback)
		{
		}

		public static void UnsubscribeFromLastVariationPlayed(string sType)
		{
		}

		public void SetSpatialBlendForMixer()
		{
		}

		public static void PauseMixer()
		{
		}

		public static void UnpauseMixer()
		{
		}

		public static void StopMixer()
		{
		}

		public static void UnsubscribeFromAllVariations()
		{
		}

		public static void StopEverything()
		{
		}

		public static void PauseEverything()
		{
		}

		public static void UnpauseEverything()
		{
		}

		public static void MuteEverything()
		{
		}

		public static void UnmuteEverything()
		{
		}

		public static List<string> ListOfAudioClipsInGroupsEditTime()
		{
			return null;
		}

		private static int GetBusIndex(string busName, bool alertMissing)
		{
			return 0;
		}

		private static GroupBus GetBusByIndex(int busIndex)
		{
			return null;
		}

		public static void ChangeBusPitch(string busName, float pitch)
		{
		}

		public static void MuteBus(string busName)
		{
		}

		public static void UnmuteBus(string busName, bool shouldCheckMuteStatus = true)
		{
		}

		public static void ToggleMuteBus(string busName)
		{
		}

		public static void PauseBus(string busName)
		{
		}

		public static void SoloBus(string busName)
		{
		}

		public static void UnsoloBus(string busName, bool shouldCheckMuteStatus = true)
		{
		}

		public static void RouteBusToUnityMixerGroup(string busName, AudioMixerGroup mixerGroup)
		{
		}

		private static void StopOldestSoundOnBus(GroupBus bus)
		{
		}

		public static void StopBus(string busName)
		{
		}

		public static void UnpauseBus(string busName)
		{
		}

		public static bool CreateBus(string busName, bool errorOnExisting = true)
		{
			return false;
		}

		public static void DeleteBusByName(string busName)
		{
		}

		public static void DeleteBusByIndex(int busIndex)
		{
		}

		public static float GetBusVolume(MasterAudioGroup maGroup)
		{
			return 0f;
		}

		public static void FadeBusToVolume(string busName, float newVolume, float fadeTime, Action completionCallback = null, bool willStopAfterFade = false, bool willResetVolumeAfterFade = false)
		{
		}

		public static void SetBusVolumeByName(string busName, float newVolume)
		{
		}

		private static void RecalculateGroupVolumes(AudioGroupInfo aGroup, GroupBus bus)
		{
		}

		private static void SetBusVolume(GroupBus bus, float newVolume)
		{
		}

		public static GroupBus GrabBusByName(string busName)
		{
			return null;
		}

		public static void PauseBusOfTransform(Transform sourceTrans, string busName)
		{
		}

		public static void UnpauseBusOfTransform(Transform sourceTrans, string busName)
		{
		}

		public static void StopBusOfTransform(Transform sourceTrans, string busName)
		{
		}

		public static void AddSoundGroupToDuckList(string sType, float riseVolumeStart, float duckedVolCut, float unduckTime)
		{
		}

		public static void RemoveSoundGroupFromDuckList(string sType)
		{
		}

		public static Playlist GrabPlaylist(string playlistName, bool logErrorIfNotFound = true)
		{
			return null;
		}

		public static void ChangePlaylistPitch(string playlistName, float pitch, string songName = null)
		{
		}

		public static void MutePlaylist()
		{
		}

		public static void MutePlaylist(string playlistControllerName)
		{
		}

		public static void MuteAllPlaylists()
		{
		}

		private static void MutePlaylists(List<PlaylistController> playlists)
		{
		}

		public static void UnmutePlaylist()
		{
		}

		public static void UnmutePlaylist(string playlistControllerName)
		{
		}

		public static void UnmuteAllPlaylists()
		{
		}

		private static void UnmutePlaylists(List<PlaylistController> playlists)
		{
		}

		public static void ToggleMutePlaylist()
		{
		}

		public static void ToggleMutePlaylist(string playlistControllerName)
		{
		}

		public static void ToggleMuteAllPlaylists()
		{
		}

		private static void ToggleMutePlaylists(List<PlaylistController> playlists)
		{
		}

		public static void PausePlaylist()
		{
		}

		public static void PausePlaylist(string playlistControllerName)
		{
		}

		public static void PauseAllPlaylists()
		{
		}

		private static void PausePlaylists(List<PlaylistController> playlists)
		{
		}

		public static void UnpausePlaylist()
		{
		}

		public static void UnpausePlaylist(string playlistControllerName)
		{
		}

		public static void UnpauseAllPlaylists()
		{
		}

		private static void UnpausePlaylists(List<PlaylistController> controllers)
		{
		}

		public static void StopPlaylist()
		{
		}

		public static void StopPlaylist(string playlistControllerName)
		{
		}

		public static void StopAllPlaylists()
		{
		}

		private static void StopPlaylists(List<PlaylistController> playlists)
		{
		}

		public static void TriggerNextPlaylistClip()
		{
		}

		public static void TriggerNextPlaylistClip(string playlistControllerName)
		{
		}

		public static void TriggerNextClipAllPlaylists()
		{
		}

		private static void NextPlaylistClips(List<PlaylistController> playlists)
		{
		}

		public static void TriggerRandomPlaylistClip()
		{
		}

		public static void TriggerRandomPlaylistClip(string playlistControllerName)
		{
		}

		public static void TriggerRandomClipAllPlaylists()
		{
		}

		private static void RandomPlaylistClips(List<PlaylistController> playlists)
		{
		}

		public static void RestartPlaylist()
		{
		}

		public static void RestartPlaylist(string playlistControllerName)
		{
		}

		public static void RestartAllPlaylists()
		{
		}

		private static void RestartPlaylists(List<PlaylistController> playlists)
		{
		}

		public static void StartPlaylist(string playlistName)
		{
		}

		public static void StartPlaylist(string playlistControllerName, string playlistName)
		{
		}

		public static void StopLoopingAllCurrentSongs()
		{
		}

		public static void StopLoopingCurrentSong()
		{
		}

		public static void StopLoopingCurrentSong(string playlistControllerName)
		{
		}

		private static void StopLoopingCurrentSongs(List<PlaylistController> playlistControllers)
		{
		}

		public static void StopAllPlaylistsAfterCurrentSongs()
		{
		}

		public static void StopPlaylistAfterCurrentSong()
		{
		}

		public static void StopPlaylistAfterCurrentSong(string playlistControllerName)
		{
		}

		private static void StopPlaylistAfterCurrentSongs(List<PlaylistController> playlistControllers)
		{
		}

		public static void QueuePlaylistClip(string clipName)
		{
		}

		public static void QueuePlaylistClip(string playlistControllerName, string clipName)
		{
		}

		public static bool TriggerPlaylistClip(string clipName)
		{
			return false;
		}

		public static bool TriggerPlaylistClip(string playlistControllerName, string clipName)
		{
			return false;
		}

		public static void ChangePlaylistByName(string playlistName, bool playFirstClip = true)
		{
		}

		public static void ChangePlaylistByName(string playlistControllerName, string playlistName, bool playFirstClip = true)
		{
		}

		public static void FadePlaylistToVolume(float targetVolume, float fadeTime)
		{
		}

		public static void FadePlaylistToVolume(string playlistControllerName, float targetVolume, float fadeTime)
		{
		}

		public static void FadeAllPlaylistsToVolume(float targetVolume, float fadeTime)
		{
		}

		private static void FadePlaylists(List<PlaylistController> playlists, float targetVolume, float fadeTime)
		{
		}

		public static void CreatePlaylist(Playlist playlist, bool errorOnDuplicate)
		{
		}

		public static void DeletePlaylist(string playlistName)
		{
		}

		public static void AddSongToPlaylist(string playlistName, AudioClip song, bool loopSong = false, float songPitch = 1f, float songVolume = 1f)
		{
		}

		public static void ReDownloadAllInternetFiles()
		{
		}

		public static void AddCustomEventReceiver(ICustomEventReceiver receiver, Transform receiverTrans)
		{
		}

		public static void RemoveCustomEventReceiver(ICustomEventReceiver receiver)
		{
		}

		public static List<Transform> ReceiversForEvent(string customEventName)
		{
			return null;
		}

		public static CustomEventCategory CreateCustomEventCategoryIfNotThere(string categoryName)
		{
			return null;
		}

		public static void CreateCustomEvent(string customEventName, CustomEventReceiveMode eventReceiveMode, float distanceThreshold, EventReceiveFilter receiveFilter, int filterModeQty, string categoryName = "", bool errorOnDuplicate = true)
		{
		}

		public static void DeleteCustomEvent(string customEventName)
		{
		}

		public static CustomEvent GetCustomEventByName(string customEventName)
		{
			return null;
		}

		public static void FireCustomEvent(string customEventName, Transform originObject, bool logDupe = true)
		{
		}

		public static bool CustomEventExists(string customEventName)
		{
			return false;
		}

		private static List<ICustomEventReceiver> GetChildReceivers(Transform origin, string eventName, bool includeSelf)
		{
			return null;
		}

		private static List<ICustomEventReceiver> GetParentReceivers(Transform origin, string eventName, bool includeSelf)
		{
			return null;
		}

		private static List<ICustomEventReceiver> FilterOutSelf(List<ICustomEventReceiver> sourceList, Transform origin)
		{
			return null;
		}

		private static bool LoggingEnabledForGroup(MasterAudioGroup grp)
		{
			return false;
		}

		private static void LogMessage(string message)
		{
		}

		public static void LogWarning(string msg)
		{
		}

		public static void LogError(string msg)
		{
		}

		public static void LogNoPlaylist(string playlistControllerName, string methodName)
		{
		}

		private static bool IsOkToCallOnlyPlaylistMethod(List<PlaylistController> pcs, string methodName)
		{
			return false;
		}

		public static void AddToQueuedOcclusionRays(SoundGroupVariationUpdater updater)
		{
		}

		public static void AddToOcclusionInRangeSources(GameObject src)
		{
		}

		public static void AddToOcclusionOutOfRangeSources(GameObject src)
		{
		}

		public static void AddToBlockedOcclusionSources(GameObject src)
		{
		}

		public static bool HasQueuedOcclusionRays()
		{
			return false;
		}

		public static SoundGroupVariationUpdater OldestQueuedOcclusionRay()
		{
			return null;
		}

		public static bool IsOcclusionFreqencyTransitioning(SoundGroupVariation variation)
		{
			return false;
		}

		public static void RemoveFromOcclusionFrequencyTransitioning(SoundGroupVariation variation)
		{
		}

		public static void RemoveFromBlockedOcclusionSources(GameObject src)
		{
		}

		public static void StopTrackingOcclusionForSource(GameObject src)
		{
		}

		private static bool IsLinkedGroupPlay(SoundGroupVariation variation)
		{
			return false;
		}

		public static int RemainingClipsInGroup(string sType)
		{
			return 0;
		}

		public static bool HasAsyncResourceLoaderFeature()
		{
			return false;
		}

		public static GameObject CreateMasterAudio()
		{
			return null;
		}

		public static GameObject CreatePlaylistController()
		{
			return null;
		}

		public static GameObject CreateDynamicSoundGroupCreator()
		{
			return null;
		}

		public static GameObject CreateSoundGroupOrganizer()
		{
			return null;
		}
	}
}
