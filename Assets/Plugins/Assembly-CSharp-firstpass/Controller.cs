using System;
using System.Collections;
using UnityEngine;

public abstract class Controller
{
	[Inject]
	public ICommandDispatcher CommandDispatcher { get; set; }

	public IGameContainer Container { get; set; }

	public virtual ViewModel Create()
	{
		return null;
	}

	public virtual ViewModel Create(string identifier)
	{
		return null;
	}

	public virtual ViewModel CreateEmpty(string identifier)
	{
		return null;
	}

	public virtual ViewModel CreateEmpty()
	{
		return null;
	}

	[Obsolete]
	public void GameEvent(string name)
	{
	}

	public abstract void Initialize(ViewModel viewModel);

	[Obsolete]
	public virtual void WireCommands(ViewModel viewModel)
	{
	}

	public void ExecuteCommand(ICommand command, object argument)
	{
	}

	public virtual void ExecuteCommand(ICommand command)
	{
	}

	public void ExecuteCommand<TArgument>(ICommandWith<TArgument> command, TArgument argument)
	{
	}

	[Obsolete]
	public Coroutine StartCoroutine(IEnumerator routine)
	{
		return null;
	}

	[Obsolete]
	public void StopAllCoroutines()
	{
	}

	[Obsolete]
	public void StopCoroutine(string name)
	{
	}

	[Obsolete]
	public ModelPropertyBinding SubscribeToProperty<TViewModel, TBindingType>(TViewModel source, P<TBindingType> sourceProperty, Action<TViewModel, TBindingType> changedAction) where TViewModel : ViewModel
	{
		return null;
	}

	[Obsolete]
	public ModelPropertyBinding SubscribeToProperty<TBindingType>(P<TBindingType> sourceProperty, Action<TBindingType> targetSetter)
	{
		return null;
	}

	protected void SubscribeToCommand(ICommand command, Action action)
	{
	}
}
