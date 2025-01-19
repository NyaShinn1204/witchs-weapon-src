using System.Collections.Generic;
using UnityEngine;
using WaterBell.LevelDesign;

public class MirrorCtrl : MonoBehaviour
{
	public GameObject mirrorContentObj;

	public GameObject mirrorMngrBtn;

	public UIButton spTab;

	public UIButton guideTab;

	public UIButton achieveTab;

	public UIButton uiTab;

	public UIButton combatTab;

	public UIButton elseTab;

	private List<UIButton> cacheTabs;

	public UIButton saveBtn;

	public UIButton loadBtn;

	public UITable mirrorTable;

	private MirrorIndex mirrorIndex;

	private bool isMirrorMngrlPanelOpened;

	private int currMirrorTabIndex;

	private int currSelectedIndex;

	private void Awake()
	{
	}

	public void OnClickMirrorMngrBtn()
	{
	}

	private void ShowMirrorDefaultPanel()
	{
	}

	private void ShowMirrorPanel(MirrorType mType)
	{
	}

	private void ShowTab(MirrorType mrrType = MirrorType.speical)
	{
	}

	private void ChangeSelectedMirror(Transform itemTransform)
	{
	}

	private void SetMirrorItem2UnselectedlColor(int tabIndex, int selectedIndex)
	{
	}

	private void Try2SaveMirror()
	{
	}

	private void RefreshSaveItemCurrTab()
	{
	}

	private void Try2LoadMirror()
	{
	}

	private void AfterMirrorLoadStartLogin()
	{
	}
}
