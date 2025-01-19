using UnityEngine;

public class BaseRenderer : MonoBehaviour, IPausedComponent
{
	public float duration;

	public CharacterBase master;

	public bool breakable;

	public bool isPaused;

	protected bool canInterupt;

	protected float removeTime;

	public void Pause()
	{
	}

	public void Resume()
	{
	}

	public void InteruptSelf()
	{
	}
}
