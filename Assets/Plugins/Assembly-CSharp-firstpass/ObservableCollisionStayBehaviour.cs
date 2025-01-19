using UniRx;
using UnityEngine;

public class ObservableCollisionStayBehaviour : ObservableComponent
{
	private Subject<Collision> onCollisionStay;

	public void OnCollisionStay(Collision collision)
	{
	}

	public IObservable<Collision> OnCollisionStayAsObservable()
	{
		return null;
	}
}
