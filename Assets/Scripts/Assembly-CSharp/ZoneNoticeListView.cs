using BestHTTP;
using UnityEngine;
using WaterBell.ProjX.View.Panel;

public class ZoneNoticeListView : RegAndLoginSubView
{
	public UIScrollBar UIScrollBar;

	public UIScrollView UIScrollView;

	public GameObject loadingBlock;

	public UIGrid NoticeUIGrid;

	public UILabel noticeContent;

	public UILabel noticeTitle;

	public ButtonEx closeBtn;

	public ButtonEx LBtn;

	public ButtonEx ReBtn;

	public ButtonEx BackGroudBtn;

	public override void Show()
	{
	}

	protected override void AssignUIEvent()
	{
	}

	public void TryFetchAndShowGameNotice()
	{
	}

	private void GetNoticeSuccessful()
	{
	}

	public void RefreshNotice()
	{
	}

	private void GetNoticeFail(string text)
	{
	}

	private void GetNoticeError(string error)
	{
	}

	private void GetNoticeTimeOutDelegate(HTTPRequestStates status)
	{
	}

	private void OnClickCloseBtn()
	{
	}

	private void OnClickLBtn()
	{
	}

	private void OnClickRBtn()
	{
	}
}
