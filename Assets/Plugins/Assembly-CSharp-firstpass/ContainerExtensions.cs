public static class ContainerExtensions
{
	public static void RegisterViewModel<TViewModel>(this IGameContainer container, TViewModel viewModel, string identifier) where TViewModel : ViewModel
	{
	}

	public static void RegisterController<TController>(this IGameContainer container, TController controller) where TController : Controller
	{
	}

	public static void RegisterViewModelController<TController, TViewModel>(this IGameContainer container, TController controller) where TController : Controller
	{
	}
}
