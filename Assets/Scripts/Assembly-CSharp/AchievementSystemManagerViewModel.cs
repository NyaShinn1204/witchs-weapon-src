using System.Collections.Generic;
using System.Collections.Specialized;

public class AchievementSystemManagerViewModel : AchievementSystemManagerViewModelBase
{
	public virtual P<int> ReceiveResultProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int ReceiveResult
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual ModelCollection<AchievementInProgressViewModel> Achievements
	{
		get
		{
			return null;
		}
	}

	public virtual ModelCollection<AchievementCompleteViewModel> FinishAchievements
	{
		get
		{
			return null;
		}
	}

	public virtual ModelCollection<DrawResultData> Loots
	{
		get
		{
			return null;
		}
	}

	public virtual CommandWithSenderAndArgument<AchievementSystemManagerViewModel, long> GetReward
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<AchievementSystemManagerViewModel> FinishGetReward
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public AchievementSystemManagerViewModel(AchievementSystemManagerControllerBase controller, bool initialize = true)
		: base(null, false)
	{
	}

	public AchievementSystemManagerViewModel()
		: base(null, false)
	{
	}

	protected override void WireCommands(Controller controller)
	{
	}

	public override void Write(ISerializerStream stream)
	{
	}

	public override void Read(ISerializerStream stream)
	{
	}

	public override void Unbind()
	{
	}

	protected override void FillProperties(List<ViewModelPropertyInfo> list)
	{
	}

	protected override void FillCommands(List<ViewModelCommandInfo> list)
	{
	}

	protected override void AchievementsCollectionChanged(NotifyCollectionChangedEventArgs args)
	{
	}

	protected override void FinishAchievementsCollectionChanged(NotifyCollectionChangedEventArgs args)
	{
	}
}
