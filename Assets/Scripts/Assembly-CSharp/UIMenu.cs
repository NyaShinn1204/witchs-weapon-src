using System.Collections.Generic;
using UnityEngine;

public class UIMenu : GUtilUISuper
{
	private class UIMenuButton
	{
		public string name;

		public FunctionListenerEvent eventHD;

		public object arg;
	}

	private List<UIMenuButton> _listButton;

	private GameObject _viewItem;

	private UISprite _viewBack;

	private bool _isScaleY;

	protected override void Start()
	{
	}

	private void initView()
	{
	}

	public void AddButton(string sName, FunctionListenerEvent sEventHD, object sArg)
	{
	}

	private void btnMenu(string[] sArgs)
	{
	}

	private void btnClose()
	{
	}

	protected override void animClose()
	{
	}
}
