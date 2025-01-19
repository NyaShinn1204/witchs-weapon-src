using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UniRx;
using UnityEngine;

public static class ViewBindings
{
	[Obsolete]
	public static ModelCollectionBinding<TCollectionItemType> BindCollection<TCollectionItemType>(this ViewModel t, ModelCollection<TCollectionItemType> collectionSelector)
	{
		return null;
	}

	public static IDisposable BindCollection<TCollectionItemType>(this IBindable t, ObservableCollection<TCollectionItemType> collection, Action<TCollectionItemType> added, Action<TCollectionItemType> removed)
	{
		return null;
	}

	[Obsolete]
	public static ModelCollectionBinding<TCollectionItemType> BindCollection<TCollectionItemType>(this ViewBase t, Func<ModelCollection<TCollectionItemType>> collectionSelector)
	{
		return null;
	}

	public static IDisposable BindCollision(this ViewBase t, CollisionEventType eventType, Action<Collision> action)
	{
		return null;
	}

	public static IObservable<Collision> OnCollisionObservable(this GameObject t, CollisionEventType eventType)
	{
		return null;
	}

	public static IObservable<Collision2D> OnCollision2DObservable(this GameObject t, CollisionEventType eventType)
	{
		return null;
	}

	public static IObservable<Collider> OnTriggerObservable(this GameObject t, CollisionEventType eventType)
	{
		return null;
	}

	public static IObservable<Collider2D> OnTrigger2DObservable(this GameObject t, CollisionEventType eventType)
	{
		return null;
	}

	public static T EnsureComponent<T>(this GameObject t) where T : MonoBehaviour
	{
		return null;
	}

	public static IDisposable BindViewCollision(this ViewBase t, CollisionEventType eventType, Action<ViewBase> collision)
	{
		return null;
	}

	public static IDisposable BindViewCollisionWith<T>(this ViewBase t, CollisionEventType eventType, Action<T> collision) where T : ViewBase
	{
		return null;
	}

	public static IObservable<ViewBase> OnViewCollision(this GameObject t, CollisionEventType eventType)
	{
		return null;
	}

	public static IObservable<T> OnViewCollisionWith<T>(this GameObject t, CollisionEventType eventType) where T : ViewBase
	{
		return null;
	}

	public static IDisposable BindInputButton(this ViewBase t, ICommand commandSelector, string buttonName, InputButtonEventType buttonEventType = InputButtonEventType.ButtonDown)
	{
		return null;
	}

	public static IDisposable BindKey(this ViewBase t, ICommand commandSelector, KeyCode key, object parameter = null)
	{
		return null;
	}

	public static IObservable<T> ScreenToRaycastAsObservable<T>(this ViewBase t, Func<RaycastHit, T> onHit)
	{
		return null;
	}

	public static IObservable<Unit> OnMouseEvent(this ViewBase view, MouseEventType eventType)
	{
		return null;
	}

	public static IObservable<Unit> OnDestroyObservable(this GameObject gameObject)
	{
		return null;
	}

	public static IDisposable DisposeWith(this IDisposable disposable, GameObject gameObject)
	{
		return null;
	}

	public static IDisposable DisposeWith(this IDisposable disposable, IBindable bindable)
	{
		return null;
	}

	public static IDisposable DisposeWhenChanged<T>(this IDisposable disposable, P<T> sourceProperty, bool onlyWhenChanged = true)
	{
		return null;
	}

	public static IDisposable BindProperty<TBindingType>(this IBindable bindable, P<TBindingType> sourceProperty, Action<TBindingType> targetSetter, bool onlyWhenChanged = true)
	{
		return null;
	}

	public static IDisposable BindCommandExecuted(this IBindable bindable, ICommand sourceCommand, Action onExecuted)
	{
		return null;
	}

	[Obsolete]
	public static IDisposable BindProperty<TBindingType>(this IBindable bindable, Func<P<TBindingType>> sourceProperty, Action<TBindingType> targetSetter)
	{
		return null;
	}

	[Obsolete]
	public static IDisposable BindProperty<TBindingType>(this IBindable bindable, Func<Computed<TBindingType>> sourceProperty, Action<TBindingType> targetSetter)
	{
		return null;
	}

	[Obsolete]
	public static ModelViewModelCollectionBinding BindToViewCollection<TView, TViewModelType>(this ViewBase view, Func<ModelCollection<TViewModelType>> sourceViewModelCollection, ICollection<TView> viewCollection, bool viewFirst = false) where TView : ViewBase where TViewModelType : ViewModel
	{
		return null;
	}

	[Obsolete]
	public static ModelViewPropertyBinding BindToView<TBindingType>(this ViewBase view, Func<P<TBindingType>> sourceViewModelSelector, Action<ViewBase> setLocal = null, Func<ViewBase> getLocal = null) where TBindingType : ViewModel
	{
		return null;
	}

	public static ModelViewModelCollectionBinding BindToViewCollection<TCollectionType>(this ViewBase view, Func<ModelCollection<TCollectionType>> viewModelCollection, Func<ViewModel, ViewBase> createView, Action<ViewBase> added, Action<ViewBase> removed, Transform parent, bool viewFirst = false)
	{
		return null;
	}

	public static ModelViewModelCollectionBinding BindToViewCollection<TCollectionType>(this ViewBase view, ModelCollection<TCollectionType> viewModelCollection, Func<ViewModel, ViewBase> createView, Action<ViewBase> added, Action<ViewBase> removed, Transform parent, bool viewFirst = false)
	{
		return null;
	}

	[Obsolete]
	public static ModelViewModelCollectionBinding BindToViewCollection<TCollectionType>(this ViewBase view, Func<ModelCollection<TCollectionType>> viewModelCollection, bool viewFirst = false)
	{
		return null;
	}
}
