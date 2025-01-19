using System;
using System.Collections.Specialized;

public class ModelCollectionBinding<TCollectionType> : Binding
{
	private bool _isImmediate;

	public ModelCollection<TCollectionType> Collection
	{
		get
		{
			return null;
		}
	}

	public bool IsImmediate
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Action<TCollectionType> OnAdd { get; set; }

	public Action<TCollectionType> OnRemove { get; set; }

	public override void Bind()
	{
	}

	public void Immediate()
	{
	}

	public ModelCollectionBinding<TCollectionType> SetAddHandler(Action<TCollectionType> onAddHandler)
	{
		return null;
	}

	public ModelCollectionBinding<TCollectionType> SetRemoveHandler(Action<TCollectionType> onRemoveHandler)
	{
		return null;
	}

	public override void Unbind()
	{
	}

	private void BindNow()
	{
	}

	private void CollectionOnChanged(NotifyCollectionChangedEventArgs changeArgs)
	{
	}
}
