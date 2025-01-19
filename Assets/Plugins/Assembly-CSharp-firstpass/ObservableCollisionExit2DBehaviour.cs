using UniRx;
using UnityEngine;

public class ObservableCollisionExit2DBehaviour : ObservableComponent
{
	private Subject<Collision2D> onCollisionExit2D;

	public void OnCollisionExit2D(Collision2D collision)
	{
	}

	public IObservable<Collision2D> OnCollisionExit2DAsObservable()
	{
		return null;
	}
}
