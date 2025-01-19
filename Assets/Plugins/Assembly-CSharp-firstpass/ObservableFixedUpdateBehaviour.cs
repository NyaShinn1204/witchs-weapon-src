using UniRx;

public class ObservableFixedUpdateBehaviour : ObservableComponent
{
	private Subject<Unit> onFixedUpdate;

	public void FixedUpdate()
	{
	}

	public IObservable<Unit> OnFixedUpdateAsObservable()
	{
		return null;
	}
}
