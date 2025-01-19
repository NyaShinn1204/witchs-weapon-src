using System.Collections.Generic;
using UnityEngine;
using WaterBell.ProjX.View.Panel;

public class LotteryIconSelector : MonoBehaviour
{
	private Transform _Item;

	private UIScrollView _ScrollView;

	private UIGrid _Grid;

	private Transform _Left;

	private Transform _Right;

	private UICenterOnChild _CenterOnChild;

	private List<DrawInfo> _Data;

	private List<GameObject> _Childs;

	private int _LastRed;

	private void Awake()
	{
	}

	private string GetSpriteName(int index)
	{
		return null;
	}

	public void CreateAllChild(List<DrawInfo> drawInfos)
	{
	}

	public void CenterOn(int index)
	{
	}
}
