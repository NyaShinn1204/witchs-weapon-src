using System.Collections.Generic;
using System.Collections.Specialized;

public class ProgressChapterViewModel : ProgressChapterViewModelBase
{
	private ProgressSystemManagerViewModel _ParentProgressSystemManager;

	public virtual P<long> ChapterIdProperty
	{
		get
		{
			return null;
		}
	}

	public virtual long ChapterId
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual P<int> EnterCountsProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int EnterCounts
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual P<bool> IsLockProperty
	{
		get
		{
			return null;
		}
	}

	public virtual bool IsLock
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual P<string> ChapterNameProperty
	{
		get
		{
			return null;
		}
	}

	public virtual string ChapterName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual P<int> EnterCountMaxProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int EnterCountMax
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual P<int> ChapterTypeProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int ChapterType
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual ModelCollection<ProgressLevelViewModel> NormalLevels
	{
		get
		{
			return null;
		}
	}

	public virtual ModelCollection<ProgressLevelViewModel> EliteLevels
	{
		get
		{
			return null;
		}
	}

	public virtual ProgressSystemManagerViewModel ParentProgressSystemManager
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ProgressChapterViewModel(ProgressChapterControllerBase controller, bool initialize = true)
		: base(null, false)
	{
	}

	public ProgressChapterViewModel()
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

	protected override void NormalLevelsCollectionChanged(NotifyCollectionChangedEventArgs args)
	{
	}

	protected override void EliteLevelsCollectionChanged(NotifyCollectionChangedEventArgs args)
	{
	}
}
