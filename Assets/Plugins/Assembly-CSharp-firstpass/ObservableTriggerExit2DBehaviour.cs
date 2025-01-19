using UniRx;
using UnityEngine;

public class ObservableTriggerExit2DBehaviour : ObservableComponent
{
	private Subject<Collider2D> onTriggerExit2D;

	public void OnTriggerExit2D(Collider2D other)
	{
	}

	public IObservable<Collider2D> OnTriggerExit2DAsObservable()
	{
		return null;
	}
}
