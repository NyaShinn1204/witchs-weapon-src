using UnityEngine;

public class MutiStateController : MonoBehaviour
{
	protected BetterList<Animator> animators;

	public GameObject[] targets;

	public HoldableButton button;

	public string[] States;

	public int current;

	private void Start()
	{
	}

	public virtual void switchToNext(GameObject go)
	{
	}

	public virtual void switchToNext()
	{
	}
}
