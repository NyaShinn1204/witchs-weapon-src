using System.Collections.Generic;
using UnityEngine;

public class UIStoryView
{
	public enum UIStoryViewShowType
	{
		IconHide = 0,
		IconShow = 1,
		ViewList = 2
	}

	public enum UIStoryViewType
	{
		Line = 0,
		LineSlant = 1,
		Icon = 2,
		Ring = 3
	}

	public static UIStoryView SHOW_ITEM_ICON;

	private static UIStoryViewShowType? _show_type;

	public UIStoryView preView;

	public List<UIStoryView> nextRingView;

	public List<UIStoryView> nextLineView;

	public List<UIStoryView> nextIconView;

	public GameObject view;

	public UIStoryViewType type;

	public TypeCsvStoryGroup group;

	public List<TypeCsvStory> storys;

	private bool _isShow;

	public string[] _ROME_NUM;

	private UIStoryView _lineEndRing;

	private List<UIStoryView> _lineEndRings;

	public static UIStoryViewShowType SHOW_TYPE
	{
		get
		{
			return default(UIStoryViewShowType);
		}
		set
		{
		}
	}

	private static Vector3 OFFSET_FOR_TYPE
	{
		get
		{
			return default(Vector3);
		}
	}

	public int GetStoryCount
	{
		get
		{
			return 0;
		}
	}

	public int GetStoryCountSee
	{
		get
		{
			return 0;
		}
	}

	public int GetStoryCountUnWrite
	{
		get
		{
			return 0;
		}
	}

	public bool IsLock
	{
		get
		{
			return false;
		}
	}

	public bool IsSee
	{
		get
		{
			return false;
		}
	}

	private bool IsLineSee
	{
		get
		{
			return false;
		}
	}

	private bool IsLineLock
	{
		get
		{
			return false;
		}
	}

	public UIStoryView(GameObject sView, UIStoryView sPreView, UIStoryViewType sType, TypeCsvStoryGroup sCsvStoryGroup = null)
	{
	}

	public int GetNextIndex(UIStoryView sView)
	{
		return 0;
	}

	public void DrawRing()
	{
	}

	public bool DrawRingPosition(float sLerpT = 1f)
	{
		return false;
	}

	public void DrawLine(bool sIsPoint = false)
	{
	}

	public void DrawLinePosition()
	{
	}

	public void DrawIcon()
	{
	}

	public bool DrawIconAlpha(float sLerp = 1f)
	{
		return false;
	}

	private UIStoryView GetLineEndRing()
	{
		return null;
	}

	private List<UIStoryView> GetLineEndRings()
	{
		return null;
	}

	public void Hide()
	{
	}

	public void Show()
	{
	}
}
