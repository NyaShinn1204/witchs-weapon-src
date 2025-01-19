using UniRx;

public class ObservableOnDestroyBehaviour : ObservableComponent
{
	private Subject<Unit> onDestroy;

	public void OnDestroy()
	{
	}

	public IObservable<Unit> OnDestroyAsObservable()
	{
		return null;
	}
}
