using System;
using System.Collections.Generic;
using UnityEngine;

public class UIKeyBinding : MonoBehaviour
{
	public enum Action
	{
		PressAndClick = 0,
		Select = 1,
		All = 2
	}

	public enum Modifier
	{
		Any = 0,
		Shift = 1,
		Control = 2,
		Alt = 3,
		None = 4
	}

	private static List<UIKeyBinding> mList;

	public KeyCode keyCode;

	public Modifier modifier;

	public Action action;

	[NonSerialized]
	private bool mIgnoreUp;

	[NonSerialized]
	private bool mIsInput;

	[NonSerialized]
	private bool mPress;

	public static bool IsBound(KeyCode key)
	{
		return false;
	}

	protected virtual void OnEnable()
	{
	}

	protected virtual void OnDisable()
	{
	}

	protected virtual void Start()
	{
	}

	protected virtual void OnSubmit()
	{
	}

	protected virtual bool IsModifierActive()
	{
		return false;
	}

	protected virtual void Update()
	{
	}

	protected virtual void OnBindingPress(bool pressed)
	{
	}

	protected virtual void OnBindingClick()
	{
	}
}
