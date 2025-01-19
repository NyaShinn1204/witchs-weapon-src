using System;
using UnityEngine;

public class ModelViewPropertyBinding : Binding, IDisposable
{
	public Transform Parent { get; set; }

	public string ViewName { get; set; }

	public ViewBase SourceView { get; set; }

	public Func<ModelViewModelCollectionBinding, ViewModel, ViewBase> OnCreateView { get; set; }

	public IDisposable Disposer { get; set; }

	public override void Bind()
	{
	}

	private void PropertyChanged(object objectValue)
	{
	}

	public ModelViewPropertyBinding SetView(string viewName)
	{
		return null;
	}

	public ModelViewPropertyBinding SetParent(Transform parent)
	{
		return null;
	}

	public override void Unbind()
	{
	}
}
