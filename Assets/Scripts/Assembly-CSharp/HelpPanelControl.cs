using UnityEngine;
using WaterBell.ProjX.View.Panel;

public class HelpPanelControl : UIPanelSingle
{
	private static HelpPanelControl m_Current;

	public Transform daily;

	public ButtonEx closeButton;

	public UIScrollView scroll;

	protected override void Start()
	{
	}

	public static HelpPanelControl GetInstance()
	{
		return null;
	}

	public void OpenPanel(string textName)
	{
	}

	public void OpenPanelByDesc(string desc)
	{
	}

	private void Close()
	{
	}
}
