using UnityEngine;

public class PlatformHide : MonoBehaviour
{
	[HideInInspector]
	[SerializeField]
	private long mHidePlatform;

	[HideInInspector]
	[SerializeField]
	private long mHideLanguage;

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	public void Check()
	{
	}
}
