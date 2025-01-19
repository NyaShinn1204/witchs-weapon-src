using UnityEngine;

public class UIManager : MonoBehaviour
{
	private static UIManager current;

	public static UIManager GetInstance()
	{
		return null;
	}

	public T Get<T>() where T : MonoBehaviour
	{
		return null;
	}
}
