using UniRx;
using UnityEngine;

public class ObservableTriggerExitBehaviour : ObservableComponent
{
	private Subject<Collider> onTriggerExit;

	public void OnTriggerExit(Collider other)
	{
	}

	public IObservable<Collider> OnTriggerExitAsObservable()
	{
		return null;
	}
}
