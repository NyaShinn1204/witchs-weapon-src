using UniRx;
using UnityEngine;

public class ObservableCollisionExitBehaviour : ObservableComponent
{
	private Subject<Collision> onCollisionExit;

	public void OnCollisionExit(Collision collision)
	{
	}

	public IObservable<Collision> OnCollisionExitAsObservable()
	{
		return null;
	}
}
