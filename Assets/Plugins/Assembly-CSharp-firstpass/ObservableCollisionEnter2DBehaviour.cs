using UniRx;
using UnityEngine;

public class ObservableCollisionEnter2DBehaviour : ObservableComponent
{
	private Subject<Collision2D> onCollisionEnter2D;

	public void OnCollisionEnter2D(Collision2D collision)
	{
	}

	public IObservable<Collision2D> OnCollisionEnter2DAsObservable()
	{
		return null;
	}
}
