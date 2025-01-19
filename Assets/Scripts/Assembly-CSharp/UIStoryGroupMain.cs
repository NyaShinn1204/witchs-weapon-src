using System.Collections.Generic;
using UnityEngine;

public class UIStoryGroupMain : IUIStoryGroup
{
	private List<UIStoryView> _listViewRing;

	private List<UIStoryView> _listViewLine;

	private List<UIStoryView> _listViewIcon;

	private bool _IsSwitchShowType;

	private Dictionary<long, UIStoryView> _HASH_UI_STORY_VIEW;

	private UIScrollView _scrollView;

	private UIScrollBar _scrollBar;

	private UIWidget _selectView;

	private UISprite _selectViewBG;

	public bool IsSwitchShowType
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public UIStoryGroupMain(List<TypeCsvStoryGroup> ringsMain, GameObject objRing, GameObject objIcon, GameObject objLine, GameObject objLineSlant, UIScrollView sScrollView, UIScrollBar sScrollBar, UIWidget sSelectView, UISprite sSelectViewBG)
	{
	}

	public void DrawView()
	{
	}

	public UIStoryView GetGroupViewIcon(long sIDGroup)
	{
		return null;
	}

	public void Update(UIStoryList sStoryList, long sIDSelectStory)
	{
	}

	public void Hide()
	{
	}

	public void Show()
	{
	}
}
