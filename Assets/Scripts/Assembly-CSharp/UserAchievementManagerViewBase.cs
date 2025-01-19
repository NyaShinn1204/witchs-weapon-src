using System;

public abstract class UserAchievementManagerViewBase : ViewBase
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

	public UserAchievementManagerViewModel UserAchievementManager
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

	public virtual void ExecuteGetRewardChange(long arg)
	{
	}

	public virtual void ExecuteRefreshAchieve()
	{
	}
}
