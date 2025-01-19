using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace Slate
{
	[DisallowMultipleComponent]
	public class Cutscene : MonoBehaviour, IDirector
	{
		public enum WrapMode
		{
			Once = 0,
			Loop = 1,
			PingPong = 2
		}

		public enum StopMode
		{
			Skip = 0,
			Rewind = 1,
			Hold = 2,
			SkipRewindNoUndo = 3
		}

		public enum UpdateMode
		{
			Normal = 0,
			AnimatePhysics = 1,
			UnscaledTime = 2
		}

		public enum PlayingDirection
		{
			Forwards = 0,
			Backwards = 1
		}

		public const float VERSION_NUMBER = 1.72f;

		[SerializeField]
		private UpdateMode _updateMode;

		[SerializeField]
		private WrapMode _defaultWrapMode;

		[SerializeField]
		private StopMode _defaultStopMode;

		[SerializeField]
		private float _playbackSpeed;

		[SerializeField]
		private bool _explicitActiveLayers;

		[SerializeField]
		private LayerMask _activeLayers;

		[HideInInspector]
		public List<CutsceneGroup> groups;

		[SerializeField]
		[HideInInspector]
		private float _length;

		[SerializeField]
		[HideInInspector]
		private float _viewTimeMin;

		[SerializeField]
		[HideInInspector]
		private float _viewTimeMax;

		[NonSerialized]
		private float _currentTime;

		[NonSerialized]
		private float _playTimeStart;

		[NonSerialized]
		private float _playTimeEnd;

		[NonSerialized]
		private Transform _groupsRoot;

		[NonSerialized]
		private List<IDirectableTimePointer> timePointers;

		[NonSerialized]
		private List<IDirectableTimePointer> unsortedStartTimePointers;

		[NonSerialized]
		private Dictionary<GameObject, bool> affectedLayerGOStates;

		[NonSerialized]
		private static Dictionary<string, Cutscene> allSceneCutscenes;

		[NonSerialized]
		private bool preInitialized;

		[NonSerialized]
		private bool _isReSampleFrame;

		bool IDirector.isReSampleFrame
		{
			get
			{
				return false;
			}
		}

		GameObject IDirector.context
		{
			get
			{
				return null;
			}
		}

		public Transform groupsRoot
		{
			get
			{
				return null;
			}
		}

		public UpdateMode updateMode
		{
			get
			{
				return default(UpdateMode);
			}
			set
			{
			}
		}

		public WrapMode defaultWrapMode
		{
			get
			{
				return default(WrapMode);
			}
			set
			{
			}
		}

		public StopMode defaultStopMode
		{
			get
			{
				return default(StopMode);
			}
			set
			{
			}
		}

		public bool explicitActiveLayers
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public LayerMask activeLayers
		{
			get
			{
				return default(LayerMask);
			}
			set
			{
			}
		}

		public DirectorGroup directorGroup
		{
			get
			{
				return null;
			}
		}

		public CameraTrack cameraTrack
		{
			get
			{
				return null;
			}
		}

		public float currentTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float length
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float viewTimeMin
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float viewTimeMax
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float playTimeStart
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float playTimeEnd
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float playbackSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public List<IDirectable> directables { get; private set; }

		public bool isActive { get; private set; }

		public bool isPaused { get; private set; }

		public PlayingDirection playingDirection { get; private set; }

		public WrapMode playingWrapMode { get; private set; }

		public float previousTime { get; private set; }

		public float remainingTime
		{
			get
			{
				return 0f;
			}
		}

		public static event Action<Cutscene> OnCutsceneStarted
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<Cutscene> OnCutsceneStopped
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<Section> OnSectionReached
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<string, object> OnGlobalMessageSend
		{
			add
			{
			}
			remove
			{
			}
		}

		private event Action OnStop
		{
			add
			{
			}
			remove
			{
			}
		}

		protected void Awake()
		{
		}

		protected void OnDestroy()
		{
		}

		private void SectionReached(Section section)
		{
		}

		public IEnumerable<GameObject> GetAffectedActors()
		{
			return null;
		}

		public float[] GetKeyTimes()
		{
			return null;
		}

		public void Play()
		{
		}

		public void Play(Action callback)
		{
		}

		public void Play(float startTime)
		{
		}

		public void Play(float startTime, Action callback)
		{
		}

		public void Play(float startTime, float endTime, WrapMode wrapMode = WrapMode.Once, Action callback = null, PlayingDirection playDirection = PlayingDirection.Forwards)
		{
		}

		public void Stop()
		{
		}

		public void Stop(StopMode stopMode)
		{
		}

		public void PlayReverse()
		{
		}

		public void PlayReverse(float startTime, float endTime)
		{
		}

		public void Pause()
		{
		}

		public void Resume()
		{
		}

		public void SkipAll()
		{
		}

		public void Rewind()
		{
		}

		public void RewindNoUndo()
		{
		}

		[Obsolete]
		public void Skip()
		{
		}

		public void SkipCurrentSection()
		{
		}

		public bool JumpToSection(string name)
		{
			return false;
		}

		public bool JumpToSection(Section section)
		{
			return false;
		}

		public bool PlayFromSection(string name)
		{
			return false;
		}

		public bool PlayFromSection(string name, WrapMode wrap, Action callback = null)
		{
			return false;
		}

		public bool PlayFromSection(Section section)
		{
			return false;
		}

		public bool PlayFromSection(Section section, WrapMode wrap, Action callback = null)
		{
			return false;
		}

		public bool PlaySection(string name)
		{
			return false;
		}

		public bool PlaySection(string name, WrapMode wrap, Action callback = null)
		{
			return false;
		}

		public bool PlaySection(Section section)
		{
			return false;
		}

		public bool PlaySection(Section section, WrapMode wrap, Action callback = null)
		{
			return false;
		}

		public void Sample()
		{
		}

		public void Sample(float time)
		{
		}

		private void Internal_SamplePointers(float currentTime, float previousTime)
		{
		}

		public void ReSample()
		{
		}

		private void InitializeTimePointers()
		{
		}

		private void OnSampleStarted()
		{
		}

		private void OnSampleEnded()
		{
		}

		private void SetLayersActive()
		{
		}

		private void RestoreLayersActive()
		{
		}

		[DebuggerHidden]
		private IEnumerator Internal_UpdateCutscene()
		{
			return null;
		}

		public void Validate()
		{
		}

		public static Cutscene Play(string name)
		{
			return null;
		}

		public static Cutscene Play(string name, Action callback)
		{
			return null;
		}

		public static Cutscene FindFromResources(string name)
		{
			return null;
		}

		public static Cutscene Find(string name)
		{
			return null;
		}

		public void SendGlobalMessage(string message, object value = null)
		{
		}

		public void SetGroupActorOfName(string groupName, GameObject newActor)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public Section GetSectionByName(string name)
		{
			return null;
		}

		public Section GetSectionByUID(string UID)
		{
			return null;
		}

		public Section[] GetSections()
		{
			return null;
		}

		public float GetSectionLength(string name)
		{
			return 0f;
		}

		public string[] GetSectionNames()
		{
			return null;
		}

		public string[] GetDefinedEventNames()
		{
			return null;
		}

		public void PreInitialize()
		{
		}

		public void RenderCutscene(int width, int height, int frameRate, Action<Texture2D[]> Callback)
		{
		}

		[DebuggerHidden]
		private IEnumerator Internal_RenderCutscene(int width, int height, int frameRate, Action<Texture2D[]> Callback)
		{
			return null;
		}
	}
}
