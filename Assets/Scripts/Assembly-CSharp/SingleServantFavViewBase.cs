using System;

public abstract class SingleServantFavViewBase : ViewBase
{
	public override Type ViewModelType
	{
		get
		{
			return null;
		}
	}

	public SingleServantFavViewModel SingleServantFav
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public override ViewModel CreateModel()
	{
		return null;
	}

	protected override void InitializeViewModel(ViewModel viewModel)
	{
	}
}
