using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UniRx;
using UnityEngine;

public class GameManager : MonoBehaviour, ICommandDispatcher, IObservable<CommandInfo>
{
	public bool _DontUseAsyncLoading;

	public string _LoadingLevel;

	public bool _ShowLogs;

	public SceneManager _Start;

	public string _StartupScene;

	private static SceneManager _activeSceneManager;

	private static IGameContainer _container;

	private static LevelLoadViewModel _loadingViewModel;

	private static LevelLoadViewModel _progress;

	private static IViewResolver _viewResolver;

	private static ICommandDispatcher _commandDispatcher;

	private List<SceneManager> _sceneManagers;

	private SimpleSubject<CommandInfo> _commandsAsObservable;

	public static SceneManager ActiveSceneManager
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public static IGameContainer Container
	{
		get
		{
			return null;
		}
	}

	public static IViewResolver ViewResolver
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static ICommandDispatcher CommandDispatcher
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static GameManager Instance { get; set; }

	public static bool IsPro
	{
		get
		{
			return false;
		}
	}

	public static LevelLoadViewModel LoadingViewModel
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static LevelLoadViewModel Progress
	{
		get
		{
			return null;
		}
	}

	public static ISwitchLevelSettings SwitchLevelSettings { get; set; }

	public Type ContainerType { get; set; }

	public List<SceneManager> SceneManagers
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public IObservable<CommandInfo> CommandsAsObservable
	{
		get
		{
			return null;
		}
	}

	public void Reset()
	{
	}

	public static void Dispose()
	{
	}

	[DebuggerHidden]
	public static IEnumerator Load()
	{
		return null;
	}

	public static void Log(string message, UnityEngine.Object obj = null)
	{
	}

	public static void ProgressUpdated(string message, float progress)
	{
	}

	[Obsolete]
	public static Coroutine SwitchGame<T>(Action<T> setup, UpdateProgressDelegate progress = null) where T : SceneManager
	{
		return null;
	}

	[Obsolete]
	public static Coroutine SwitchGameAndLevel<TGame>(TGame controller, Action<TGame> setup = null, UpdateProgressDelegate progress = null) where TGame : SceneManager
	{
		return null;
	}

	[Obsolete]
	public static void SwitchGameAndLevel<T>(SwitchLevelSettings<T> settings) where T : SceneManager
	{
	}

	[Obsolete]
	public static void SwitchGameAndLevel<T>(Action<T> setup, params string[] levels) where T : SceneManager
	{
	}

	public static Coroutine Transition<T>(Action<T> setup, UpdateProgressDelegate progress = null) where T : SceneManager
	{
		return null;
	}

	public static Coroutine Transition<TSceneManager>(TSceneManager sceneManager, Action<TSceneManager> setup = null, UpdateProgressDelegate progress = null) where TSceneManager : SceneManager
	{
		return null;
	}

	public static void TransitionLevel<T>(SwitchLevelSettings<T> settings) where T : SceneManager
	{
	}

	public static void TransitionLevel<T>(Action<T> setup, params string[] levels) where T : SceneManager
	{
	}

	public void Awake()
	{
	}

	public void OnDestroy()
	{
	}

	public virtual void RegisterSceneManager(SceneManager sceneManager)
	{
	}

	public void Start()
	{
	}

	protected virtual void Startup()
	{
	}

	public virtual void UnRegisterSceneManager(SceneManager sceneManager)
	{
	}

	protected static void DefaultUpdateProgress(string message, float progress)
	{
	}

	[DebuggerHidden]
	private static IEnumerator LoadSceneManager(UpdateProgressDelegate progress)
	{
		return null;
	}

	public void ExecuteCommand(ICommand command, object argument, bool isChained = false)
	{
	}

	public IDisposable Subscribe(IObserver<CommandInfo> observer)
	{
		return null;
	}
}
