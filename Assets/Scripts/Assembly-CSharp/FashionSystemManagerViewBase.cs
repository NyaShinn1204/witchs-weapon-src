using System;

public abstract class FashionSystemManagerViewBase : ViewBase
{
	public override string DefaultIdentifier
	{
		get
		{
			return null;
		}
	}

	public override Type ViewModelType
	{
		get
		{
			return null;
		}
	}

	public FashionSystemManagerViewModel FashionSystemManager
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

	public virtual void ExecuteSelectFashion(long arg)
	{
	}

	public virtual void ExecuteBuyFashion(long arg)
	{
	}

	public virtual void ExecuteRefreshFashion()
	{
	}

	public virtual void ExecuteFinishRefresh()
	{
	}
}
