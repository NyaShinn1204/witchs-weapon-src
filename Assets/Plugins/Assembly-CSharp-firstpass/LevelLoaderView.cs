public abstract class LevelLoaderView : View<LevelLoadViewModel>
{
	public override void Bind()
	{
	}

	protected virtual void ProgressChanged(float progressValue)
	{
	}

	protected virtual void StatusChanged(string statusMessage)
	{
	}

	public override ViewModel CreateModel()
	{
		return null;
	}

	protected override void InitializeViewModel(LevelLoadViewModel viewViewModel)
	{
	}
}
