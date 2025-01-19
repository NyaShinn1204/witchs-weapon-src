using UnityEngine;

public class ObjectEmiter : MonoBehaviour
{
	public int maxCount;

	public float speed;

	public float aSpeed;

	public float delay;

	public float startRadius;

	private float startTime;

	public float lifeTime;

	private BetterList<Transform> children;

	private GameObject instance;

	public bool isPaused;

	private float radSpace;

	private float radius;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
