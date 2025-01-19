using System.Collections.Generic;

public class MailContentInfoViewModel : MailContentInfoViewModelBase
{
	private MailManagerViewModel _ParentMailManager;

	public virtual P<MailInfo> InfoProperty
	{
		get
		{
			return null;
		}
	}

	public virtual MailInfo Info
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual P<bool> ReadedProperty
	{
		get
		{
			return null;
		}
	}

	public virtual bool Readed
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual P<bool> IsSpecialMailProperty
	{
		get
		{
			return null;
		}
	}

	public virtual bool IsSpecialMail
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual MailManagerViewModel ParentMailManager
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public MailContentInfoViewModel(MailContentInfoControllerBase controller, bool initialize = true)
		: base(null, false)
	{
	}

	public MailContentInfoViewModel()
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
