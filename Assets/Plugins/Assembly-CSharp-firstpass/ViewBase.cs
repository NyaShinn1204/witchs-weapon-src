using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UniRx;
using UnityEngine;

public abstract class ViewBase : ViewContainer, IUFSerializable, IBindable
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void ViewEvent(string eventName);

	private Subject<Unit> _updateObservable;

	private Subject<Transform> _transformObservable;

	[HideInInspector]
	public bool _LogEvents;

	private List<IBindingProvider> _bindingProviders;

	private bool _bound;

	private List<ViewBase> _children;

	[SerializeField]
	[HideInInspector]
	private bool _forceResolveViewModel;

	[HideInInspector]
	private string _id;

	[SerializeField]
	[HideInInspector]
	private bool _InjectView;

	private int _instanceId;

	[HideInInspector]
	private ViewModel _Model;

	[SerializeField]
	[HideInInspector]
	private bool _overrideViewModel;

	private ViewBase _parentView;

	private IObservable<Vector3> _positionObservable;

	[SerializeField]
	[HideInInspector]
	private string _resolveName;

	private IObservable<Quaternion> _rotationObservable;

	[SerializeField]
	[HideInInspector]
	private bool _Save;

	private IObservable<Vector3> _scaleObservable;

	[NonSerialized]
	private bool _shouldRebindOnEnable;

	private IObservable<Transform> _transformChangedObservable;

	private int lastCommandHashcode;

	private ICommand lastCommand;

	private List<ICommand> targetCommand;

	private object lastCommandArgument;

	public List<IBindingProvider> BindingProviders
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public List<IDisposable> Bindings
	{
		get
		{
			return null;
		}
	}

	public IEnumerable<ViewModel> ChildViewModels
	{
		get
		{
			return null;
		}
	}

	public List<ViewBase> ChildViews
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual string DefaultIdentifier
	{
		get
		{
			return null;
		}
	}

	public bool ForceResolveViewModel
	{
		get
		{
			return false;
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

	public bool InjectView
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int InstanceId
	{
		get
		{
			return 0;
		}
	}

	public bool Instantiated { get; set; }

	public bool IsBound
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	[Obsolete]
	public virtual bool IsMultiInstance
	{
		get
		{
			return false;
		}
	}

	public bool OverrideViewModel
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public ViewBase ParentView
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ViewModel ParentViewModel
	{
		get
		{
			return null;
		}
	}

	public bool Save
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public SceneManager SceneManager
	{
		get
		{
			return null;
		}
	}

	public virtual ViewModel ViewModelObject
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public abstract Type ViewModelType { get; }

	public IObservable<Vector3> PositionAsObservable
	{
		get
		{
			return null;
		}
	}

	public IObservable<Vector3> LocalPositionAsObservable
	{
		get
		{
			return null;
		}
	}

	public IObservable<Quaternion> LocalRotationAsObservable
	{
		get
		{
			return null;
		}
	}

	public IObservable<Quaternion> RotationAsObservable
	{
		get
		{
			return null;
		}
	}

	public IObservable<Vector3> ScaleAsObservable
	{
		get
		{
			return null;
		}
	}

	public string ViewName { get; set; }

	public Subject<Transform> TransformChangedObservable
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool Initialized { get; set; }

	public T AddComponentBinding<T>() where T : ObservableComponent
	{
		return null;
	}

	public IDisposable AddComponentBinding(ObservableComponent component)
	{
		return null;
	}

	public virtual void Update()
	{
	}

	public IObservable<Unit> UpdateAsObservable()
	{
		return null;
	}

	public IDisposable AddBinding(IDisposable binding)
	{
		return null;
	}

	public virtual void AfterBind()
	{
	}

	public virtual void Awake()
	{
	}

	public virtual void Bind()
	{
	}

	public abstract ViewModel CreateModel();

	private void AddType4OrNothing<TArgument>(ICommandWith<TArgument> command)
	{
	}

	public void ExecuteCommand(ICommand command, object argument)
	{
	}

	public virtual void ExecuteCommand(ICommand command)
	{
	}

	public void ExecuteCommand<TArgument>(ICommandWith<TArgument> command, ViewModel sender, TArgument argument)
	{
	}

	public void ExecuteCommand<TArgument>(ICommandWith<TArgument> command, TArgument argument)
	{
	}

	public void InitializeData(ViewModel model)
	{
	}

	public virtual void OnDestroy()
	{
	}

	public virtual void OnDisable()
	{
	}

	public virtual void OnEnable()
	{
	}

	public void SetupBindings()
	{
	}

	public virtual void Start()
	{
	}

	public virtual void Unbind()
	{
	}

	public virtual void Write(ISerializerStream stream)
	{
	}

	public virtual void Read(ISerializerStream stream)
	{
	}

	[Obsolete]
	protected virtual void Apply()
	{
	}

	protected abstract void InitializeViewModel(ViewModel model);

	public virtual void LateUpdate()
	{
	}

	protected virtual void PreBind()
	{
	}

	protected virtual ViewBase ReplaceView(ViewBase current, ViewModel value, GameObject prefab)
	{
		return null;
	}

	protected ViewModel RequestViewModel(Controller controller)
	{
		return null;
	}
}
