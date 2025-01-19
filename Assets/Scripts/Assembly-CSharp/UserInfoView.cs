using UnityEngine;

public class UserInfoView : MonoBehaviour
{
	private static UserInfoView instance;

	public UserPlayerManagerView uframeView;

	private GameObject HeadIconPrefab;

	public UserIconPrefab userIconPrefab;

	private ChangeHeadIcon ChangeHeadView;

	private ChangeTitleControl changeTitlePanel;

	private ButtonEx ChangeTitleBtn;

	private ChangeNameControl changeNamePanel;

	private ButtonEx ChangeNameBtn;

	private Transform iconTrans;

	private UILabel levelLabel;

	private UILabel fightingLabel;

	private UILabel expLabel;

	private UISprite expSlider;

	private UILabel nameLabel;

	private UILabel titleLabel;

	private GameObject guildTrans;

	private GameObject GuildIconPrefab;

	private Transform GuildIcon;

	private UILabel guildNameLabel;

	private UILabel guildPrivilegeLabel;

	private GuildImg guildImg;

	public static UserInfoView GetInstance()
	{
		return null;
	}

	private void InitObj()
	{
	}

	public void SetInfo()
	{
	}

	private void ReSetUser()
	{
	}

	public void ReFreshHead()
	{
	}

	private void SwitchIcon()
	{
	}

	public void ReSetName()
	{
	}

	public void ReSetTitle()
	{
	}

	private void ReSetGuildInfo()
	{
	}
}
