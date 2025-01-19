using UniRx;
using UnityEngine;

public class ObservableTriggerStay2DBehaviour : ObservableComponent
{
	private Subject<Collider2D> onTriggerStay2D;

	public void OnTriggerStay2D(Collider2D other)
	{
	}

	public IObservable<Collider2D> OnTriggerStay2DAsObservable()
	{
		return null;
	}
}
