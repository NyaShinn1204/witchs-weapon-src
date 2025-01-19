using UnityEngine;

public class UIStoryDrawPanel
{
	private Transform _view;

	private bool _isShow;

	private Transform _viewBG;

	private int _width_viewBG;

	private Transform _btnDraw;

	private int _width_btnDraw;

	private Transform _viewIcon;

	private int _width_viewIcon;

	private Transform _viewLimit;

	private int _width_viewLimit;

	private UILabel _labelTime;

	private Transform _btnClose;

	private int _index;

	private long _ID;

	public bool IsShow
	{
		get
		{
			return false;
		}
	}

	public long ID
	{
		get
		{
			return 0L;
		}
	}

	public UIStoryDrawPanel(Transform sView)
	{
	}

	private void InitView()
	{
	}

	public void Update()
	{
	}

	public void Show(long sID)
	{
	}

	public void Hide()
	{
	}
}
