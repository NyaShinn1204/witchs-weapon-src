using UniRx;
using UnityEngine;

public class ObservableTriggerStayBehaviour : ObservableComponent
{
	private Subject<Collider> onTriggerStay;

	public void OnTriggerStay(Collider other)
	{
	}

	public IObservable<Collider> OnTriggerStayAsObservable()
	{
		return null;
	}
}
