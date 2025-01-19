using System.Collections.Generic;
using UnityEngine;

public class UIChest : MonoBehaviour
{
	private static UIChest instance;

	public ButtonEx closeBtn;

	public ButtonEx chestChooseGetAwardBtn;

	public ButtonEx chestItemGetAwardBtn;

	public ButtonEx cannelBtn;

	public long dataID;

	private int dataNum;

	private int dataType;

	private long dataTargetID;

	public UIGrid grid;

	public Transform chooseOneWidget;

	public Transform itemWdiget;

	public UILabel chestItemText;

	public Transform itemBg;

	public UILabel itemName;

	public UIChestChooseItemInfo infoView;

	public static UIChest GetInstance()
	{
		return null;
	}

	public void Open(int _type, long _id)
	{
	}

	private static void Init()
	{
	}

	private void Close()
	{
	}

	public void GetAward()
	{
	}

	public void CallBackGetAward()
	{
	}

	private List<LotteryLootData> GetChestItemDatas(long _chestID)
	{
		return null;
	}

	private void CreateChestItems(UIGrid _grid, List<LotteryLootData> _list)
	{
	}

	private void Select(long _targetId)
	{
	}

	public void SelectChooseChest(int _num)
	{
	}

	private void CreateItem(LotteryLootData _data)
	{
	}
}
