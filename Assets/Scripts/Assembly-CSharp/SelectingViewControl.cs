using System.Collections.Generic;
using UnityEngine;
using WaterBell.ProjX.Playmode;
using WaterBell.ProjX.View.Panel;

public class SelectingViewControl : UIPanelBase
{
	public static SelectingViewControl current;

	public IPlayMode currmode;

	private GameObject servantPrefab;

	public UIScrollView scroll;

	public GameObject servantGrid;

	private List<long> appearanceSoundList;

	protected override void Awake()
	{
	}

	public override void OpenPanel(UIDataBase mData = null)
	{
	}

	public void PlayAppearanceSound(long svID)
	{
	}

	private void SelectingViewInit()
	{
	}

	public void SetPrefabClose(long _svID, long _rid)
	{
	}

	public void SetPrefabOpen(long _svID)
	{
	}
}
