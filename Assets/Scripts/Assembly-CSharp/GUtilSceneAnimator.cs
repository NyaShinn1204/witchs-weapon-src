using UnityEngine;

public class GUtilSceneAnimator : MonoBehaviour
{
	public GameObject view;

	[HideInInspector]
	[SerializeField]
	public string animatorState;

	[SerializeField]
	public bool isDestory;

	[SerializeField]
	private int _preState;

	private void Awake()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void ResetHD(GUtilListenerEvent sEvent)
	{
	}
}
