using UnityEngine;

public class UILabelLanguageFont : MonoBehaviour
{
	[HideInInspector]
	[SerializeField]
	private int mStyle;

	public Font LanguageFont
	{
		get
		{
			return null;
		}
	}

	public int LanguageFontSize
	{
		get
		{
			return 0;
		}
	}
}
