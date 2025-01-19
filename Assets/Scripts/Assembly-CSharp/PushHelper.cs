using UnityEngine;

public class PushHelper : MonoBehaviour
{
	public float gap;

	public float pushPercent;

	public float pushSpdLimit;

	public float minPushVelocity;

	[HideInInspector]
	public PushHelper instance;

	private void Awake()
	{
	}

	private float GetWeight(CharacterBase cb)
	{
		return 0f;
	}

	private Vector3 getVelocity(CharacterBase cb)
	{
		return default(Vector3);
	}

	private void PushEachOther(CharacterBase cb0, CharacterBase cb1)
	{
	}

	private void FixedUpdate()
	{
	}
}
