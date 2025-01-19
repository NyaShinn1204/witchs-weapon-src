public class ProgressLevelViewModelBase : ViewModel
{
	public P<long> _LevelIdProperty;

	public P<bool> _CanFightProperty;

	public P<bool> _IsClearProperty;

	public P<int> _BattleCountProperty;

	public P<int> _BattleCountMaxProperty;

	public P<bool> _CanSweepProperty;

	public ProgressLevelViewModelBase(ProgressLevelControllerBase controller, bool initialize = true)
	{
	}

	public ProgressLevelViewModelBase()
	{
	}

	public override void Bind()
	{
	}
}
