using UniRx;
using UnityEngine;

public class ObservableCollisionStay2DBehaviour : ObservableComponent
{
	private Subject<Collision2D> onCollisionStay2D;

	public void OnCollisionStay2D(Collision2D collision)
	{
	}

	public IObservable<Collision2D> OnCollisionStay2DAsObservable()
	{
		return null;
	}
}
