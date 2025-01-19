using System;
using System.Collections.Generic;

[Obsolete]
public class SceneContext
{
	private IGameContainer _container;

	private Dictionary<string, ViewModel> _viewModels;

	private Dictionary<string, ViewModel> _persitantViewModels;

	public ViewModel Item
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ViewModel Item
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

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

	public Dictionary<string, ViewModel> ViewModels
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Dictionary<string, ViewModel> PersitantViewModels
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public SceneContext()
	{
	}

	public SceneContext(IGameContainer gameContainer)
	{
	}

	public TViewModel CreateViewModel<TViewModel>(Controller controller, string identifier) where TViewModel : ViewModel, new()
	{
		return null;
	}

	public void Load(ISerializerStorage storage, ISerializerStream stream)
	{
	}

	public void Save(ISerializerStorage storage, ISerializerStream stream, IEnumerable<ViewModel> viewModels = null)
	{
	}

	public void Clear()
	{
	}
}
