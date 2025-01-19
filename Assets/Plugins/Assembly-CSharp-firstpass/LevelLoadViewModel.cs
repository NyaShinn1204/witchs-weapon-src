public sealed class LevelLoadViewModel : ViewModel
{
	public readonly P<float> _Progress;

	public readonly P<string> _Status;

	public float Progress
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public string Status
	{
		get
		{
			return null;
		}
		set
		{
		}
	}
}
