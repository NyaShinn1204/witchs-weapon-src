using System.Collections.Generic;
using UnityEngine;

public class UILabelLanguageFontCSS : MonoBehaviour
{
	private static UILabelLanguageFontCSS _instance;

	[HideInInspector]
	[SerializeField]
	public Font[] mFont0;

	[HideInInspector]
	[SerializeField]
	public Font[] mFont1;

	[HideInInspector]
	[SerializeField]
	public Font[] mFont2;

	[HideInInspector]
	[SerializeField]
	public Font[] mFont3;

	[HideInInspector]
	[SerializeField]
	public Font[] mFont4;

	[HideInInspector]
	[SerializeField]
	public Font[] mFont5;

	[HideInInspector]
	[SerializeField]
	public Font[] mFont6;

	[HideInInspector]
	[SerializeField]
	public Font[] mFont7;

	[HideInInspector]
	[SerializeField]
	public Font[] mFont8;

	[HideInInspector]
	[SerializeField]
	public Font[] mFont9;

	private static Dictionary<string, Font> _hash;

	private void Awake()
	{
	}

	public static Font GetFontByStyle(int sStyle)
	{
		return null;
	}
}
