public class StorySystemManagerViewModelBase : ViewModel
{
	public P<long> _CurrentUnlockStoryGroupProperty;

	public P<long> _CurrentUnlockStoryProperty;

	public P<long> _CurrentCanUnlockStoryProperty;

	protected CommandWithSenderAndArgument<StorySystemManagerViewModel, long> _NoticeStoryGroupUnlock;

	protected CommandWithSenderAndArgument<StorySystemManagerViewModel, long> _NoticeStorynlock;

	protected CommandWithSenderAndArgument<StorySystemManagerViewModel, long> _NoticeStoryCanUnlock;

	protected CommandWithSenderAndArgument<StorySystemManagerViewModel, long> _BuyStory;

	protected CommandWithSender<StorySystemManagerViewModel> _FinishBuyStory;

	protected CommandWithSenderAndArgument<StorySystemManagerViewModel, long> _BuyStoryByItem;

	protected CommandWithSender<StorySystemManagerViewModel> _FinishBuyStoryByItem;

	public StorySystemManagerViewModelBase(StorySystemManagerControllerBase controller, bool initialize = true)
	{
	}

	public StorySystemManagerViewModelBase()
	{
	}

	public override void Bind()
	{
	}
}
