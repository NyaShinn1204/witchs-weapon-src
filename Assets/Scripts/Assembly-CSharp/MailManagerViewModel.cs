using System.Collections.Generic;
using System.Collections.Specialized;

public class MailManagerViewModel : MailManagerViewModelBase
{
	public virtual P<bool> HaveNewProperty
	{
		get
		{
			return null;
		}
	}

	public virtual bool HaveNew
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual P<int> NotReadNumProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int NotReadNum
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual ModelCollection<MailContentInfoViewModel> Mails
	{
		get
		{
			return null;
		}
	}

	public virtual CommandWithSenderAndArgument<MailManagerViewModel, string> UpdateCommonMailState
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<MailManagerViewModel, string> UpdateSpecialMailState
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<MailManagerViewModel, string> GetAttach
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual CommandWithSenderAndArgument<MailManagerViewModel, string> DeleteNormal
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public MailManagerViewModel(MailManagerControllerBase controller, bool initialize = true)
		: base(null, false)
	{
	}

	public MailManagerViewModel()
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

	protected override void MailsCollectionChanged(NotifyCollectionChangedEventArgs args)
	{
	}
}
