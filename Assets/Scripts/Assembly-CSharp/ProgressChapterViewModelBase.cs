using System.Collections.Specialized;

public class ProgressChapterViewModelBase : ViewModel
{
	public P<long> _ChapterIdProperty;

	public P<int> _EnterCountsProperty;

	public P<bool> _IsLockProperty;

	public P<string> _ChapterNameProperty;

	public P<int> _EnterCountMaxProperty;

	public P<int> _ChapterTypeProperty;

	public ModelCollection<ProgressLevelViewModel> _NormalLevelsProperty;

	public ModelCollection<ProgressLevelViewModel> _EliteLevelsProperty;

	public ProgressChapterViewModelBase(ProgressChapterControllerBase controller, bool initialize = true)
	{
	}

	public ProgressChapterViewModelBase()
	{
	}

	public override void Bind()
	{
	}

	protected virtual void NormalLevelsCollectionChanged(NotifyCollectionChangedEventArgs args)
	{
	}

	protected virtual void EliteLevelsCollectionChanged(NotifyCollectionChangedEventArgs args)
	{
	}
}
