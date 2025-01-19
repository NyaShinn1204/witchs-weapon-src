using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

public abstract class SceneManager : ViewContainer, ITypeResolver
{
	private List<ViewBase> _rootViews;

	private List<ViewModel> _viewModels;

	[Inject]
	public ICommandDispatcher CommandDispatcher { get; set; }

	public IGameContainer Container
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static ISwitchLevelSettings Settings
	{
		get
		{
			return null;
		}
	}

	public List<ViewBase> PersistantViews
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public List<ViewModel> PersistantViewModels
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[DebuggerHidden]
	public virtual IEnumerator Load(UpdateProgressDelegate progress)
	{
		return null;
	}

	public virtual void OnLoaded()
	{
	}

	public virtual void OnLoading()
	{
	}

	public virtual void Reload()
	{
	}

	public virtual void Setup()
	{
	}

	public virtual void Unload()
	{
	}

	protected virtual void Awake()
	{
	}

	protected virtual void OnDestroy()
	{
	}

	public TViewModel SetupViewModel<TViewModel>(Controller controller, string identifier) where TViewModel : ViewModel
	{
		return null;
	}

	public TViewModel CreateInstanceViewModel<TViewModel>(Controller controller, string identifier) where TViewModel : ViewModel
	{
		return null;
	}

	public void LoadState(ISerializerStorage storage, ISerializerStream stream)
	{
	}

	private void VoidMethod(object p)
	{
	}

	public void SaveState(ISerializerStorage storage, ISerializerStream stream)
	{
	}

	public void RegisterView(ViewBase view, ViewModel viewModel = null)
	{
	}

	public ViewModel RequestViewModel(ViewBase viewBase, Controller controller)
	{
		return null;
	}

	protected virtual ViewBase ViewNotFoundOnLoad(string typeName, string identifier)
	{
		return null;
	}

	public virtual void Initialize()
	{
	}

	Type ITypeResolver.GetType(string name)
	{
		return null;
	}

	string ITypeResolver.SetType(Type type)
	{
		return null;
	}

	object ITypeResolver.CreateInstance(string name, string identifier)
	{
		return null;
	}

	public void UnRegisterView(ViewBase viewBase)
	{
	}
}
