using System.Collections.Generic;

public class PhoneReminderSystemManagerViewModel : PhoneReminderSystemManagerViewModelBase
{
	public virtual P<bool> ShowRedPointProperty
	{
		get
		{
			return null;
		}
	}

	public virtual bool ShowRedPoint
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public PhoneReminderSystemManagerViewModel(PhoneReminderSystemManagerControllerBase controller, bool initialize = true)
		: base(null, false)
	{
	}

	public PhoneReminderSystemManagerViewModel()
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
