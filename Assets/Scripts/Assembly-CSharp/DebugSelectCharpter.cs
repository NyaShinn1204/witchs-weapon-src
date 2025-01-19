using System.Collections.Generic;
using UnityEngine;
using WaterBell.LevelDesign;

public class DebugSelectCharpter : MonoBehaviour
{
	public DebugBattle debugBattle;

	public ButtonEx closeBtn;

	public UIScrollView charpterScroll;

	public UIGrid charpterGrid;

	private GameObject charpterItem;

	private long currentID;

	private void Awake()
	{
	}

	public void Open(List<CustomDataRow> _list)
	{
	}

	private void Select(LevelSetDataRow data, int index)
	{
	}
}
