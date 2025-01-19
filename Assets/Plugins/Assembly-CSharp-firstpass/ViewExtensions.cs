using UnityEngine;

public static class ViewExtensions
{
	public static ViewBase GetView(this GameObject go)
	{
		return null;
	}

	public static T GetView<T>(this GameObject go) where T : class
	{
		return null;
	}

	public static ViewBase GetView(this Collision go)
	{
		return null;
	}

	public static T GetView<T>(this Collision go) where T : class
	{
		return null;
	}

	public static ViewBase GetView(this Transform go)
	{
		return null;
	}

	public static T GetView<T>(this Transform go) where T : class
	{
		return null;
	}

	public static ViewBase GetView(this Collider go)
	{
		return null;
	}

	public static T GetView<T>(this Collider go) where T : class
	{
		return null;
	}

	public static ViewBase GetView(this MonoBehaviour go)
	{
		return null;
	}

	public static T GetView<T>(this MonoBehaviour go) where T : class
	{
		return null;
	}

	public static ViewModel GetViewModel(this GameObject go)
	{
		return null;
	}

	public static T GetViewModel<T>(this GameObject go) where T : class
	{
		return null;
	}

	public static T GetViewModel<T>(this Collision go) where T : class
	{
		return null;
	}

	public static ViewModel GetViewModel(this Transform go)
	{
		return null;
	}

	public static T GetViewModel<T>(this Transform go) where T : class
	{
		return null;
	}

	public static ViewModel GetViewModel(this Collider go)
	{
		return null;
	}

	public static ViewModel GetViewModel(this Collision go)
	{
		return null;
	}

	public static T GetViewModel<T>(this Collider go) where T : class
	{
		return null;
	}

	public static ViewModel GetViewModel(this MonoBehaviour go)
	{
		return null;
	}

	public static T GetViewModel<T>(this MonoBehaviour go) where T : class
	{
		return null;
	}

	public static ViewBase InitializeView(this Transform parent, string name, ViewModel model, GameObject viewObject, string identifier = null)
	{
		return null;
	}

	public static ViewBase InstantiateView(this Transform parent, GameObject prefab, ViewModel model, string identifier = null)
	{
		return null;
	}

	public static ViewBase InstantiateView(this Transform parent, string viewName, ViewModel model, string identifier = null)
	{
		return null;
	}

	public static ViewBase InstantiateView(this Transform parent, string viewName, ViewModel model, Vector3 position, string identifier = null)
	{
		return null;
	}

	public static ViewBase InstantiateView(this Transform parent, string viewName, ViewModel model, Vector3 position, Quaternion rotation, string identifier = null)
	{
		return null;
	}

	public static ViewBase InstantiateView(this Transform parent, GameObject prefab, ViewModel model, Vector3 position, string identifier = null)
	{
		return null;
	}

	public static ViewBase InstantiateView(this Transform parent, GameObject prefab, ViewModel model, Vector3 position, Quaternion rotation, string identifier = null)
	{
		return null;
	}

	public static ViewBase InstantiateView(this Transform parent, ViewModel model, string identifier = null)
	{
		return null;
	}

	public static ViewBase InstantiateView(this Transform parent, ViewModel model, Vector3 position, string identifier = null)
	{
		return null;
	}

	public static ViewBase InstantiateView(this Transform parent, ViewModel model, Vector3 position, Quaternion rotation, string identifier = null)
	{
		return null;
	}

	public static bool IsView<TView>(this Transform go) where TView : ViewBase
	{
		return false;
	}

	public static bool IsView<TView>(this GameObject go) where TView : ViewBase
	{
		return false;
	}
}
