using UniRx;

public class ObservableMouseExitBehaviour : ObservableComponent
{
	private Subject<Unit> onMouseExit;

	public void OnMouseExit()
	{
	}

	public IObservable<Unit> OnMouseExitAsObservable()
	{
		return null;
	}
}
