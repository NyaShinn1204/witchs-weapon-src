using System.Collections.Generic;

public class NewExternalElementGraphViewModel : NewExternalElementGraphViewModelBase
{
	public NewExternalElementGraphViewModel(NewExternalElementGraphControllerBase controller, bool initialize = true)
		: base(null, false)
	{
	}

	public NewExternalElementGraphViewModel()
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
