using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class ViewContainer : MonoBehaviour
{
	public virtual TView CreateView<TView>() where TView : ViewBase
	{
		return null;
	}

	public virtual TView CreateView<TView>(ViewModel model) where TView : ViewBase
	{
		return null;
	}

	public virtual TView CreateView<TView>(ViewModel model, Vector3 position) where TView : ViewBase
	{
		return null;
	}

	public virtual TView CreateView<TView>(ViewModel model, Vector3 position, Quaternion rotation) where TView : ViewBase
	{
		return null;
	}

	public ViewBase InstantiateView(ViewModel model)
	{
		return null;
	}

	public ViewBase InstantiateView(ViewModel model, Vector3 position)
	{
		return null;
	}

	public ViewBase InstantiateView(ViewModel model, Vector3 position, Quaternion rotation)
	{
		return null;
	}

	public ViewBase InstantiateView(GameObject prefab, ViewModel model)
	{
		return null;
	}

	public ViewBase InstantiateView(GameObject prefab, ViewModel model, Vector3 position)
	{
		return null;
	}

	public ViewBase InstantiateView(string viewName, string identifier = null)
	{
		return null;
	}

	public ViewBase InstantiateView(string viewName, ViewModel model, string identifier = null)
	{
		return null;
	}

	public ViewBase InstantiateView(string viewName, Vector3 position, string identifier = null)
	{
		return null;
	}

	public ViewBase InstantiateView(string viewName, ViewModel model, Vector3 position, string identifier = null)
	{
		return null;
	}

	public ViewBase InstantiateView(string viewName, ViewModel model, Vector3 position, Quaternion rotation, string identifier = null)
	{
		return null;
	}

	public ViewBase InstantiateView(GameObject prefab, ViewModel model, Vector3 position, Quaternion rotation, string identifier = null)
	{
		return null;
	}

	public Coroutine LoadAdditive(string rootObjectName, string levelName, Action<GameObject> complete = null)
	{
		return null;
	}

	[DebuggerHidden]
	private IEnumerator LoadAdditiveInternal(string rootObjectName, string levelName, Action<GameObject> complete)
	{
		return null;
	}
}
