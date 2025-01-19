using System;
using System.Collections;
using UniRx.InternalUtil;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UniRx
{
	public sealed class MainThreadDispatcher : MonoBehaviour
	{
		public enum CullingMode
		{
			Disabled = 0,
			Self = 1,
			All = 2
		}

		public static CullingMode cullingMode;

		private ThreadSafeQueueWorker queueWorker;

		private Action<Exception> unhandledExceptionCallback;

		private static MainThreadDispatcher instance;

		private static bool initialized;

		[ThreadStatic]
		private static object mainThreadToken;

		private Subject<bool> onApplicationFocus;

		private Subject<bool> onApplicationPause;

		private Subject<Unit> onApplicationQuit;

		public static string InstanceName
		{
			get
			{
				return null;
			}
		}

		public static bool IsInitialized
		{
			get
			{
				return false;
			}
		}

		private static MainThreadDispatcher Instance
		{
			get
			{
				return null;
			}
		}

		public static void Post(Action action)
		{
		}

		public static void Send(Action action)
		{
		}

		public static void UnsafeSend(Action action)
		{
		}

		public static void SendStartCoroutine(IEnumerator routine)
		{
		}

		public new static Coroutine StartCoroutine(IEnumerator routine)
		{
			return null;
		}

		public static void RegisterUnhandledExceptionCallback(Action<Exception> exceptionCallback)
		{
		}

		public static void Initialize()
		{
		}

		private void Awake()
		{
		}

		private static void DestroyDispatcher(MainThreadDispatcher aDispatcher)
		{
		}

		public static void CullAllExcessDispatchers()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		private void OnApplicationFocus(bool focus)
		{
		}

		public static IObservable<bool> OnApplicationFocusAsObservable()
		{
			return null;
		}

		private void OnApplicationPause(bool pause)
		{
		}

		public static IObservable<bool> OnApplicationPauseAsObservable()
		{
			return null;
		}

		private void OnApplicationQuit()
		{
		}

		public static IObservable<Unit> OnApplicationQuitAsObservable()
		{
			return null;
		}
	}
}
