using System.Collections.Generic;
using DG.Tweening.Core;
using DG.Tweening.Core.Surrogates;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

namespace DG.Tweening
{
	public class DOTween
	{
		public static readonly string Version;

		public static bool useSafeMode;

		public static bool showUnityEditorReport;

		public static float timeScale;

		public static bool useSmoothDeltaTime;

		public static float maxSmoothUnscaledTime;

		private static LogBehaviour _logBehaviour;

		public static bool drawGizmos;

		public static UpdateType defaultUpdateType;

		public static bool defaultTimeScaleIndependent;

		public static AutoPlay defaultAutoPlay;

		public static bool defaultAutoKill;

		public static LoopType defaultLoopType;

		public static bool defaultRecyclable;

		public static Ease defaultEaseType;

		public static float defaultEaseOvershootOrAmplitude;

		public static float defaultEasePeriod;

		internal static DOTweenComponent instance;

		internal static bool isUnityEditor;

		internal static bool isDebugBuild;

		internal static int maxActiveTweenersReached;

		internal static int maxActiveSequencesReached;

		internal static readonly List<TweenCallback> GizmosDelegates;

		internal static bool initialized;

		internal static bool isQuitting;

		public static LogBehaviour logBehaviour
		{
			get
			{
				return default(LogBehaviour);
			}
			set
			{
			}
		}

		static DOTween()
		{
		}

		public static IDOTweenInit Init(bool? recycleAllByDefault = null, bool? useSafeMode = null, LogBehaviour? logBehaviour = null)
		{
			return null;
		}

		private static void AutoInit()
		{
		}

		private static IDOTweenInit Init(DOTweenSettings settings, bool? recycleAllByDefault, bool? useSafeMode, LogBehaviour? logBehaviour)
		{
			return null;
		}

		public static void SetTweensCapacity(int tweenersCapacity, int sequencesCapacity)
		{
		}

		public static void Clear(bool destroy = false)
		{
		}

		public static void ClearCachedTweens()
		{
		}

		public static int Validate()
		{
			return 0;
		}

		public static void ManualUpdate(float deltaTime, float unscaledDeltaTime)
		{
		}

		public static TweenerCore<float, float, FloatOptions> To(DOGetter<float> getter, DOSetter<float> setter, float endValue, float duration)
		{
			return null;
		}

		public static TweenerCore<double, double, NoOptions> To(DOGetter<double> getter, DOSetter<double> setter, double endValue, float duration)
		{
			return null;
		}

		public static Tweener To(DOGetter<int> getter, DOSetter<int> setter, int endValue, float duration)
		{
			return null;
		}

		public static Tweener To(DOGetter<uint> getter, DOSetter<uint> setter, uint endValue, float duration)
		{
			return null;
		}

		public static Tweener To(DOGetter<long> getter, DOSetter<long> setter, long endValue, float duration)
		{
			return null;
		}

		public static Tweener To(DOGetter<ulong> getter, DOSetter<ulong> setter, ulong endValue, float duration)
		{
			return null;
		}

		public static TweenerCore<string, string, StringOptions> To(DOGetter<string> getter, DOSetter<string> setter, string endValue, float duration)
		{
			return null;
		}

		public static TweenerCore<Vector2Wrapper, Vector2Wrapper, VectorOptions> To(DOGetter<Vector2Wrapper> getter, DOSetter<Vector2Wrapper> setter, Vector2 endValue, float duration)
		{
			return null;
		}

		public static TweenerCore<Vector3Wrapper, Vector3Wrapper, VectorOptions> To(DOGetter<Vector3Wrapper> getter, DOSetter<Vector3Wrapper> setter, Vector3 endValue, float duration)
		{
			return null;
		}

		public static TweenerCore<Vector4Wrapper, Vector4Wrapper, VectorOptions> To(DOGetter<Vector4Wrapper> getter, DOSetter<Vector4Wrapper> setter, Vector4 endValue, float duration)
		{
			return null;
		}

		public static TweenerCore<QuaternionWrapper, Vector3Wrapper, QuaternionOptions> To(DOGetter<QuaternionWrapper> getter, DOSetter<QuaternionWrapper> setter, Vector3 endValue, float duration)
		{
			return null;
		}

		public static TweenerCore<ColorWrapper, ColorWrapper, ColorOptions> To(DOGetter<ColorWrapper> getter, DOSetter<ColorWrapper> setter, Color endValue, float duration)
		{
			return null;
		}

		public static TweenerCore<Rect, Rect, RectOptions> To(DOGetter<Rect> getter, DOSetter<Rect> setter, Rect endValue, float duration)
		{
			return null;
		}

		public static Tweener To(DOGetter<RectOffset> getter, DOSetter<RectOffset> setter, RectOffset endValue, float duration)
		{
			return null;
		}

		public static TweenerCore<T1, T2, TPlugOptions> To<T1, T2, TPlugOptions>(ABSTweenPlugin<T1, T2, TPlugOptions> plugin, DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration) where TPlugOptions : struct, IPlugOptions
		{
			return null;
		}

