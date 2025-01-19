using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using UnityEngine;

public class ModelViewModelCollectionBinding : Binding
{
	private bool _isImmediate;

	private bool _viewFirst;

	private Dictionary<int, GameObject> _gameObjectLookup;

	private Dictionary<ViewModel, int> _objectIdLookup;

	public INotifyCollectionChanged Collection
	{
		get
		{
			return null;
		}
	}

	public IList List
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

	public Action<ViewBase> OnAddView { get; set; }

	public Func<ViewModel, ViewBase> OnCreateView { get; set; }

	public Action<ViewBase> OnRemoveView { get; set; }

	public Transform Parent { get; set; }

	public string ViewName { get; set; }

	public Dictionary<int, GameObject> GameObjectLookup
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Dictionary<ViewModel, int> ObjectIdLookup
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ViewBase SourceView { get; set; }

	public ModelViewModelCollectionBinding Immediate(bool immediate = true)
	{
		return null;
	}

	public ModelViewModelCollectionBinding SetAddHandler(Action<ViewBase> onAdd)
	{
		return null;
	}

	public ModelViewModelCollectionBinding SetCreateHandler(Func<ViewModel, ViewBase> onCreateView)
	{
		return null;
	}

	public ModelViewModelCollectionBinding SetParent(Transform parent)
	{
		return null;
	}

	public ModelViewModelCollectionBinding SetRemoveHandler(Action<ViewBase> onRemove)
	{
		return null;
	}

	public ModelViewModelCollectionBinding SetView(string viewName)
	{
		return null;
	}

	public override void Unbind()
	{
	}

	protected void AddLookup(GameObject obj, ViewModel viewModel)
	{
	}

	protected void RemoveLookup(ViewModel model)
	{
	}

	public override void Bind()
	{
	}

	private void CollectionOnChanged(NotifyCollectionChangedEventArgs changeArgs)
	{
	}

	public void ViewFirst()
	{
	}
}
