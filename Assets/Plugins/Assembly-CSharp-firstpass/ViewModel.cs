using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using UniRx;

[Serializable]
public abstract class ViewModel : IUFSerializable, INotifyPropertyChanged, IObservable<IObservableProperty>, IDisposable, IBindable
{
	private Dictionary<int, List<IDisposable>> _bindings;

	private Dictionary<string, ICommand> _commands;

	private Controller _controller;

	private List<ViewModelPropertyInfo> _modelProperties;

	private string _identifier;

	private bool _bindMemory;

	private bool _isBound;

	[Obsolete]
	public bool Dirty { get; set; }

	public bool BindMemory
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public ViewModelPropertyInfo Item
	{
		get
		{
			return null;
		}
	}

	public Dictionary<int, List<IDisposable>> Bindings
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Obsolete]
	public Dictionary<string, ICommand> Commands
	{
		get
		{
			return null;
		}
	}

	public Controller Controller
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual string Identifier
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public List<ViewModelPropertyInfo> Properties
	{
		get
		{
			return null;
		}
	}

	public int References { get; set; }

	public event PropertyChangedEventHandler PropertyChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	protected ViewModel()
	{
	}

	protected ViewModel(Controller controller, bool initialize = true)
	{
	}

	public virtual void Bind()
	{
	}

	[Obsolete]
	public static Dictionary<string, PropertyInfo> GetReflectedCommands(Type modelType)
	{
		return null;
	}

	[Obsolete]
	public static Dictionary<string, FieldInfo> GetReflectedModelProperties(Type modelType)
	{
		return null;
	}

	public IDisposable AddBinding(IDisposable binding)
	{
		return null;
	}

	public List<ViewModelCommandInfo> GetViewModelCommands()
	{
		return null;
	}

	public List<ViewModelPropertyInfo> GetViewModelProperties()
	{
		return null;
	}

	public virtual void OnPropertyChanged(string propertyName)
	{
	}

	public virtual void OnPropertyChanged(object sender, string propertyName)
	{
	}

	public virtual void Read(ISerializerStream stream)
	{
	}

	public virtual void Write(ISerializerStream stream)
	{
	}

	[Obsolete]
	protected ICommand Command(Action command)
	{
		return null;
	}

	[Obsolete]
	protected ICommand Command(Func<IEnumerator> command)
	{
		return null;
	}

	public IDisposable Subscribe(IObserver<IObservableProperty> observer)
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	public void Dispose()
	{
	}

	public virtual void Unbind()
	{
	}

	protected virtual void FillCommands(List<ViewModelCommandInfo> list)
	{
	}

	protected virtual void FillProperties(List<ViewModelPropertyInfo> list)
	{
	}

	protected virtual void WireCommands(Controller controller)
	{
	}

	private void CacheReflectedModelProperties()
	{
	}
}
