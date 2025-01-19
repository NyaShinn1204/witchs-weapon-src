using UnityEngine;

public abstract class ViewComponent : MonoBehaviour, IBindingProvider
{
	[SerializeField]
	private ViewBase _view;

	public ViewBase View
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual void Awake()
	{
	}

	public virtual void Bind(ViewBase view)
	{
	}

	public virtual void Unbind(ViewBase viewBase)
	{
	}
}
