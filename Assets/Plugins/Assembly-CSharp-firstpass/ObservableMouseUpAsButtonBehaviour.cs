using UniRx;

public class ObservableMouseUpAsButtonBehaviour : ObservableComponent
{
	private Subject<Unit> onMouseUpAsButton;

	public void OnMouseUpAsButton()
	{
	}

	public IObservable<Unit> OnMouseUpAsButtonAsObservable()
	{
		return null;
	}
}
