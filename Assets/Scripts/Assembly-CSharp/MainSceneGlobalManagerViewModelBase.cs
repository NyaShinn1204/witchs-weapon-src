public class MainSceneGlobalManagerViewModelBase : ViewModel
{
	protected CommandWithSender<MainSceneGlobalManagerViewModel> _ToBattle;

	public MainSceneGlobalManagerViewModelBase(MainSceneGlobalManagerControllerBase controller, bool initialize = true)
	{
	}

	public MainSceneGlobalManagerViewModelBase()
	{
	}

	public override void Bind()
	{
	}
}
