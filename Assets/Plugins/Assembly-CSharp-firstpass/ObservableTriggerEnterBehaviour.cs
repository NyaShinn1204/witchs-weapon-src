using UniRx;
using UnityEngine;

public class ObservableTriggerEnterBehaviour : ObservableComponent
{
	private Subject<Collider> onTriggerEnter;

	public void OnTriggerEnter(Collider other)
	{
	}

	public IObservable<Collider> OnTriggerEnterAsObservable()
	{
		return null;
	}
}
