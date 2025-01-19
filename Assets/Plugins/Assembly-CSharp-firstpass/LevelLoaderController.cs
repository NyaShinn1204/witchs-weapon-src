using System.Collections;
using System.Diagnostics;

public class LevelLoaderController : Controller
{
	public static ISwitchLevelSettings Settings
	{
		get
		{
			return null;
		}
	}

	protected LevelLoadViewModel Progress
	{
		get
		{
			return null;
		}
	}

	public void ProgressUpdated(string message, float progress)
	{
	}

	[DebuggerHidden]
	protected IEnumerator Load()
	{
		return null;
	}

	public override ViewModel CreateEmpty()
	{
		return null;
	}

	public override void Initialize(ViewModel viewModel)
	{
	}
}
