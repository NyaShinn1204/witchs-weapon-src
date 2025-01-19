using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WaterBell.ProjX.View.Panel;

public class SelectGuildImgControl : UIPanelBase
{
	public enum Btns
	{
		frame = 0,
		shading = 1,
		img = 2
	}

	public Btns currentBtn;

	public static SelectGuildImgControl current;

	public Transform IconWidget;

	public ButtonEx frameBtn;

	public ButtonEx shadingBtn;

	public ButtonEx imgBtn;

	public ButtonEx randomBtn;

	public UIGrid grid;

	public UIScrollView scroll;

	private Dictionary<Btns, ArrayList> Names;

	private ArrayList frameNames;

	private ArrayList shadingNames;

	private ArrayList imgNames;

	private GameObject go;

	private GameObject IconGo;

	private List<TypeCsvEmblem> list;

	private string currentFrameName;

	private string currentShadingName;

	private string currentImgName;

	public long frameID;

	public long shadingID;

	public long imgID;

	private bool isRandom;

	public Transform colorItems;

	[HideInInspector]
	public int currentFrameColorIndex;

	[HideInInspector]
	public int currentShadingColorIndex;

	[HideInInspector]
	public int currentImgColorIndex;

	private Dictionary<Btns, List<Color>> arrs;

	private Dictionary<Btns, int> selectColorIndex;

	public override void OpenPanel(UIDataBase mData = null)
	{
	}

	private void RandomSetImg()
	{
	}

	private void SetSelectItem(Btns _btn)
	{
	}

	private void SetCurrentMainImg(string _frame, string _shading, string _img, int _frameColor, int _shadingColor, int _imgColor)
	{
	}

	private void Init()
	{
	}

	public void DrawImg(Btns _btn, string _name)
	{
	}

	private void DrawGuildIcon()
	{
	}

	private void TabBtnClick(Btns btn, string _name, int _indexColor)
	{
	}

	private void SetBtnUI(Btns btn)
	{
	}

	public long GetId(string _name)
	{
		return 0L;
	}

	private void RandomBtnAnim()
	{
	}

	private void RandomBtnAnimBack()
	{
	}

	private void SetIsRandom()
	{
	}

	private string GetRandomNum(ArrayList _names)
	{
		return null;
	}

	private int GetRandomColor(Btns _btn)
	{
		return 0;
	}

	private void AddEvent()
	{
	}

	private void SetItemsUIColor(Btns _btn)
	{
	}

	public void GetCurrentColorIndex(int _index)
	{
	}

	private void SetGuildImgItemColor(Btns _btn, int _index)
	{
	}
}
