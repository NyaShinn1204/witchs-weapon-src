using UniRx;

public class ObservableMouseEnterBehaviour : ObservableComponent
{
	private Subject<Unit> onMouseEnter;

	public void OnMouseEnter()
	{
	}

	public IObservable<Unit> OnMouseEnterAsObservable()
	{
		return null;
	}
}
