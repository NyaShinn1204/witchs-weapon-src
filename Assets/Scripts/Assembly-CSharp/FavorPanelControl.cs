using System;
using System.Collections.Generic;
using UnityEngine;
using WaterBell.ProjX.Data.Entity;
using WaterBell.ProjX.View.Panel;

public class FavorPanelControl : UIPanelSingle
{
	public ButtonEx UseIngBnt;

	public ButtonEx SettingBtn;

	public ButtonEx DisSettingBtn;

	public ButtonEx LastBtn;

	public ButtonEx NextBtn;

	public ButtonEx DisLastBtn;

	public ButtonEx DisNextBtn;

	public ButtonEx OpenFashionBtn;

	public ButtonEx CloseFashionBtn;

	public ButtonEx CloseFashionDetail;

	public ButtonEx questBtn;

	public ButtonEx image2Btn;

	public ButtonEx image3Btn;

	public ButtonEx image4Btn;

	public UIScrollView headScroll;

	public UIGrid headGrid;

	private GameObject headPrefab;

	public Transform rewards;

	public UIScrollView conditions;

	public UILabel descText;

	public UIScrollView detailScroll;

	public UILabel propertyText;

	public UILabel fashionText;

	public Transform indexIcons;

	public Transform lockIcon;

	public GameObject remindIcon;

	public ButtonEx servantIconBtn;

	public UITexture normalImg;

	public UITexture specialImg;

	public UITexture specialImgBg;

	public Transform mainView;

	public Transform fashionView;

	public Transform fashionDetailView;

	public ServantChangeImageView view;

	public static FavorPanelControl current;

	private int currentIndex;

	private int currentServantMaxFavorLevel;

	public UISprite activityIcon;

	public UILabel activityDesc;

	public UILabel painter;

	private Color color1;

	private Color color2;

	public Transform topImg;

	public Transform bottomImg;

	public UIScrollBar bar;

	public UIScrollView favorPropertyScroll;

	public UIScrollBar favorPropertyScrollBar;

	public UITable favorLevelTable;

	private GameObject favorLevelItem;

	public ButtonEx upBtn;

	public ButtonEx closeBtn;

	public ButtonEx backBtn;

	public Transform show1;

	public Transform show2;

	public UIScrollView favorConditionScroll;

	public UIScrollBar favorConditionScrollBar;

	public UITable favorConditionTable;

	private GameObject favorConditionItem;

	public Transform favors;

	public ButtonEx fashionCloseBtn;

	public UIScrollView dragScrollView;

	private bool isClose;

	public UILabel favorTitleName;

	public UILabel upBtnName;

	public UILabel descTitleName;

	public UILabel descTitleName2;

	public UILabel servantName;

	private const float PHOTO_SCALE_V = 0.7f;

	private int GetCurrentServantImage
	{
		get
		{
			return 0;
		}
	}

	private Dictionary<int, ServantImage> GetServantImageInfos
	{
		get
		{
			return null;
		}
	}

	private int MinSerial
	{
		get
		{
			return 0;
		}
	}

	private int MaxSerial
	{
		get
		{
			return 0;
		}
	}

	public override void OpenPanel(UIDataBase mData = null)
	{
	}

	public override void ClosePanel(Action action = null)
	{
	}

	public void InitMain()
	{
	}

	public void ReSetRemind()
	{
	}

	private void ReSetFavorLevel()
	{
	}

	private void ReSetFavroProperty()
	{
	}

	private void ReSetFavorCondition()
	{
	}

	public List<string> GetCVDesc(int _level)
	{
		return null;
	}

	public void ReSetFavorConditions()
	{
	}

	private void DragConditions()
	{
	}

	public void ReSetFashion()
	{
	}

	private void SetPhoto(long id, UITexture _texture)
	{
	}

	public void ReDraw(int _index)
	{
	}

	public void Setting()
	{
	}

	private void Next()
	{
	}

	private void Last()
	{
	}

	private new void OnEnable()
	{
	}

	private new void OnDisable()
	{
	}

	public void QuestAward()
	{
	}

	public void ImageAward(int _index)
	{
	}

	public void OpenFashion(int _index)
	{
	}

	private void AddEvent()
	{
	}

	private void DrawgEvent()
	{
	}

	private ServantImage GetInfo(int _serial)
	{
		return null;
	}

	private int GetSerialByIndex(int sIndex)
	{
		return 0;
	}
}
