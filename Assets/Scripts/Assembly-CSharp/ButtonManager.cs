using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
	public enum ButtonType
	{
		ButtonTaskGuide = 0
	}

	public static ButtonManager _current;

	private static Dictionary<string, Transform> _hash;

	public static Transform GetButton(ButtonType sType)
	{
		return null;
	}

	public static Transform GetButton(string sName)
	{
		return null;
	}

	public static Transform SetButton(Transform sParent, ButtonType sType)
	{
		return null;
	}

	public static Transform SetButton(Transform sParent, string sName)
	{
		return null;
	}

	private void Awake()
	{
	}
}
