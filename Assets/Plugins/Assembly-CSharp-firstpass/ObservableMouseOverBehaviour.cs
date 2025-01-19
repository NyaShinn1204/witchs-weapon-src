using UniRx;

public class ObservableMouseOverBehaviour : ObservableComponent
{
	private Subject<Unit> onMouseOver;

	public void OnMouseOver()
	{
	}

	public IObservable<Unit> OnMouseOverAsObservable()
	{
		return null;
	}
}
