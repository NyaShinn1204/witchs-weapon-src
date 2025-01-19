using UniRx;

public class ObservableMouseDragBehaviour : ObservableComponent
{
	private Subject<Unit> onMouseDrag;

	public void OnMouseDrag()
	{
	}

	public IObservable<Unit> OnMouseDragAsObservable()
	{
		return null;
	}
}
