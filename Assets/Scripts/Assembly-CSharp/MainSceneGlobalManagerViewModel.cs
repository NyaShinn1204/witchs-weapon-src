using System.Collections.Generic;

public class MainSceneGlobalManagerViewModel : MainSceneGlobalManagerViewModelBase
{
	public virtual CommandWithSender<MainSceneGlobalManagerViewModel> ToBattle
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public MainSceneGlobalManagerViewModel(MainSceneGlobalManagerControllerBase controller, bool initialize = true)
		: base(null, false)
	{
	}

	public MainSceneGlobalManagerViewModel()
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
