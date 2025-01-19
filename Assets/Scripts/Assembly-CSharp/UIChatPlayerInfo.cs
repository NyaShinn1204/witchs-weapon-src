using System.Collections.Generic;
using UnityEngine;

public class UIChatPlayerInfo : GUtilUISuper
{
	private class UIChatPlayerInfoButton
	{
		public string name;

		public FunctionListenerEvent eventHD;

		public object arg;
	}

	public ServerDataChatMngr.ServerDataChatItem data;

	private List<UIChatPlayerInfoButton> _listButton;

	private GameObject _viewOffset;

	public void AddButton(string sName, FunctionListenerEvent sEventHD, object sArg)
	{
	}

	protected override void Start()
	{
	}

	private void initView()
	{
	}

	protected override void animClose()
	{
	}

	private void btnMenu(string[] sArgs)
	{
	}

	private void close()
	{
	}
}
