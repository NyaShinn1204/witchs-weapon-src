using BestHTTP;
using UnityEngine;
using WaterBell.ProjX.View.Panel;

public class GameNoticeView : RegAndLoginSubView
{
	public UIScrollBar UIScrollBar;

	public GameObject loadingBlock;

	public UILabel noticeContent;

	public UILabel noticeTitle;

	public ButtonEx closeBtn;

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
}
