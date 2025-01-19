using UnityEngine;

public class LoginMsgProxy : MonoBehaviour
{
	private static LoginMsgProxy _instance;

	private static bool _isLoad;

	public LoginPreloadingData preloadingData;

	public static LoginMsgProxy GetInstance()
	{
		return null;
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}
}
