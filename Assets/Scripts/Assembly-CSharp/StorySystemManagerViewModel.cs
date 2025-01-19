using System.Collections.Generic;

public class StorySystemManagerViewModel : StorySystemManagerViewModelBase
{
	public virtual P<long> CurrentUnlockStoryGroupProperty
	{
		get
		{
			return null;
		}
	}

	public virtual long CurrentUnlockStoryGroup
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual P<long> CurrentUnlockStoryProperty
	{
		get
		{
			return null;
		}
	}

	public virtual long CurrentUnlockStory
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual P<long> CurrentCanUnlockStoryProperty
	{
		get
		{
			return null;
		}
	}

	public virtual long CurrentCanUnlockStory
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<StorySystemManagerViewModel, long> NoticeStoryGroupUnlock
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<StorySystemManagerViewModel, long> NoticeStorynlock
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<StorySystemManagerViewModel, long> NoticeStoryCanUnlock
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<StorySystemManagerViewModel, long> BuyStory
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<StorySystemManagerViewModel> FinishBuyStory
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<StorySystemManagerViewModel, long> BuyStoryByItem
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSender<StorySystemManagerViewModel> FinishBuyStoryByItem
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public StorySystemManagerViewModel(StorySystemManagerControllerBase controller, bool initialize = true)
		: base(null, false)
	{
	}

	public StorySystemManagerViewModel()
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
}
