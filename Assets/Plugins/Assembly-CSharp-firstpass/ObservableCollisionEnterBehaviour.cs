using UniRx;
using UnityEngine;

public class ObservableCollisionEnterBehaviour : ObservableComponent
{
	private Subject<Collision> onCollisionEnter;

	public void OnCollisionEnter(Collision collision)
	{
	}

	public IObservable<Collision> OnCollisionEnterAsObservable()
	{
		return null;
	}
}
