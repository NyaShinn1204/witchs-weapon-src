using System;
using UnityEngine;

public class NumberSingle : MonoBehaviour
{
	public enum AnimationTypes
	{
		General = 0,
		Critical_A = 1,
		Rise = 2,
		DisplayBoard = 3
	}

	public enum FontTypes
	{
		B_1 = 0,
		B_2 = 1,
		B_3 = 2,
		B_4 = 3,
		B_5 = 4,
		B_7 = 5,
		C_1 = 6
	}

	public enum TextTypes
	{
		None = 0,
		Vampirism = 1
	}

	public Animator animator;

	public UISprite clone;

	public UIWidget container;

	public UISprite text;

	public AnimationTypes animationType;

	public Action<NumberSingle> OnHide;

	public FontTypes fontType;

	public TextTypes textType;

	private Vector3 mTarget;

	private UIPanel mUIPanel;

	public Vector3 Target
	{
		set
		{
		}
	}

	private void LateUpdate()
	{
	}

	public void Show(long num, TextTypes textType = TextTypes.None)
	{
	}

	private string GetSpriteNameByTextType(TextTypes textType)
	{
		return null;
	}

	public void Hide()
	{
	}
}
