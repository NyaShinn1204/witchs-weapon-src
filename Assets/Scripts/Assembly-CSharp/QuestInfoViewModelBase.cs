public class QuestInfoViewModelBase : ViewModel
{
	public P<long> _IDProperty;

	public P<int> _StatusProperty;

	public P<int> _ValidProperty;

	public P<int> _MetaProperty;

	public P<QuestData> _InfoProperty;

	public P<bool> _GuideProperty;

	public QuestInfoViewModelBase(QuestInfoControllerBase controller, bool initialize = true)
	{
	}

	public QuestInfoViewModelBase()
	{
	}

	public override void Bind()
	{
	}
}
