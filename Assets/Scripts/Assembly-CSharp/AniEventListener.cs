using System.Runtime.InteropServices;
using UnityEngine;

public class AniEventListener : MonoBehaviour
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void AniDelegate(string eventName, GameObject go);

	public AniDelegate onAniEvent;

	public void OnAniListenerEvent(string eventName, GameObject go)
	{
	}

	public static AniEventListener Get(GameObject go)
	{
		return null;
	}
}
