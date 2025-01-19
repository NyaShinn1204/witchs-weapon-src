using System;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;

namespace DG.Tweening
{
	public abstract class Tween : ABSSequentiable
	{
		public float timeScale;

		public bool isBackwards;

		public object id;

		public object target;

		internal UpdateType updateType;

		internal bool isIndependentUpdate;

		public TweenCallback onPlay;

		public TweenCallback onPause;

		public TweenCallback onRewind;

		public TweenCallback onUpdate;

		public TweenCallback onStepComplete;

		public TweenCallback onComplete;

		public TweenCallback onKill;

		public TweenCallback<int> onWaypointChange;

		internal bool isFrom;

		internal bool isBlendable;

		internal bool isRecyclable;

		internal bool isSpeedBased;

		internal bool autoKill;

		internal float duration;

		internal int loops;

		internal LoopType loopType;

		internal float delay;

		internal bool isRelative;

		internal Ease easeType;

		internal EaseFunction customEase;

		public float easeOvershootOrAmplitude;

		public float easePeriod;

		internal Type typeofT1;

		internal Type typeofT2;

		internal Type typeofTPlugOptions;

		internal bool active;

		internal bool isSequenced;

		internal Sequence sequenceParent;

		internal int activeId;

		internal SpecialStartupMode specialStartupMode;

		internal bool creationLocked;

		internal bool startupDone;

		internal bool playedOnce;

		internal float position;

		internal float fullDuration;

		internal int completedLoops;

		internal bool isPlaying;

		internal bool isComplete;

		internal float elapsedDelay;

		internal bool delayComplete;

		internal int miscInt;

		public float fullPosition
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		internal virtual void Reset()
		{
		}

		internal abstract bool Validate();

		internal virtual float UpdateDelay(float elapsed)
		{
			return 0f;
		}

		internal abstract bool Startup();

		internal abstract bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode, UpdateNotice updateNotice);

		internal static bool DoGoto(Tween t, float toPosition, int toCompletedLoops, UpdateMode updateMode)
		{
			return false;
		}

		internal static bool OnTweenCallback(TweenCallback callback)
		{
			return false;
		}

		internal static bool OnTweenCallback<T>(TweenCallback<T> callback, T param)
		{
			return false;
		}
	}
}
