using UnityEngine;
using WaterBell.ProjX.View.Panel;

public class TrialSelectLevel : UIPanelBase
{
	public UILabel number;

	public UILabel need_vit;

	public UIGrid grid;

	[HideInInspector]
	public long[] levelsID;

	private int costVit;

	private bool isEnoughNumber;

	public void OpenWds()
	{
	}

	public void CloseWds()
	{
	}

	public void ShowLevel(long _chapterID)
	{
	}

	private void SetSelectBg(int _dataCount)
	{
	}

	private void ShowLevelLock(ModelCollection<DailyInstanceViewModel> levels)
	{
	}

	public bool CanGoLevelDetail(long _levelID, int index, int _lockType)
	{
		return false;
	}

	public void GoLevelDetail(long _levelID, int index, int _lockType)
	{
	}
}
