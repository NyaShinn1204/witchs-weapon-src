using System.Collections.Generic;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Options;

namespace DG.Tweening.Core
{
	internal static class TweenManager
	{
		internal enum CapacityIncreaseMode
		{
			TweenersAndSequences = 0,
			TweenersOnly = 1,
			SequencesOnly = 2
		}

		private const int _DefaultMaxTweeners = 200;

		private const int _DefaultMaxSequences = 50;

		private const string _MaxTweensReached = "Max Tweens reached: capacity has automatically been increased from #0 to #1. Use DOTween.SetTweensCapacity to set it manually at startup";

		internal static int maxActive;

		internal static int maxTweeners;

		internal static int maxSequences;

		internal static bool hasActiveTweens;

		internal static bool hasActiveDefaultTweens;

		internal static bool hasActiveLateTweens;

		internal static bool hasActiveFixedTweens;

		internal static bool hasActiveManualTweens;

		internal static int totActiveTweens;

		internal static int totActiveDefaultTweens;

		internal static int totActiveLateTweens;

		internal static int totActiveFixedTweens;

		internal static int totActiveManualTweens;

		internal static int totActiveTweeners;

		internal static int totActiveSequences;

		internal static int totPooledTweeners;

		internal static int totPooledSequences;

		internal static int totTweeners;

		internal static int totSequences;

		internal static bool isUpdateLoop;

		internal static Tween[] _activeTweens;

		private static Tween[] _pooledTweeners;

		private static readonly Stack<Tween> _PooledSequences;

		private static readonly List<Tween> _KillList;

		private static int _maxActiveLookupId;

		private static bool _requiresActiveReorganization;

		private static int _reorganizeFromId;

		private static int _minPooledTweenerId;

		private static int _maxPooledTweenerId;

		private static bool _despawnAllCalledFromUpdateLoopCallback;

		internal static TweenerCore<T1, T2, TPlugOptions> GetTweener<T1, T2, TPlugOptions>() where TPlugOptions : struct, IPlugOptions
		{
			return null;
		}

		internal static Sequence GetSequence()
		{
			return null;
		}

		internal static void SetUpdateType(Tween t, UpdateType updateType, bool isIndependentUpdate)
		{
		}

		internal static void AddActiveTweenToSequence(Tween t)
		{
		}

		internal static int DespawnAll()
		{
			return 0;
		}

		internal static void Despawn(Tween t, bool modifyActiveLists = true)
		{
		}

		internal static void PurgeAll()
		{
		}

		internal static void PurgePools()
		{
		}

		internal static void ResetCapacities()
		{
		}

		internal static void SetCapacities(int tweenersCapacity, int sequencesCapacity)
		{
		}

		internal static int Validate()
		{
			return 0;
		}

		internal static void Update(UpdateType updateType, float deltaTime, float independentTime)
		{
		}

		internal static int FilteredOperation(OperationType operationType, FilterType filterType, object id, bool optionalBool, float optionalFloat, object optionalObj = null, object[] optionalArray = null)
		{
			return 0;
		}

		internal static bool Complete(Tween t, bool modifyActiveLists = true, UpdateMode updateMode = UpdateMode.Goto)
		{
			return false;
		}

		internal static bool Flip(Tween t)
		{
			return false;
		}

		internal static void ForceInit(Tween t, bool isSequenced = false)
		{
		}

		internal static bool Goto(Tween t, float to, bool andPlay = false, UpdateMode updateMode = UpdateMode.Goto)
		{
			return false;
		}

		internal static bool Pause(Tween t)
		{
			return false;
		}

		internal static bool Play(Tween t)
		{
			return false;
		}

		internal static bool PlayBackwards(Tween t)
		{
			return false;
		}

		internal static bool PlayForward(Tween t)
		{
			return false;
		}

		internal static bool Restart(Tween t, bool includeDelay = true, float changeDelayTo = -1f)
		{
			return false;
		}

		internal static bool Rewind(Tween t, bool includeDelay = true)
		{
			return false;
		}

		internal static bool SmoothRewind(Tween t)
		{
			return false;
		}

		internal static bool TogglePause(Tween t)
		{
			return false;
		}

		internal static int TotalPooledTweens()
		{
			return 0;
		}

		internal static int TotalPlayingTweens()
		{
			return 0;
		}

		internal static List<Tween> GetActiveTweens(bool playing)
		{
			return null;
		}

		internal static List<Tween> GetTweensById(object id, bool playingOnly)
		{
			return null;
		}

		internal static List<Tween> GetTweensByTarget(object target, bool playingOnly)
		{
			return null;
		}

		private static void MarkForKilling(Tween t)
		{
		}

		private static void AddActiveTween(Tween t)
		{
		}

		private static void ReorganizeActiveTweens()
		{
		}

		private static void DespawnActiveTweens(List<Tween> tweens)
		{
		}

		private static void RemoveActiveTween(Tween t)
		{
		}

		private static void ClearTweenArray(Tween[] tweens)
		{
		}

		private static void IncreaseCapacities(CapacityIncreaseMode increaseMode)
		{
		}
	}
}
