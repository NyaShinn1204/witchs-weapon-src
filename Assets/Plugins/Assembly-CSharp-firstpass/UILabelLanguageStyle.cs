using System.Collections.Generic;
using UnityEngine;

public class UILabelLanguageStyle : MonoBehaviour
{
	private static Dictionary<string, TypeCsvUILabelLanguageStyle> _hashStyle;

	[HideInInspector]
	[SerializeField]
	private string[] mStyle;

	private UILabel mLabel;

	private static Dictionary<string, TypeCsvUILabelLanguageStyle> hashStyle
	{
		get
		{
			return null;
		}
	}

	private void Start()
	{
	}

	private void ChangeLanaguage(GUtilListenerEvent sEvent)
	{
	}

	private void OnDestroy()
	{
	}
}
