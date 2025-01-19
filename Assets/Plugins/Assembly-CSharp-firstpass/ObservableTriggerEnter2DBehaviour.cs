using UniRx;
using UnityEngine;

public class ObservableTriggerEnter2DBehaviour : ObservableComponent
{
	private Subject<Collider2D> onTriggerEnter2D;

	public void OnTriggerEnter2D(Collider2D other)
	{
	}

	public IObservable<Collider2D> OnTriggerEnter2DAsObservable()
	{
		return null;
	}
}