		public static TweenerCore<Vector3Wrapper, Vector3Wrapper, VectorOptions> ToAxis(DOGetter<Vector3Wrapper> getter, DOSetter<Vector3Wrapper> setter, float endValue, float duration, AxisConstraint axisConstraint = AxisConstraint.X)
		{
			return null;
		}

		public static Tweener ToAlpha(DOGetter<ColorWrapper> getter, DOSetter<ColorWrapper> setter, float endValue, float duration)
		{
			return null;
		}

		public static Tweener To(DOSetter<float> setter, float startValue, float endValue, float duration)
		{
			return null;
		}

		public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Punch(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3 direction, float duration, int vibrato = 10, float elasticity = 1f)
		{
			return null;
		}

		public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, float strength = 3f, int vibrato = 10, float randomness = 90f, bool ignoreZAxis = true, bool fadeOut = true)
		{
			return null;
		}

		public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, Vector3 strength, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
		{
			return null;
		}

		private static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, Vector3 strength, int vibrato, float randomness, bool ignoreZAxis, bool vectorBased, bool fadeOut)
		{
			return null;
		}

		public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> ToArray(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3[] endValues, float[] durations)
		{
			return null;
		}

		internal static TweenerCore<Color2, Color2, ColorOptions> To(DOGetter<Color2> getter, DOSetter<Color2> setter, Color2 endValue, float duration)
		{
			return null;
		}

		public static Sequence Sequence()
		{
			return null;
		}

		public static int CompleteAll(bool withCallbacks = false)
		{
			return 0;
		}

		public static int Complete(object targetOrId, bool withCallbacks = false)
		{
			return 0;
		}

		internal static int CompleteAndReturnKilledTot()
		{
			return 0;
		}

		internal static int CompleteAndReturnKilledTot(object targetOrId)
		{
			return 0;
		}

		internal static int CompleteAndReturnKilledTotExceptFor(params object[] excludeTargetsOrIds)
		{
			return 0;
		}

		public static int FlipAll()
		{
			return 0;
		}

		public static int Flip(object targetOrId)
		{
			return 0;
		}

		public static int GotoAll(float to, bool andPlay = false)
		{
			return 0;
		}

		public static int Goto(object targetOrId, float to, bool andPlay = false)
		{
			return 0;
		}

		public static int KillAll(bool complete = false)
		{
			return 0;
		}

		public static int KillAll(bool complete, params object[] idsOrTargetsToExclude)
		{
			return 0;
		}

		public static int Kill(object targetOrId, bool complete = false)
		{
			return 0;
		}

		public static int PauseAll()
		{
			return 0;
		}

		public static int Pause(object targetOrId)
		{
			return 0;
		}

		public static int PlayAll()
		{
			return 0;
		}

		public static int Play(object targetOrId)
		{
			return 0;
		}

		public static int Play(object target, object id)
		{
			return 0;
		}

		public static int PlayBackwardsAll()
		{
			return 0;
		}

		public static int PlayBackwards(object targetOrId)
		{
			return 0;
		}

		public static int PlayBackwards(object target, object id)
		{
			return 0;
		}

		public static int PlayForwardAll()
		{
			return 0;
		}

		public static int PlayForward(object targetOrId)
		{
			return 0;
		}

		public static int PlayForward(object target, object id)
		{
			return 0;
		}

		public static int RestartAll(bool includeDelay = true)
		{
			return 0;
		}

		public static int Restart(object targetOrId, bool includeDelay = true, float changeDelayTo = -1f)
		{
			return 0;
		}

		public static int Restart(object target, object id, bool includeDelay = true, float changeDelayTo = -1f)
		{
			return 0;
		}

		public static int RewindAll(bool includeDelay = true)
		{
			return 0;
		}

		public static int Rewind(object targetOrId, bool includeDelay = true)
		{
			return 0;
		}

		public static int SmoothRewindAll()
		{
			return 0;
		}

		public static int SmoothRewind(object targetOrId)
		{
			return 0;
		}

		public static int TogglePauseAll()
		{
			return 0;
		}

		public static int TogglePause(object targetOrId)
		{
			return 0;
		}

		public static bool IsTweening(object targetOrId, bool alsoCheckIfIsPlaying = false)
		{
			return false;
		}

		public static int TotalPlayingTweens()
		{
			return 0;
		}

		public static List<Tween> PlayingTweens()
		{
			return null;
		}

		public static List<Tween> PausedTweens()
		{
			return null;
		}

		public static List<Tween> TweensById(object id, bool playingOnly = false)
		{
			return null;
		}

		public static List<Tween> TweensByTarget(object target, bool playingOnly = false)
		{
			return null;
		}

		private static void InitCheck()
		{
		}

		private static TweenerCore<T1, T2, TPlugOptions> ApplyTo<T1, T2, TPlugOptions>(DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration, ABSTweenPlugin<T1, T2, TPlugOptions> plugin = null) where TPlugOptions : struct, IPlugOptions
		{
			return null;
		}
	}
}
