using System;

public abstract class NewExternalElementGraphViewBase : ViewBase
{
	public override Type ViewModelType
	{
		get
		{
			return null;
		}
	}

	public NewExternalElementGraphViewModel NewExternalElementGraph
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
