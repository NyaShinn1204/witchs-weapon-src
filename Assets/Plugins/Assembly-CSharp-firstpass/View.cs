using System;

public abstract class View<TModel> : ViewBase where TModel : ViewModel, new()
{
	public TModel Model
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public override Type ViewModelType
	{
		get
		{
			return null;
		}
	}

	protected sealed override void InitializeViewModel(ViewModel model)
	{
	}

	protected virtual void InitializeViewModel(TModel viewModel)
	{
	}
}
