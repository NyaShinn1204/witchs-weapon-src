using System;
using WaterBell.ProjX.View.Panel;

public sealed class BattleScreenPanel : UIPanelSingle
{
	private bool _isHide;

	private const float farawayPos = 9999f;

	private bool isShowPauseBar;

	public bool isHide
	{
		get
		{
			return false;
		}
	}

	protected override void Start()
	{
	}

	public void OnLoadIn(bool isBanPauseBar)
	{
	}

	public void OnRestart()
	{
	}

	public void ToggleUI()
	{
	}

	public void ShowUI()
	{
	}

	public void HideUI()
	{
	}

	public void SetPauseBar(bool isShow)
	{
	}

	public void HidePauseBar()
	{
	}

	public void ShowPauseBar()
	{
	}

	public override void OpenPanel(UIDataBase mData = null)
	{
	}

	public override void ClosePanel(Action action = null)
	{
	}

	public void OpenPausePanel()
	{
	}
}
