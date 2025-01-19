using UniRx;

public class ObservableMouseDownBehaviour : ObservableComponent
{
	private Subject<Unit> onMouseDown;

	public void OnMouseDown()
	{
	}

	public IObservable<Unit> OnMouseDownAsObservable()
	{
		return null;
	}
}
