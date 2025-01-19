using DarkTonic.MasterAudio;
using UnityEngine;

public class TransformFollower : MonoBehaviour
{
	public Transform RuntimeFollowingTransform;

	private GameObject _goToFollow;

	private Transform _trans;

	private GameObject _go;

	private SphereCollider _collider;

	private string _soundType;

	private bool _willFollowSource;

	private bool _isInsideTrigger;

	private bool _hasPlayedSound;

	private bool _groupLoadFailed;

	private MasterAudioGroup _groupToPlay;

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

	private void Start()
	{
	}

	public void StartFollowing(Transform transToFollow, string soundType, float trigRadius, bool willFollowSource)
	{
	}

	private void StopFollowing()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void PlaySound()
	{
	}

	private void LateUpdate()
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}
}
