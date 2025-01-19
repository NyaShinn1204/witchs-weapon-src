using System.Collections.Generic;
using Google.Protobuf.Collections;
using Lootmod;
using UnityEngine;
using WaterBell.ProjX.Data.NetIO;

public class UIStory : GUtilUISuper
{
	private class IComparerTypeCsvStoryGroup : IComparer<TypeCsvStoryGroup>
	{
		public int Compare(TypeCsvStoryGroup x, TypeCsvStoryGroup y)
		{
			return 0;
		}
	}

	private NetMsgBase _netmsg;

	private RepeatedField<LootObject> _loot;

	private static List<TypeCsvStoryGroup> _LIST_CSV_STORY_GROUP;

	private static Dictionary<long, List<TypeCsvStoryGroup>> _HASH_CSV_STORY_GROUP;

	private static TypeCsvStoryGroup _CSV_STORY_GROUP_BEGIN;

	private UIScrollView _scrollView;

	private UIScrollBar _scrollBar;

	private UIWidget _selectView;

	private UISprite _selectViewBG;

	private UIStoryList _storyList;

	private UIStoryDrawList _drawList;

	private UIStoryDrawPanel _drawPanel;

	private UISprite[] _BGSprite;

	private UITexture[] _BGTexture;

	private Transform _BtnShowType;

	private Transform _BtnSelect;

	private int _currentGroupIndex;

	private List<IUIStoryGroup> _groups;

	private long _IDSelectStory;

	private IUIStoryGroup currentGroup
	{
		get
		{
			return null;
		}
	}

	private long IDStorySaveMain
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	protected override void Start()
	{
	}

	private void InitView()
	{
	}

	private void DrawGroupButton()
	{
	}

	public void SelectStory(long sIDStory)
	{
	}

	private void BtnShowType()
	{
	}

	private void BtnSelect()
	{
	}

	private void BtnSelectGroup(string[] sArg)
	{
	}

	private void BtnIcon(string[] sArg)
	{
	}

	private void BtnRing(string[] sArg)
	{
	}

	private void BtnCloseStoryList()
	{
	}

	private void BtnUnlockGroup()
	{
	}

	private void BtnStoryItem(string[] sArg)
	{
	}

	private void BtnDraw(string[] sArg)
	{
	}

	private void BtnDrawMini(string[] sArg)
	{
	}

	private void BtnCloseDrawWindow()
	{
	}

	private void BtnDrawItem()
	{
	}

	private void BtnDrawItemYesHD()
	{
	}

	private void SetSelectIcon(UIStoryView sSelect)
	{
	}

	private void OnDestroy()
	{
	}

	private void OnEnable()
	{
	}

	private void AddAndShowLoot()
	{
	}

	protected override void doneEventListener(string sListener)
	{
	}

	private void Update()
	{
	}
}
