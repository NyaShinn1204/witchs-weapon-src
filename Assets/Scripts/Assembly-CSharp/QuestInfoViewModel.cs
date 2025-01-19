using System.Collections.Generic;

public class QuestInfoViewModel : QuestInfoViewModelBase
{
	private QuestSystemManagerViewModel _ParentQuestSystemManager;

	public virtual P<long> IDProperty
	{
		get
		{
			return null;
		}
	}

	public virtual long ID
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual P<int> StatusProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int Status
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual P<int> ValidProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int Valid
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual P<int> MetaProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int Meta
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual P<QuestData> InfoProperty
	{
		get
		{
			return null;
		}
	}

	public virtual QuestData Info
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual P<bool> GuideProperty
	{
		get
		{
			return null;
		}
	}

	public virtual bool Guide
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual QuestSystemManagerViewModel ParentQuestSystemManager
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public QuestInfoViewModel(QuestInfoControllerBase controller, bool initialize = true)
		: base(null, false)
	{
	}

	public QuestInfoViewModel()
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
