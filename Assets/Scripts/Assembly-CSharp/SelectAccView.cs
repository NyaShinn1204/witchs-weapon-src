using System.Collections.Generic;
using WaterBell.ProjX.Data.Entity;
using WaterBell.ProjX.Data.Local;
using WaterBell.ProjX.View.Common;
using WaterBell.ProjX.View.Panel;

public class SelectAccView : RegAndLoginSubView
{
	private static readonly string phoneTypeIconName;

	private static readonly string emailTypeIconName;

	private static readonly string QQTypeIconName;

	private static readonly string WeixinTypeIconName;

	private static readonly string TouristTypeIconName;

	private UserAccCacheMngr cacheMngr;

	public PopupItem currAccItem;

	public CustomPopList AccountList;

	public ButtonEx BackBtn;

	public ButtonEx LoginBtn;

	public ButtonEx jumpBtn;

	protected override void Awake()
	{
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	protected override void ReturnBack2PrevView()
	{
	}

	protected override void AssignUIEvent()
	{
	}

	private void OnClickJumpBtn()
	{
	}

	private void OnClickLoginBtn()
	{
	}

	private void OnClickBackBtn()
	{
	}

	public void ShowAccountListLogin()
	{
	}

	public void OldUserAccountsListLogin()
	{
	}

	private void FailCheckAccountStatus(string errorcode)
	{
	}

	private void LoginProgress()
	{
	}

	private void checkIsTokenOutOfDate(string text)
	{
	}

	public void LoginByEmailSucc()
	{
	}

	private void InitPop(List<UserAccCache> userList)
	{
	}

	private void OnSelectAccout(int index)
	{
	}

	private void OnDeleteAccout(int index)
	{
	}

	private void UpdateItem(UserAccCache user)
	{
	}

	public void AccountListBackToDefaultUser()
	{
	}

	public void OldUserDirectLogin()
	{
	}

	public void CurrentUserDirectloginFailed(string text)
	{
	}

	public void OldUserAccountListError(string text)
	{
	}

	public void ResetUserAccountsAndLogin()
	{
	}
}
