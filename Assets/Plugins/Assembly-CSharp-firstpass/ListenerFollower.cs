using UnityEngine;

public class ListenerFollower : MonoBehaviour
{
	private Transform _transToFollow;

	private GameObject _goToFollow;

	private Transform _trans;

	private GameObject _go;

	private SphereCollider _collider;

	public SphereCollider Trigger
	{
		get
		{
			return null;
		}
	}

	public GameObject GameObj
	{
		get
		{
			return null;
		}
	}

	public Transform Trans
	{
		get
		{
			return null;
		}
	}

	private void Awake()
	{
	}

	public void StartFollowing(Transform transToFollow, string soundType, float trigRadius)
	{
	}

	private void LateUpdate()
	{
	}

	private void BatchOcclusionRaycasts()
	{
	}
}
